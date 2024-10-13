using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompIA
{
    public class User
    {
        #region Authentication attributes
        #region Fields
        readonly int accountID;
        string username;
        string password;
        string uniqueQuestion;
        string uniqueAnswer;
        #endregion
        #region Properties
        public int AccountID { get => accountID; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string UniqueQuestion { get => uniqueQuestion; set => uniqueQuestion = value; }
        public string UniqueAnswer { get => uniqueAnswer; set => uniqueAnswer = value; }
        #endregion
        #endregion
        // Expects PlainText Usernames!
        // Overloading right here!
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            // retrieve account ID from sql query
            // overloaded method
            DataBaseManager.UserDetails userDetails = DataBaseManager.GetAccDetails(username,password);
            accountID = userDetails.ID;
            uniqueQuestion = userDetails.uniqueQuestion;
            uniqueAnswer = userDetails.uniqueAnswer;
        }
        public User(int id) 
        {
            this.accountID = id;
            // Retrieve account Data from sql query
            // overloaded method with just the account ID
            DataBaseManager.UserDetails userDetails = DataBaseManager.GetAccDetails(AccountID);
            uniqueQuestion = userDetails.uniqueQuestion;
            uniqueAnswer = userDetails.uniqueAnswer;
            Username = userDetails.username;
            Password = userDetails.password;
        }
        }
    }
