using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompIA
{
    public partial class EditPaymentsPage : Form
    {
        int paymentsID;
        User user;
        DataTable userPayments, categories;
        DataRow Goal;
        PaymentsPage paymentsPage;
        public event EventHandler PaymentsChanged;
        public EditPaymentsPage(int userID, int paymentsID)
        {
            user = new User(userID);
            this.paymentsID = paymentsID;
            userPayments = DataBaseManager.GetPaymentsData(userID);
            InitializeComponent();
            paymentsPage = PageManager.mainForms.OfType<PaymentsPage>().FirstOrDefault();
            PaymentsChanged += paymentsPage.OnPaymentChangedEvent;
        }
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
            string query = @"SELECT * FROM CategoryP WHERE AccountID = @ID";
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ID", user.AccountID);
                adapter?.Fill(dataTable);
            }
            return dataTable;
        }
        #endregion

        private void EditPaymentsPage_Load(object sender, EventArgs e)
        {
            PopulateCategoryCombo(); // calls return Goals of category asw
            FillDefaultText();
        }
        void FillDefaultText()
        {
            returnCurrentGoal();
            paymentNameInp.Text = Goal["PaymentName"].ToString();
            paymentAmtInp.Text = Decimal.Round(Goal.Field<Decimal>("PaymentAmount"), 2).ToString();
            billingDatePicker.Value = Goal.Field<DateTime>("BillingDate");
        }
        void returnCurrentGoal()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT * FROM Payments WHERE id = @PaymentID";
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PaymentID", paymentsID);
                adapter?.Fill(dataTable);
            }
            if (dataTable.Rows.Count > 0)
            {
                Goal = dataTable.Rows[0];
            }
        }
        #region commiting to DB
        void updatePaymentData()
        {
            Goal.SetField<String>("PaymentName", paymentNameInp.Text);
            Goal.SetField<Decimal>("PaymentAmount", Convert.ToDecimal(paymentAmtInp.Text));
            Goal.SetField<DateTime>("BillingDate", billingDatePicker.Value);
            Goal.SetField<Boolean>("IsCompleted", CompleteBox.Checked);
            { // Handling the goalType
                if (paymentTypeCombo.SelectedItem.ToString() == "Subscription")
                {
                    Goal.SetField<Boolean>("isSubscription", true);
                }
                else if (paymentTypeCombo.SelectedItem.ToString() == "One-time")
                {
                    Goal.SetField<Boolean>("isSubscription", false);
                }
            } // Goal Type is set in this block
        }
        void updateCategory()
        {
            // I need to find the category ID which are linked via
            // categoryGoals
            int categoryID = returnCategory();
            string query = "Update PaymentCategory Set PaymentCategory.CategoryPID= @CategoryID Where PaymentCategory.PaymentID = @PaymentID;";
            List<SqlParameter> sqlparams = new List<SqlParameter>
            { new SqlParameter("@CategoryID",categoryID),
               new SqlParameter("@PaymentID",paymentsID)
            };
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddRange(sqlparams.ToArray());
                command.ExecuteScalar();
            }
        }
        void ConfirmChangesInDatabase() // we need to do a sql query to update the database
        {
            updatePaymentData();
            updateCategory();
            string query = @"UPDATE Payments SET PaymentName = @PaymentName, isSubscription = @isSubscription, 
            PaymentAmount = @PaymentAmount,
            BillingDate = @BillingDate, IsCompleted = @IsCompleted Where Id = @Id;";
            List<SqlParameter> sqlparam = new List<SqlParameter>
            {
                new SqlParameter("@PaymentName",Goal["PaymentName"]),
                new SqlParameter("@isSubscription",Goal["isSubscription"]),
                new SqlParameter("@PaymentAmount",Goal["PaymentAmount"]),
                new SqlParameter("@BillingDate",Goal["BillingDate"]),
                new SqlParameter("@IsCompleted",Goal["IsCompleted"]),
                new SqlParameter("@ID", paymentsID)
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
            PaymentsChanged?.Invoke(this, EventArgs.Empty);
        }
        #endregion
        private void confirmButton_MouseClick(object sender, MouseEventArgs e)
        {
            // Add in some protection to ensure that the user doesn't put 
            // nothing into the categorye
            // if(con)
            ConfirmChangesInDatabase();
        }

        int returnCategory() // needs the new category
        {
            int categoryID = -1;
            DataTable dataTable = new DataTable();
            string query = @"Select Id From CategoryP Where CategoryP.CategoryName = @CategoryName;";

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

    }
}
