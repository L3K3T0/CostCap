using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace CompIA
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // insert statement to the DB
            // check if the text fields are valid
            if (IsValid())
            {
                DataBaseManager.CreateAcc(un_input.Text,pw_input.Text,unQuestion_input.Text,unAnswer_input.Text);
                PageManager.LoadMainForm<Login>(new Login());
                this.Close();
                PageManager.MainFormRemove<SignUp>(this);
                //PageManager.CloseApp();
            }
        }
        private bool IsValid() 
        {
            bool valid = true;
            string unCheck = UnCheck(), pwCheck = PwCheck(pw_input.Text);
            un_error_label.ForeColor = Color.Red;
            un_error_label.Text = unCheck;
            pw_error_label.ForeColor = Color.Red;
            pw_error_label.Text = pwCheck;
            if (unCheck != "")
            {
                valid = false;
                // warning label becomes text.
            }
            if (pwCheck != "")
            {
                valid = false;    
            }
            if (UniqueCheck() != "")
            {
                valid = false;
            }
            return valid;
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
                return "";
            }
            else 
            {
                return "Username is Already taken!";
            }
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

            string pwOutput= "";
            if (containsSymbol && containsNumber && containsLowerCase && containsUpperCase && input.Length >= 8) { pwOutput = ""; }
            else 
            {
                pwOutput += "The password doesn't contain at least: ";
                if (containsSymbol == false) { pwOutput += "\none ASCII symbol"; }
                if (containsNumber == false) { pwOutput += "\none number"; }
                if (containsLowerCase == false) { pwOutput += "\none lowercase ASCII character"; }
                if (containsUpperCase == false) { pwOutput += "\none uppercase ASCII character";  }
                if (input.Length < 8) { pwOutput += "\neight total characters"; }
            }
            return pwOutput;
        }
        private string UniqueCheck()
        {
            if (unQuestion_input.Text != "" && unAnswer_input.Text != "")
            {
                return "";
            }
            else { return "You have to write something in both the Unique Question and Answer Boxes!"; }
        }
    }
}
