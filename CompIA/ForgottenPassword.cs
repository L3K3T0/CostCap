using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CompIA
{
    public partial class ForgottenPassword : Form
    {
        private string uniqueAns;
        private bool pwValid, confirmPwValid,unAns;
        public ForgottenPassword()
        {
            InitializeComponent();
        }
        private string PwCheck(string input)
        {
            // Define regular expressions for each category
            Regex symbolRegex = new Regex(@"[!@#$%^&*()_+{}\[\]:;<>,.?~\\/\-=|]");
            Regex numberRegex = new Regex(@"\d");
            Regex lowerCaseRegex = new Regex(@"[a-z]");
            Regex upperCaseRegex = new Regex(@"[A-Z]");

            // Check if the input string contains at least one character from each category
            bool containsSymbol = symbolRegex.IsMatch(input);
            bool containsNumber = numberRegex.IsMatch(input);
            bool containsLowerCase = lowerCaseRegex.IsMatch(input);
            bool containsUpperCase = upperCaseRegex.IsMatch(input);

            string pwOutput = "";
            if (containsSymbol && containsNumber && containsLowerCase && containsUpperCase && input.Length >= 8) { pwOutput = ""; }
            else
            {
                pwOutput += "The password doesn't contain at least: ";
                if (containsSymbol == false) { pwOutput += "\none ASCII symbol"; }
                if (containsNumber == false) { pwOutput += "\none number"; }
                if (containsLowerCase == false) { pwOutput += "\none lowercase ASCII character"; }
                if (containsUpperCase == false) { pwOutput += "\none uppercase ASCII character"; }
                if (input.Length < 8) { pwOutput += "\neight total characters"; }
            }
            return pwOutput;
        }

        private void un_input_TextChanged(object sender, EventArgs e)
        {
            if (PwCheck(password_conform_input.Text) != "")
            {
                un_check_label.Text = UnCheck();
            }
        }
        private string UnCheck()
        {
            if (un_input.Text == "")
            {
                return  "You MUST enter something into this field";
            }
            string query = $"SELECT * FROM ACCOUNTS WHERE Username = @username";
            List<SqlParameter> sqlparam = new List<SqlParameter>();
            sqlparam.Add(new SqlParameter("@username", DataBaseManager.Encrypt(un_input.Text) ));

            if (DataBaseManager.IsInDatabase(query,sqlparam) == false)
            {
                return "Username doesn't exist";
            }
            else 
            {
                string[] data = DataBaseManager.getUniqueData(DataBaseManager.Encrypt(un_input.Text));
                uniqueQu_label.Text = data[0];
                uniqueAns = data[1];
                return "Providing Unique Question";
            }
        }

        private void reset_password_input_TextChanged(object sender, EventArgs e)
        {
            string pwText = PwCheck(reset_password_input.Text);
            if ( pwText == "")
            {
                pwValid = true;
                pwStrength_label.Text = pwText;

            }
            else 
            {
                pwValid = false;
                pwStrength_label.Text = pwText; 
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Answer_input.Text != uniqueAns)
            {
                ans_label.Text = "Wrong Answer"; unAns = false;
            }
            else { ans_label.Text = "Correct"; unAns = true; }
        }

        private void password_conform_input_TextChanged(object sender, EventArgs e)
        {
            if (password_conform_input.Text == reset_password_input.Text)
            {
                pw_confrim_label.Text = "Passwords Match!";
                confirmPwValid = true;
            }
            else { confirmPwValid = false; pw_confrim_label.Text = "Password Don't Match!"; }
        }

        private void reset_password_button_Click(object sender, EventArgs e)
        {
            if (confirmPwValid == true && pwValid == true && unAns == true)
            {
                DataBaseManager.UpdatePassword(un_input.Text, reset_password_input.Text);
                this.Close();
                PageManager.MainFormRemove<ForgottenPassword>(this);
                PageManager.LoadMainForm<Login>(new Login());
            }
        }
    }
}
