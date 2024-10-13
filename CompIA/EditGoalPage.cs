//using CompIA.CostCapDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CompIA
{
    public partial class EditGoalPage : Form
    {
        int goalID;
        User user;
        DataTable accountsGoals,categories;
        DataRow Goal;
        GoalsPage goalsPage;
        // event indicating we need to reload data
        // This page is the publisher and goals will be subscribed.
        public event EventHandler GoalsChanged;
        public event EventHandler<GoalProgressNotification> Notification;
        public class GoalProgressNotification : EventArgs
        {
            public string Message { get; }
            public GoalProgressNotification(string message)
            {
                this.Message = message;
            }
        }
        public EditGoalPage(int userID,int goalID)
        {
            // call the overloaded constructor for the struct
            user = new User(userID);
            this.goalID = goalID;
            accountsGoals = DataBaseManager.GetGoalsData(user.AccountID);
            InitializeComponent();
            // a Linq function where we can find the first instance of the GoalsPageClass
            // in the PageManager
            // If it's not there, null is returned.
            goalsPage = PageManager.mainForms.OfType<GoalsPage>().FirstOrDefault();
            GoalsChanged += goalsPage.OnGoalsChangedEvent;
            Notification += goalsPage.OnBudgetingNotification;
        }

        private void EditGoalPage_Load(object sender, EventArgs e)
        {
            PopulateCategoryCombo(); // calls return Goals of category asw
            FillDefaultText();
        }

        void FillDefaultText() 
        {
            returnCurrentGoal();
            goalNameInp.Text = Goal["GoalName"].ToString();
            savAmtInp.Text = Decimal.Round(Goal.Field<Decimal>("SavingAmount"),2).ToString();
            amtCompInp.Text = Decimal.Round(Goal.Field<Decimal>("AmountCompleted"), 2).ToString();
            PrioInp.Text = Goal.Field<int>("Priority").ToString();
            dueDatePicker.Value = Goal.Field<DateTime>("DueDate");
        }

        // populates the ComboBox of categories
        #region populate category Combo
        void PopulateCategoryCombo()
        {
            categories = returnGoalsOfCategory();
            string[] combo = new string[categories.Rows.Count];
            for (int i = 0; i < categories.Rows.Count; i++)
            {
                combo[i] = categories.Rows[i].Field<String>("CategoryName");
            }
            categoryCombo.Items.AddRange(combo);
        }
        // returns all the Categories linked to the Account ID
        DataTable returnGoalsOfCategory() 
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT * FROM Category WHERE AccountID = @ID";
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ID",user.AccountID);
                adapter?.Fill(dataTable);
            }
            return dataTable;
        }
        #endregion
        void returnCurrentGoal()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT * FROM Goals WHERE id = @GoalID";
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@GoalID", goalID);
                adapter?.Fill(dataTable);
            }
            if (dataTable.Rows.Count > 0)
            {
                Goal = dataTable.Rows[0];
            }
        }
        #region Commiting to DB
        // updates the goal dataRow with the userInput
        //called within confirm changes 
        // remember to update the category asw!
        void updateGoalData() 
        {
            Goal.SetField<String>("GoalName",goalNameInp.Text);
            Goal.SetField<Decimal>("SavingAmount", Convert.ToDecimal(savAmtInp.Text));
            Goal.SetField<Decimal>("AmountCompleted", Convert.ToDecimal(amtCompInp.Text));
            Goal.SetField<int>("Priority", int.Parse(PrioInp.Text));
            Goal.SetField<DateTime>("DueDate", dueDatePicker.Value);
            Goal.SetField<Boolean>("IsCompleted", CompleteBox.Checked);
            { // Handling the goalType
                if (goalTypeCombo.SelectedItem.ToString() == "Saving Goal")
                {
                    Goal.SetField<Boolean>("IsSavingGoal", true);
                }
                else if (goalTypeCombo.SelectedItem.ToString() == "Budgeting Goal")
                {
                    Goal.SetField<Boolean>("IsSavingGoal", false);
                }
                else
                {
                    Goal.SetField<Boolean>("IsSavingGoal", true);
                }
            } // Goal Type is set in this block
        }
        void updateCategory()
        {
            // I need to find the category ID which are linked via
            // categoryGoals
            int categoryID = returnCategory();
            string query = "Update CategoryGoals Set CategoryID = @CategoryID Where GoalID = @GoalID;";
            List<SqlParameter> sqlparams = new List<SqlParameter>
            { new SqlParameter("@CategoryID",categoryID),
               new SqlParameter("@GoalID",goalID)
            };
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddRange(sqlparams.ToArray());
                command.ExecuteScalar();
            }
        }
        int returnCategory() // needs the new category
        {
            int categoryID = -1;
            DataTable dataTable = new DataTable();
            string query = @"Select Id From Category Where Category.CategoryName = @CategoryName;";

            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CategoryName", categoryCombo.SelectedItem.ToString());
                adapter?.Fill(dataTable);
            }
            categoryID = dataTable.Rows[0].Field<int>("Id"); 
            return categoryID;
        }
        private void confirmButton_MouseClick(object sender, MouseEventArgs e)
        {
            // Add in some protection to ensure that the user doesn't put 
            // nothing into the categorye
           // if(con)
            ConfirmChangesInDatabase();
        }

        void ConfirmChangesInDatabase() // we need to do a sql query to update the database
        {
            updateGoalData();
            updateCategory();
            string query = @"UPDATE Goals SET GoalName = @GoalName,IsSavingGoal = @GoalType,DueDate = @DueDate," +
                "Goals.Priority = @Priority,AmountCompleted = @AmountCompleted,SavingAmount = @SavingAmount," +
                "IsCompleted = @IsCompleted " +
                "WHERE id = @ID;";
            List<SqlParameter> sqlparam = new List<SqlParameter>
            {
                new SqlParameter("@GoalName",Goal["GoalName"]),
                new SqlParameter("@GoalType",Goal["IsSavingGoal"]),
                new SqlParameter("@DueDate",Goal["DueDate"]),
                new SqlParameter("@Priority",Goal["Priority"]),
                new SqlParameter("@AmountCompleted",Goal["AmountCompleted"]),
                new SqlParameter("@IsCompleted",Goal["IsCompleted"]),
                new SqlParameter("@SavingAmount",Goal["SavingAmount"]),
                new SqlParameter("@ID", goalID)
            };
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddRange(sqlparam.ToArray());
                command.ExecuteScalar();
            }
            // Invokes the event if its not null
            // using conditional operator
            GoalsChanged?.Invoke(this, EventArgs.Empty);
            Notification?.Invoke(this, new GoalProgressNotification(GenerateNotification()));
        }

        string GenerateNotification ()
        {
            string message = "";
            Decimal amtComp = Convert.ToDecimal(amtCompInp.Text), savamt = Convert.ToDecimal(savAmtInp.Text);
            int progress = Convert.ToInt32((amtComp / savamt) * 100);
            if (progress > 30 && progress <= 50)
            {
                message = $"You have completed more than 30% of {goalNameInp.Text}";
            }
            else if (progress > 50 && progress <= 75)
            {
                message = $"You have completed more than 50% of {goalNameInp.Text}";
            }
            else if (progress > 75)
            {
                message = $"You have completed more than 75% of {goalNameInp.Text}";
            } else { message = ""; }
            return message;
        }
    }
    #endregion
}
