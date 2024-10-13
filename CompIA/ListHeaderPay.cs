using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompIA
{
    public partial class ListHeaderPay : UserControl
    {
        public ListHeaderPay()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        private string _paymentName;
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

        private string _paymentAmount;
        [Category("Custom Props")]
        public string PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; paymentAmount.Text = value; }
        }
        private Color bkgcolor;

        public Color BkgColor
        {
            get { return bkgcolor; }
            set { bkgcolor = value; this.BackColor = value; }
        }
    }
}
