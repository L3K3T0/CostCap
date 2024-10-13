using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace CompIA
{
    public partial class GoalsPage : Form
    {
        // I'm gonna need a scroll for the page to get all the pages in. I'm gonna need to hide tabs and shii. Difficult af
        // You need to consider what to do for goals that are alr compeleted sha
        User user;
        DataTable accountsGoals, payments, categories;
        Color[] palette = { Color.LightBlue, Color.LightGreen,Color.LightSkyBlue,Color.LightPink};
        int index;
        public GoalsPage(User user)
        {
            this.user = user;
            InitializeComponent();
            accountsGoals = DataBaseManager.GetGoalsData(user.AccountID);
            categories = DataBaseManager.GetCategoryNames(user.AccountID);
            index = -1;
        }
        #region Subscribers
        // this is subscribed by each EditGoalPage instance
        // just reloads the information on the page
        public void OnGoalsChangedEvent(object sender, EventArgs e)
        {
            initialisePage();
        }
        public void OnCategoryAddedEvent(object sender, CategoryBox.CategoryChangedEventArgs e)
        {
            AddNewCategory(e.CategoryName);
        }
        public void OnBudgetingNotification(object sender, EditGoalPage.GoalProgressNotification e)
        {
            BudgetingGoalNotification(e.Message);     
        }
        // This is called relatively late in the function calls! => as a heads up
        private void GoalsPage_Load(object sender, EventArgs e)
        {
            index = -1;
            initialisePage();
        }
        #endregion
        void initialisePage()
        {
            un_label.Text = user.Username;
            accountsGoals = DataBaseManager.GetGoalsData(user.AccountID);
            categories = DataBaseManager.GetCategoryNames(user.AccountID);
            PopulateGoalsCharts();
            PopulateCategories();
            PopulateProgressLabs();
            PopulateCompletedGoals(accountsGoals);
        }
        void BudgetingGoalNotification(string message) 
        {
            if (message != "")
            {
                BudgetingNotification bn = new BudgetingNotification(message);
                bn.Show();
            }
        }
        void PopulateGoalsCharts()
        {
            if (accountsGoals.Rows.Count < 1)
            { MainChartLab.Text = "No goals yet"; Chart2Lab.Text = ""; Chart3Lab.Text = ""; 
                priorityLab.Text = "No goals yet"; priorityLab2.Text  = "No more goals"; priorityLab3.Text = "No more goals";
            }
            else if (accountsGoals.Rows.Count == 1)
            {
                Chart2Lab.Text = ""; Chart3Lab.Text = "";
                priorityLab2.Text = "No more goals"; priorityLab3.Text = "No more goals";
                PopulateChart(goalsChart,0);
                MainChartLab.Text = getChartTitle(0);
                priorityLab.Text = getChartTitle(0);
            }
            else if (accountsGoals.Rows.Count == 2)
            {
                Chart3Lab.Text = ""; priorityLab3.Text = "No more goals";
                PopulateChart(goalsChart, 0);
                MainChartLab.Text = getChartTitle(0);
                priorityLab.Text = getChartTitle(0);
                PopulateChart(goalsChart2, 1);
                Chart2Lab.Text = getChartTitle(1);
                priorityLab2.Text = getChartTitle(1);
            }
            else
            {
                goalsChart = PopulateChart(goalsChart, 0);
                MainChartLab.Text = getChartTitle(0);
                priorityLab.Text = getChartTitle(0);

                goalsChart2 = PopulateChart(goalsChart2, 1);
                Chart2Lab.Text = getChartTitle(1);
                priorityLab2.Text = getChartTitle(1);

                goalsChart3 = PopulateChart(goalsChart3, 2);
                Chart3Lab.Text = getChartTitle(2);
                priorityLab3.Text = getChartTitle(2);
            }
        }
        Chart PopulateChart(Chart chart, int row) 
        {
            // ensures that no data is rolled over
            // when we reload the graphs
            chart.Series["s1"].Points.Clear();
            string savingText ="Saved", toCompleteText = "ToSave";
            if (accountsGoals.Rows[row].Field<Boolean>("IsSavingGoal") == false)
            {
                savingText = "Budget Spent";
                toCompleteText = "Remaining Budget";
            }
            float savingAmt = float.Parse(accountsGoals.Rows[row].Field<Decimal>("SavingAmount").ToString());
            float amtSaved = float.Parse(accountsGoals.Rows[row].Field<Decimal>("AmountCompleted").ToString());
            float amtToSave = savingAmt - amtSaved;
            chart.Series["s1"].Points.AddXY(savingText, amtSaved.ToString());
            chart.Series["s1"].Points.AddXY(toCompleteText, amtToSave.ToString());
            return chart;
        }
        string getChartTitle(int row) 
        {
            string goalName = accountsGoals.Rows[row].Field<String>("GoalName").ToString();
            return goalName;
        }
        int returnBkgcolor()
        {
           index++;
            if (index >= palette.Length)
            {
                index = 0;
            }
            return index;
        }
        int returnCategoryNum() 
        {
            int categoryNum = 0;
            DataTable dataTable = DataBaseManager.GetCategoryNames(user.AccountID);
            categoryNum = dataTable.Rows.Count;
            return categoryNum;
        }
        DataTable returnGoalsOfCategory( int category)
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT Goals.* FROM Goals JOIN CategoryGoals ON Goals.ID = 
                CategoryGoals.GoalID WHERE CategoryGoals.CategoryID = @category;";
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@category", category);
                adapter?.Fill(dataTable);
            }
            return dataTable;
        }
        DataTable returnMonthlyCompleted()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Goals WHERE Goals.IsCompleted  = 1 and Goals.DueDate <= GETDATE() " +
                "and DATEDIFF(month, DueDate , GETDATE()) <= 1";
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter?.Fill(dataTable);
            }
            return dataTable;
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            PageManager.LoadMainForm<HomePage>(new HomePage(user));
                this.Hide();
        }
        void PopulateCategories()
        {
            newGoalButton.Controls.Clear();
            for (int x = 0; x < returnCategoryNum();x++)
            {
                Color bkgColor = palette[returnBkgcolor()];
                CategoryLabel categoryLabel = new CategoryLabel();
                categoryLabel.CategoryLabelText = categories.Rows[x].Field<String>("CategoryName");
                categoryLabel.BkgColor = bkgColor;
                // Create a new instance of ListHeader user control
                ListHeader listHeader = new ListHeader();
                listHeader.GoalName = "GoalName";
                listHeader.DueDate = "Day Due";
                listHeader.Progress = "Progress";
                listHeader.BkgColor = bkgColor;
                newGoalButton.Controls.Add(categoryLabel);
                newGoalButton.Controls.Add(listHeader);

                DataTable GoalsOfCategory = returnGoalsOfCategory(categories.Rows[x].Field<int>("Id"));
                ListItem[] listItems = new ListItem[GoalsOfCategory.Rows.Count]; //aggregation
                                                       // Add the ListHeader user control to the FlowLayoutPanel
                                                       // Add x number of ListItem user controls
                for (int i = 0; i < GoalsOfCategory.Rows.Count; i++)
                {
                    // this process doesn't look nice
                    decimal progress = (GoalsOfCategory.Rows[i].Field<Decimal>("AmountCompleted"))
                        / GoalsOfCategory.Rows[i].Field<Decimal>("SavingAmount");

                    // Create a new instance of ListItem user control
                    ListItem listItem = new ListItem(this);
                    listItem.GoalName = GoalsOfCategory.Rows[i].Field<String>("GoalName");
                    listItem.DueDate = GoalsOfCategory.Rows[i].Field<DateTime>("DueDate").ToString("yyyy-MM-dd");
                    listItem.Progress = $"{Math.Round(progress * 100)}%";
                    listItem.UserID = user.AccountID;
                    listItem.GoalID = GoalsOfCategory.Rows[i].Field<int>("Id");
                    listItems[i] = listItem;
                    // Add the ListItem user control to the FlowLayoutPanel
                    newGoalButton.Controls.Add(listItem);
                }
            } 
        }
        private void timeFrameBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Going from Lifetime to Monthly
            if(timeFrameBtn.Checked == true) 
            {
                // currently in Monthly view
                timeFrameBtn.Text = "Switch Back To Lifetime View";
                lifeTimeLab.Text = "Monthly Goal Completion";
                PopulateCompletedGoals(returnMonthlyCompleted());
            }
            // going from Monthly to Lifetime
            if(timeFrameBtn.Checked == false) 
            { // currently in the lifetime view
                timeFrameBtn.Text = "Switch To Monthly View";
                lifeTimeLab.Text = "Lifetime Goal Completion";
                PopulateCompletedGoals(accountsGoals);
            }
        }

        private void newGoalBtn_Click(object sender, EventArgs e)
        { // create a new goals, also ad a category reference
            if (DataBaseManager.GetCategoryNames(user.AccountID).Rows.Count < 1)
            {
                CatLabelText.Text = "You need to add a category first!";
            }
            else 
            {
                AddNewGoal();
            }
        }
        void AddNewGoal() 
        {
            DataTable dataTable = new DataTable();
            string goalsQuery = "Insert Into Goals Values ('New Goal',0,0.1,21/11/2010,1,@AccountID,0,0);";
            string categoryGoalsQuery = "insert into CategoryGoals values(@GoalID,@CategoryID)";
            List<SqlParameter> sqlparamsGoals = new List<SqlParameter> 
            {
                new SqlParameter("@GoalName","New Goal"),
                new SqlParameter("@isSavingGoal",false),
                new SqlParameter("@SavingAmount",0.01m),
                new SqlParameter("@DueDate",DateTime.Today),
                new SqlParameter("@Priority",1),
                new SqlParameter("@AccountId",user.AccountID),
                new SqlParameter("@AmountCompleted",0.00m),
                new SqlParameter("@isCompleted",false)
            };
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(goalsQuery, connection))
            {
                connection.Open();
               command.Parameters.AddWithValue("@AccountID",user.AccountID);
                command.ExecuteScalar();
            }
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand CategoryGoalscommand = new SqlCommand(categoryGoalsQuery, connection))
            {
                connection.Open();

                CategoryGoalscommand.Parameters.AddWithValue("@GoalID",returnLatestGoalId());
                CategoryGoalscommand.Parameters.AddWithValue("@CategoryID",returnDefaultCategoryID());
                CategoryGoalscommand.ExecuteScalar();
            }
            initialisePage();
        }
        int returnDefaultCategoryID() //used with AddNewGoal function exclusively 
        {
            DataTable dataTable = new DataTable();
            int categoryID = -1;
            string query = "select Top 1 Category.Id from Category where AccountID = @AccountID;";
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@AccountID", user.AccountID);
                adapter?.Fill(dataTable);
            }
            categoryID = dataTable.Rows[0].Field<int>(0);
            return categoryID;
        }
        int returnLatestGoalId() // used as part of the add new goal function
        {
            DataTable dataTable = new DataTable();
            int id = -1;
            // the newly added record would have the highest primary key.
            // so just selct the record w/ the highest prim key
            string query = "Select Top 1 * From Goals Where AccountID = @ID Order by Id Desc;";
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ID", user.AccountID);
                adapter?.Fill(dataTable);
            }
            id = dataTable.Rows[0].Field<int>("Id");
            return id;
        }
        void AddNewCategory(string categoryName) 
        {
            string query = "insert into Category Values (@CategoryName,@AccountID);";
            List<SqlParameter> sqlparams = new List<SqlParameter>
            { new SqlParameter("@CategoryName",categoryName),
             new SqlParameter("@AccountID",user.AccountID),
            };
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddRange(sqlparams.ToArray());
                command.ExecuteScalar();
            }
            initialisePage();
        }

        private void newCatButton_Click(object sender, EventArgs e)
        {
            CategoryBox popup = new CategoryBox(this);
            popup.Show();
        }

        private void GoalsPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            PageManager.CloseApp();
        }

        void PopulateProgressLabs()
        {
            Label[,] labels = { {priorityLab,prioProgressLab}, {priorityLab2,prioProgressLab2 },{priorityLab3, prioProgressLab3} } ;
           // get length returns the number of every item in the array (6 in this case)
           // you must write .getLength(0) to return the number of items in the first dimension
            for (int i = 0;i < labels.GetLength(0);i++) 
            {
               if (i >= accountsGoals.Rows.Count)
                {
                    labels[i, 1].Text = $@"";
                }
                else
               {
                    labels[i, 0].Text = accountsGoals.Rows[i].Field<String>("GoalName");
                    decimal amtCompleted = Decimal.Round(accountsGoals.Rows[i].Field<Decimal>("AmountCompleted"),2);
                    decimal fullamt = Decimal.Round(accountsGoals.Rows[i].Field<Decimal>("SavingAmount"),2);
                   labels[i, 1].Text = $@"£{amtCompleted}/£{fullamt}";
               }
            }
        }
        void PopulateCompletedGoals(DataTable GoalsTable)
        {
            // needed to prevent previous points from accumulating

            finChart.Series["s1"].Points.Clear();

            lifeTimeLab.Text ="Lifetime Goal Completion";
            int completed = 0,pending =0,failed = 0;

            foreach (DataRow row in GoalsTable.Rows)
            {
                bool isCompleted = false, DueDatePassed = false;
                if (row.Field<Boolean>("IsCompleted") == true)
                {
                    isCompleted = true;
                }
                // compares the two date times, if it is negative the duedate is earlier
                // than today
                if (DateTime.Compare(row.Field<DateTime>("DueDate"),DateTime.Today) <0 ) 
                {
                    DueDatePassed = true;
                }

                {
                    if (isCompleted)
                    { completed+= 1; }
                    else if (!isCompleted && !DueDatePassed)
                    {
                        pending+=1;
                    }
                    else { failed += 1; }
                }
            }

            finChart.Series["s1"].Points.AddXY("Completed", completed);
            finChart.Series["s1"].Points.AddXY("Pending", pending);
            finChart.Series["s1"].Points.AddXY("Failed", failed);
        }
    }
}
