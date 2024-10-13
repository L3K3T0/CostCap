using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CompIA
{
    // keep in mind the onform close events/ methods!
    // when you use form.close you can recall that form using the .show method
    // when you use form.dispose you CANNOT do that! Dispose also doesn't call the.close or closing methods but frees up memory
    // use it for things you don't need again such as the editting pages for goals/payments
    // use close for all the main pages to avoid multiple instances!
    public partial class Login : Form
    {
        public static bool un_defaultTextClear = true;
        public static bool pw_defaultTextClear = true;
        public Login()
        {
            InitializeComponent();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void login_button_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            string username = un_input.Text;
            string password = pw_input.Text;
            if (DataBaseManager.Authenticate(username,password))
            {
                this.Hide();
                PageManager.LoadMainForm<HomePage>(new HomePage(new User(username,password)));
                PageManager.MainFormRemove<Login>(this);
            }
            else 
            {
                errorMsgLab.Text = "Account details not recognised";
                pw_defaultTextClear = true;
                un_defaultTextClear = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            PageManager.LoadMainForm(new SignUp());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            PageManager.LoadMainForm(new ForgottenPassword());
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            PageManager.CloseApp();
        }
    }
}
