using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompIA
{
    public partial class PaymentsPage : Form
    {
        DataTable userPayments,categories;
        Color[] palette = { Color.LightBlue, Color.LightGreen, Color.LightSkyBlue, Color.LightPink };
        int index;
        User user;
        public PaymentsPage(User user)
        {
            index = -1;
            this.user = user;
            InitializeComponent();
            userPayments = DataBaseManager.GetPaymentsData(user.AccountID);
            categories = DataBaseManager.GetCategoryPNames(user.AccountID);
        }

        private void PaymentsPage_Load(object sender, EventArgs e)
        {
            index = -1;
            initialisePage();
            // TODO: This line of code loads data into the 'costCapDBDataSet.Payments' table. You can move, or remove it, as needed.
            // this.paymentsTableAdapter.Fill(this.costCapDBDataSet.Payments);
        }
        public void OnPaymentChangedEvent(object sender, EventArgs e)
        {
            initialisePage();
        }
        public void OnCategoryAddedEvent(object sender, CategoryBox.CategoryChangedEventArgs e)
        {
            userPayments = DataBaseManager.GetPaymentsData(user.AccountID);
            categories = DataBaseManager.GetCategoryPNames(user.AccountID);
            AddNewCategory(e.CategoryName);
        }
        void initialisePage()
        { 

            userPayments = DataBaseManager.GetPaymentsData(user.AccountID);
            categories = DataBaseManager.GetCategoryPNames(user.AccountID);

       

           // dataGridView1.Columns[2].Visible = false;
            GetPaymentsTableState();
            PopulateProgressLabs();
            PopulateCategories();
            PopulatePaymentsChart();
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
        void AddNewPayment()
        {
            DataTable dataTable = new DataTable();
            string goalsQuery = "Insert into Payments values ('New Payment',0,0.1,21/11/2010,@AccountID,0)";
            string categoryGoalsQuery = "Insert into PaymentCategory values(@PaymentID,@CategoryID)";
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

                CategoryGoalscommand.Parameters.AddWithValue("@PaymentID", returnLatestPaymentId());
                CategoryGoalscommand.Parameters.AddWithValue("@CategoryID", returnDefaultCategoryID());
                CategoryGoalscommand.ExecuteScalar();
            }
            initialisePage();
        }
        int returnLatestPaymentId() // used as part of the add new goal function
        {
            DataTable dataTable = new DataTable();
            int id = -1;
            // the newly added record would have the highest primary key.
            // so just selct the record w/ the highest prim key
            string query = "Select Top 1 * From Payments Where AccountID = @ID Order by Id Desc;";
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
        int returnDefaultCategoryID() //used with AddNewPayment function exclusively 
        {
            DataTable dataTable = new DataTable();
            int categoryID = -1;
            string query = "select Top 1 CategoryP.Id from CategoryP where AccountID = @AccountID;";
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
        void AddNewCategory(string categoryName)
        {
            string query = "insert into CategoryP Values (@CategoryName,@AccountID);";
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
        int returnCategoryNum()
        {
            int categoryNum = 0;
            DataTable dataTable = DataBaseManager.GetCategoryPNames(user.AccountID);
            categoryNum = dataTable.Rows.Count;
            return categoryNum;
        }
        DataTable returnPaymentOfCategory(int category)
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT Payments.* FROM Payments JOIN PaymentCategory ON
            Payments.Id = PaymentCategory.PaymentID WHERE PaymentCategory.CategoryPID= @category;";
            using (SqlConnection connection = new SqlConnection(DataBaseManager.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@category", category);
                adapter?.Fill(dataTable);
            }
            return dataTable;
        }
        void PopulateCategories()
        {
            newGoalButton.Controls.Clear();
            for (int x = 0; x < returnCategoryNum(); x++)
            {
                Color bkgColor = palette[returnBkgcolor()];
                CategoryLabel categoryLabel = new CategoryLabel();
                categoryLabel.CategoryLabelText = categories.Rows[x].Field<String>("CategoryName");
                categoryLabel.BkgColor = bkgColor;
                // Create a new instance of ListHeader user control
                ListHeaderPay listHeader = new ListHeaderPay();
                listHeader.PaymentName = "Payment Name";
                listHeader.BillingDate = "Billing Date";
                listHeader.PaymentAmount = "Payment Amount";
                listHeader.BkgColor = bkgColor;
                newGoalButton.Controls.Add(categoryLabel);
                newGoalButton.Controls.Add(listHeader);

                DataTable paymentsOfCategory = returnPaymentOfCategory(categories.Rows[x].Field<int>("Id"));
                ListItem[] listItems = new ListItem[paymentsOfCategory.Rows.Count]; //aggregation
                                                                                 // Add the ListHeader user control to the FlowLayoutPanel
                                                                                 // Add x number of ListItem user controls
                for (int i = 0; i < paymentsOfCategory.Rows.Count; i++)
                {

                    // Create a new instance of ListItem user control
                    ListItemPay listItemPay = new ListItemPay(this);
                    listItemPay.PaymentName = paymentsOfCategory.Rows[i].Field<String>("PaymentName");
                    listItemPay.BillingDate = paymentsOfCategory.Rows[i].Field<DateTime>("BillingDate").ToString("yyyy-MM-dd");
                    listItemPay.PaymentAmount = Decimal.Round(paymentsOfCategory.Rows[i].Field<Decimal>("PaymentAmount"),2).ToString();
                    listItemPay.UserID = user.AccountID;
                    listItemPay.PaymentID = paymentsOfCategory.Rows[i].Field<int>("Id");
                    if (paymentsOfCategory.Rows[i].Field<Boolean>("isSubscription") == true)
                    {
                        listItemPay.PaymentType = "Subscription";
                    }
                    else 
                    {
                        listItemPay.PaymentType = "One-Time";
                    }
                    //listItems[i] = listItemPay;
                    // Add the ListItem user control to the FlowLayoutPanel
                    newGoalButton.Controls.Add(listItemPay);
                }
            }
        }
        void PopulatePaymentsChart()
        {
            finChart.Series["s1"].Points.Clear();
            lifeTimeLab.Text = "Weekly Payments";
            decimal total = 0.00m;
            foreach (DataRow row in userPayments.Rows)
            {
                if (IsInSameWeek(row.Field<DateTime>("BillingDate"), DateTime.Today))
                {
                    total += row.Field<Decimal>("PaymentAmount");
                }
            }
            if (total <= 0)
            {
                lifeTimeLab.Text = "No weekly payments!";
            }
            else
            {
                foreach (DataRow row in userPayments.Rows)
                {
                    if (IsInSameWeek(row.Field<DateTime>("BillingDate"), DateTime.Today))
                    {
                        decimal paymentAmt = row.Field<Decimal>("PaymentAmount");
                        finChart.Series["s1"].Points.AddXY(row.Field<String>("PaymentName"), paymentAmt);
                    }
                }
            }
        }
        static bool IsInSameWeek(DateTime date1, DateTime date2)
        {
            // Check if the years are different
            if (date1.Year != date2.Year)
            {
                return false;
            }

            // Use the Calendar.GetWeekOfYear method to get the week number for each date
            var calendar = System.Globalization.CultureInfo.CurrentCulture.Calendar;
            int week1 = calendar.GetWeekOfYear(date1, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            int week2 = calendar.GetWeekOfYear(date2, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            // Check if the week numbers are the same
            return week1 == week2;
        }
       // iterates through the labels and corresponding rows in the datatable
       // parallel arrays.
        void PopulateProgressLabs()
        {
            Label[,] labels = { { priorityLab, prioProgressLab }, { priorityLab2, prioProgressLab2 }, { priorityLab3, prioProgressLab3 } };
            // get length returns the number of every item in the array (6 in this case)
            // you must write .getLength(0) to return the number of items in the first dimension
            for (int i = 0; i < labels.GetLength(0); i++)
            {
                if (i >= userPayments.Rows.Count)
                {
                    if (i == 0)
                    {
                        labels[i, 0].Text = "No payments yet!";
                    }
                    else
                    {
                        labels[i, 0].Text = "No more Payments!";
                    }
                    labels[i, 1].Text = $@"";
                }
                else
                {
                    labels[i, 0].Text = userPayments.Rows[i].Field<String>("PaymentName");
                    decimal PaymentAmount = Decimal.Round(userPayments.Rows[i].Field<Decimal>("PaymentAmount"), 2);
                    labels[i, 1].Text = $@"£{PaymentAmount}";
                }
            }
        }

        private void newCatButton_Click(object sender, EventArgs e)
        {
            CategoryBox popup = new CategoryBox(this);
            popup.Show();
        }

        void UpdatePaymentsTable() 
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // currently want to display the subscriptions
            GetPaymentsTableState();
        }
        void GetPaymentsTableState()
        {
            // Now in subscriptions
            if (checkBox1.Checked)
            {
                int num = 0;
                dataGridView1.Rows.Clear();
                checkBox1.Text = "Switch Back to One-Time view";
                tableLab.Text = "Showing Subscriptions";
                // Display all subscriptions
                foreach(DataRow row in userPayments.Rows)
                if (row.Field<Boolean>("isSubscription") == true)
                {
                    num += 1;
                    string paymentName = row.Field<string>("PaymentName");
                    decimal paymentAmt = row.Field<Decimal>("PaymentAmount");
                    paymentAmt *= (decimal)(CalculateWeeksPassed(row.Field<DateTime>("BillingDate")) + 1);
                    paymentAmt = decimal.Round(paymentAmt, 2);
                    AddRow(num, paymentName, paymentAmt);
                }
            }
            // Now in One-Time
            else if (!checkBox1.Checked)
            {
                checkBox1.Text = "Switch to Subscriptions payments";
                tableLab.Text = "Showing One-Time payments!";
                int num = 0;
                dataGridView1.Rows.Clear();
                // display all one-time payments
                foreach (DataRow row in userPayments.Rows)
                {
                    if (row.Field<Boolean>("isSubscription") == false)
                    {
                        num += 1;
                        string paymentName = row.Field<string>("PaymentName");
                        decimal paymentAmt = row.Field<Decimal>("PaymentAmount");
                        AddRow(num, paymentName, paymentAmt);
                    }
                }

            }

        }
        int CalculateWeeksPassed(DateTime startDate)
        {
            // Calculate the time difference between the current date and the provided date
            TimeSpan timeDifference = DateTime.Now - startDate;

            // Calculate the number of weeks passed
            int weeksPassed = (int)(timeDifference.TotalDays / 7);
            if (weeksPassed > 52) { weeksPassed = 52; }
            return weeksPassed;
        }
        private void AddRow(int num, string paymentName, decimal paymentAmt)
        {
            // Create a new DataGridViewRow
            DataGridViewRow row = new DataGridViewRow();

            // Create DataGridViewCells and set their values
            DataGridViewCell cell1 = new DataGridViewTextBoxCell { Value = num };
            DataGridViewCell cell2 = new DataGridViewTextBoxCell { Value = paymentName };
            DataGridViewCell cell3 = new DataGridViewTextBoxCell { Value = paymentAmt };

            // Add cells to the row
            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            row.Cells.Add(cell3);

            // Add the row to the DataGridView
            dataGridView1.Rows.Add(row);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageManager.LoadMainForm<HomePage>(new HomePage(user));
        }

        private void PaymentsPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            PageManager.CloseApp();
        }

        private void newGoalBtn_Click(object sender, EventArgs e)
        { // create a new goals, also ad a category reference
            if (DataBaseManager.GetCategoryPNames(user.AccountID).Rows.Count < 1)
            {
                CatLabelText.Text = "You need to add a category first!";
            }
            else
            {
                AddNewPayment();
            }
        }

    }
}
