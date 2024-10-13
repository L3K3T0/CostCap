using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
// Go to solution exlplorer -> right click project -> manage nuGet extensions -> htmlAgilityPack
using HtmlAgilityPack;

namespace CompIA
{
    public partial class HomePage : Form
    {
        User user;
        string interestRate = "", inflationRate = "";
        DataTable accountsGoals, payments;
        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(User user)
        {
            InitializeComponent();
            this.user = user;
            #region WebScraping
            HtmlWeb web = new HtmlWeb();
            // there is ambiguity between Windows forms HtmlDocument so include this!
            HtmlAgilityPack.HtmlDocument interestDoc = web.Load("https://www.bankofengland.co.uk/boeapps/database/Bank-Rate.asp");
            // It wants the xpath of the document. So Inspect element or F12 -> Ctrl + Shift + C
            // then right click the element and copy xpath
            interestRate = interestDoc.DocumentNode.SelectNodes("/html/body/div[2]/div[2]/section[1]/div/div[1]/div[1]/p[2]").First().InnerText;
            interest_display.Text = interestRate;
            //getInflationRate();
            //
            HtmlAgilityPack.HtmlDocument inflationDoc = web.Load("https://www.ons.gov.uk/economy/inflationandpriceindices/bulletins/consumerpriceinflation/november2023#:~:text=The%20core%20CPIH%20annual%20inflation,in%20the%20constructed%20historical%20series.");
            inflationRate = inflationDoc.DocumentNode?.SelectNodes("/html/body/main/div/div[1]/div/div/div[2]")?.First()?.InnerText;
            inflation_display.Text = "5.2%";
            #endregion
        }

        private void goals_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageManager.MainFormRemove<HomePage>(this);
            PageManager.LoadMainForm<GoalsPage>(new GoalsPage(this.user));
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            salary_inp.Text = PageManager.Salary;
            un_label.Text = user.Username;
            accountsGoals = DataBaseManager.GetGoalsData(user.AccountID);
            payments = DataBaseManager.GetPaymentsData(user.AccountID);
            // but the database won't allow me to add a new table ffs
            populateSubsDisplay();
            populateGoalsChart();
            subs_display.Text ="£"+ DataBaseManager.ReturnTotal(payments, "isSubscription", true, "PaymentAmount").ToString();
            totalPayments_lab.Text = "Total Payments: " + payments.Rows.Count.ToString();
            string interestNoti = $"The interest rate has increased to {interest_display.Text} consider saving!";
            if (PageManager.msgBox)
            { 
              MessageBox.Show(interestNoti, "Interest Notification"); 
              PageManager.msgBox = false;
            }
            if (accountsGoals.Rows.Count != 0)
            {

                string goalName = accountsGoals.Rows[0].Field<String>("GoalName");
                decimal amtCompleted = Decimal.Round(accountsGoals.Rows[0].Field<Decimal>("AmountCompleted"),2);
                decimal savingAmt = Decimal.Round( accountsGoals.Rows[0].Field<Decimal>("SavingAmount"),2);
                string message = $"Highest priority goal progress: \nName: {goalName} \nCompletion: {amtCompleted}/{savingAmt}";
                Random random = new Random();
                int num = random.Next(0, 10);
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Goal Progress";
                popup.ContentText = message;
                if (num == 0)
                {
                    popup.Popup();
                }
            }
        }

        private void payements_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageManager.LoadMainForm<PaymentsPage>(new PaymentsPage(user));
            PageManager.MainFormRemove<HomePage>(this);
        }

        private void salary_inp_TextChanged(object sender, EventArgs e)
        {
            PageManager.Salary = salary_inp.Text;
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            PageManager.CloseApp();
        }

        private void populateSubsDisplay() 
        {
            Label[] subsDisplays = { subs1_display, subs2_display, subs3_display };
            if (payments.Rows.Count != 0)
            {
                int i = 0;
                foreach (Label lab in subsDisplays)
                {
                    if (i + 1 > payments.Rows.Count)
                    {
                        lab.Text = "No more payments!";
                    }
                    else // concatenate the required displayed string
                    {
                        string paymentName = payments.Rows[i].Field<String>("PaymentName");
                        decimal paymentAmt =Decimal.Round( payments.Rows[i].Field<Decimal>("PaymentAmount"),2);
                       lab.Text = $"{i + 1}. {payments.Rows[i].Field<String>("PaymentName")} £{paymentAmt.ToString()}";
                    }
                    i++;

                }
            }
            else { subs1_display.Text = "No payments yet!"; subs2_display.Text = ""; subs3_display.Text = ""; }
        }
        private void populateGoalsChart()
        {


            if (accountsGoals.Rows.Count < 1) { ChartTitle.Text = "No goals yet!"; }
            else 
            {
                // accountsGoals is a datatable of the users goals ordered by priority
                string goalName = accountsGoals.Rows[0].Field<String>("GoalName").ToString();
                DateTime dueDate = accountsGoals.Rows[0].Field<DateTime>("DueDate");
                DateTime today = DateTime.Today;
                TimeSpan difference = dueDate - today; // returns the difference in due dates
                int diffDays = (int)difference.TotalDays; // casts the double into an integer
                // as the timespan method returns the decimal difference in days
                if (diffDays > 0)
                {   // Concatenate the read GoalName from goal
                    ChartTitle.Text = $" {goalName} - Due in {diffDays} Days";
                }
                else { ChartTitle.Text = $" {goalName} - OverDue!"; }
                // money is represented as a decimal
                float savingAmt = float.Parse(accountsGoals.Rows[0].Field<Decimal>("SavingAmount").ToString());
                float amtSaved = float.Parse(accountsGoals.Rows[0].Field<Decimal>("AmountCompleted").ToString());
                float amtToSave = savingAmt - amtSaved;
                goalsChart.Series["s1"].Points.AddXY("Saved", amtSaved.ToString());
                goalsChart.Series["s1"].Points.AddXY("To save", amtToSave.ToString());
            }
        }
        
    }
}
