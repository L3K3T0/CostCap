using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompIA
{
    public partial class CategoryBox : Form
    {
        GoalsPage goalsPage;
        PaymentsPage paymentsPage;
        private string categoryName;
        // define an custom event using passing in our custom
        //EventhandlerClass as the generic type parameter
        public event EventHandler<CategoryChangedEventArgs> CategoryChanged;
        // we need to define a custom EventArgs Class to pass the information of CategoryName
        // as typically events args pass no information
        public class CategoryChangedEventArgs : EventArgs
        {
            public string CategoryName { get; }

            public CategoryChangedEventArgs(string categoryName)
            {
                CategoryName = categoryName;
            }
        }

        // Overloaded constructor to deal with the goals Page
        public CategoryBox(GoalsPage goalsPage)
        {
            InitializeComponent();
            this.goalsPage = goalsPage;
            // subscribe the OnCategoryAddedEvent method
            // to the event
            CategoryChanged += goalsPage.OnCategoryAddedEvent;
        }
        // Overloaded constructor to deal with the paymentsPage instead
        public CategoryBox(PaymentsPage paymentsPage) 
        {
            InitializeComponent();
            this.paymentsPage = paymentsPage;
            // subscribe the OnCategoryAddedEvent method
            // to the event
            CategoryChanged += paymentsPage.OnCategoryAddedEvent;
        }
        // this event using the built in windows forms event system
        // it uses the default event handler (which doesn't pass information)
        private void confirmChangeBtn_Click(object sender, EventArgs e)
        {
            if (CategoryInp.Text == "" || !CategoryInp.Text.Any(char.IsLetter))
            {
                // error handling
                MessageBox.Show("You must enter something!");
            }
            else 
            {
                categoryName = CategoryInp.Text;
                // invokes the custom CategoryChanged event
                CategoryChanged?.Invoke(this, new CategoryChangedEventArgs(categoryName));
            }
            // then gets rid of the categoryBox instance
            this.Hide();
            this.Dispose();
        }
    }
}
