using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompIA
{
    public partial class ListItemPay : UserControl
    {
        EventHandler PaymentRemoved;
        PaymentsPage paymentsPage;
        public ListItemPay(PaymentsPage paymentsPage)
        {
            this.paymentsPage = paymentsPage;
            PaymentRemoved += paymentsPage.OnPaymentChangedEvent;
            InitializeComponent();
        }
        private string _paymentName;

        [Category("Custom Props")]// <---Allows these properties to be accessible in the visual design editor
        public string PaymentName
        {
            get { return _paymentName; }
            set { _paymentName = value; paymentName.Text = value; }
        }
        private string _billingDate;
        [Category("Custom Props")]
        public string BillingDate
        {
            get { return _billingDate; }
            set { _billingDate = value; billingDate.Text = value; }
        }
        [Category("Custom Props")]
        private string _subscriptionType;

        public string PaymentType
        {
            get { return _subscriptionType; }
            set { _subscriptionType = value; purchaseType.Text = value; }
        }


        private string _paymentAmount;
        [Category("Custom Props")]
        public string PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; paymentAmount.Text = value; }
        }
        private int _paymentID;

        public int PaymentID
        {
            get { return _paymentID; }
            set { _paymentID = value; }
        }
        private int _userid;

        public int UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            DataBaseManager.RemovePayment(PaymentID);
            PaymentRemoved?.Invoke(this, EventArgs.Empty);
        }

        private void Edit_lab_DoubleClick(object sender, EventArgs e)
        {
            //PageManager.LoadMainForm(new EditGoalPage(ID));
            new EditPaymentsPage(UserID, PaymentID).Show();
        }

        private void ListItemPay_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse is hovering over it will just become silver
            // Just some visual feedback
            BackColor = Color.Silver;
            Edit_lab.ForeColor = SystemColors.MenuHighlight;
        }

        private void ListItemPay_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            Edit_lab.ForeColor = SystemColors.Control;
        }
    }
}
