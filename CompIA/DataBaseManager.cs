using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CompIA
{
    // Account Properties should only be encrypted when writing directly to the DB
    // Unless the function is directly accessing the database or writing to the DB it should all be in Plain text.
    // Unless otherwise stated.
    // the database is not COMMITTING changes and is always rollbacking to the earlier database!
    // The Account used to test has details: JustinSane;	Chicken;	Who's the goat;	Ronaldo
    public static class DataBaseManager
    {
        // connectiion
        private readonly static string connectionString;
        public static string ConnectionString => connectionString; // auto getter 
        static DataBaseManager()
        {
            // you have to add the configuration manager refernce in the project folder!
            connectionString = ConfigurationManager.ConnectionStrings["CompIA.Properties.Settings.CostCapDBConnectionString"].ConnectionString;
        }
        public struct UserDetails
        {
            public int ID;
            public string username, password, uniqueQuestion, uniqueAnswer;
            public UserDetails(int ID, string username,string password, string uniqueQuestion, string uniqueAnswer)
            {
                this.ID = ID;
                this.username = username;
                this.password = password;
                this.uniqueQuestion = uniqueQuestion;
                this.uniqueAnswer = uniqueAnswer;
            }
        }
        #region Authentication
        public static bool IsInDatabase(string query,List<SqlParameter> sqlparams)
        {
            bool found = false;
            // the 'using' keyword here in a statement like this ensures that the variables are closed/disposed off after
            // this prevents me having to manually close the conneciton using connection.close()
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query,connection))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddRange(sqlparams.ToArray());   
                DataTable dataTable = new DataTable();
                dataAdapter?.Fill(dataTable); // fills the datatable with any matching info from the query
                // the datatable is populated with data rows which you can access data from
                if (dataTable.Rows.Count > 0) // if there are any lines with matching details then this datatable will have values
                { // hence the account has been found!
                    found = true;
                }
                connection.Close();
            }
            return found;
        }
        public static bool Authenticate(string username, string password)
        {
            // encrypts the inputted user details so they can be stored in the database
            username = Encrypt(username);
            password = Encrypt(password);
            if (username == "" || password == "") { return false ; }
            string query = @"SELECT * FROM ACCOUNTS WHERE Username = @username AND Password = @password";
            List<SqlParameter> sqlparam = new List<SqlParameter>
            {
                // instead of using $ concatenation using parameters helps avoid sql injection as well as strings 
                // behaving not as expected as we are dealing with symbols in encryption
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            return IsInDatabase(query,sqlparam);
        }
        public static void CreateAcc(string username, string password, string UniqueQuestion, string UniqueAns)
        {
            if (username == "" || password == "" || UniqueQuestion == "" || UniqueAns == "")
            {
                return; //escape clause
            }
            string query = $"INSERT INTO Accounts VALUES(@username,@password,@uniqueQuestion,@uniqueAns);";
            List<SqlParameter> sqlparam = new List<SqlParameter>
            {
                new SqlParameter("@username", Encrypt(username)),
                new SqlParameter("@password", Encrypt(password)),
                new SqlParameter("@uniqueQuestion", Encrypt(UniqueQuestion)),
                new SqlParameter("@uniqueAns", Encrypt(UniqueAns))
            };
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddRange(sqlparam.ToArray());
                command.ExecuteScalar(); // executes the query returns the number of rows affected.
               
            }
        }
   public static string[] getUniqueData(string username)
        {
            string[] uniqueData = new string[2];
            string query = "SELECT Accounts.UniqueQuestion , Accounts.UniqueAnswer FROM Accounts where Username = @username";
            SqlParameter sqlParam = new SqlParameter("@username", username);
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand (query,connection))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.Add(sqlParam);
                DataTable dataTable = new DataTable();
                dataAdapter?.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        uniqueData[0] = Decrypt(row["UniqueQuestion"].ToString());
                        uniqueData[1] = Decrypt(row["UniqueAnswer"].ToString()); 
                    }
                }
            }
            return uniqueData;
        }

        public static void UpdatePassword(string username, string password)
        {
            // called when the user updates clicks the reset password button on the Fp page
            string query = @"UPDATE ACCOUNTS SET Password = @password WHERE Username = @username";
            List<SqlParameter> sqlparam = new List<SqlParameter>
            {
                new SqlParameter("@password", Encrypt(password)),
                new SqlParameter("@username", Encrypt(username))
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand (query,connection))
            {
                connection.Open();
                command.Parameters.AddRange(sqlparam.ToArray());
                command.ExecuteScalar();
            }
        }
        // Overloaded Functions here
        public static UserDetails GetAccDetails(int ID)
        {
            string username = "", password = "";
            string uniqueQuestion = "", uniqueAnswer = "";
            
            UserDetails userDetails = new UserDetails();
            string query = "SELECT * FROM Accounts WHERE  Accounts.ID = @ID;";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.Parameters.Add(new SqlParameter("@ID", ID));
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable); // fills the datatable with any matching info from the query
                // the datatable is populated with data rows which you can access data from
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        username = Decrypt(row["Username"].ToString());
                        password = Decrypt(row["Password"].ToString());
                        uniqueQuestion = Decrypt(row["UniqueQuestion"].ToString());
                        uniqueAnswer = Decrypt(row["UniqueAnswer"].ToString());
                        userDetails = new UserDetails(ID, username, password, uniqueQuestion, uniqueAnswer);
                    }
                    userDetails = new UserDetails(ID, username, password, uniqueQuestion, uniqueAnswer);
                }
            }
            return userDetails;
        }
        public static UserDetails GetAccDetails(string username, string password) // These values should be plaintText
        {
            int ID = -1;
            string uniqueQuestion = "";
            string uniqueAnswer = "";
            UserDetails userDetails = new UserDetails();

            string querry = "SELECT * FROM Accounts WHERE  Username = @username AND Password = @password;";
            List<SqlParameter> sqlparam = new List<SqlParameter>
            {
                new SqlParameter("@username", Encrypt(username)),
                new SqlParameter("@password", Encrypt(password))
            };
            // The using statement opens and closes the connection (IDisposible) increasing safety
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querry,connection))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddRange(sqlparam.ToArray());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable); // fills the datatable with any matching info from the query
                // the datatable is populated with data rows which you can access data from
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ID = Int32.Parse(row["Id"].ToString());
                         uniqueQuestion = Decrypt(row["UniqueQuestion"].ToString());
                         uniqueAnswer = Decrypt(row["UniqueAnswer"].ToString());
                        userDetails = new UserDetails(ID,username,password,uniqueQuestion,uniqueAnswer);
                    }
                    userDetails = new UserDetails(ID, username, password, uniqueQuestion, uniqueAnswer);
                }
            }
            return userDetails;
        }
        // encrypts the a string using ROT 47 (only use for account details)
        public static string Encrypt(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char character in input)
            {
                if (character >= 33 && character <= 126)
                {
                    // Calculate the ROT47 transformation
                    char rotatedChar = (char)(((character - 33 + 47) % 94) + 33);
                    result.Append(rotatedChar);
                }
                else
                {
                    // Characters outside the printable ASCII range are left unchanged
                    result.Append(character);
                }
            }

            return @result.ToString();
        }
        static string Decrypt(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char character in input)
            {
                if (character >= 33 && character <= 126)
                {
                    // Calculate the reverse ROT47 transformation
                    char reversedChar = (char)(((character - 33 - 47 + 94) % 94) + 33);
                    result.Append(reversedChar);
                }
                else
                {
                    // Characters outside the printable ASCII range are left unchanged
                    result.Append(character);
                }
            }

            return result.ToString();
        }
        #endregion
        // Contains overloading
        #region Misc Methods
        // call this function when dealing w/ money
        // totals the value of the decimals inside the row
        public static decimal ReturnTotal(DataTable dt, string totalRow)
        {
            decimal total = 0.00m;
            foreach (DataRow row in dt.Rows)
            {
                total += Decimal.Parse(row.Field<String>(totalRow));
            }
            return total;
        }
        // this returns the number of rows that fufill a requirement.
        // Comparison row has a BOOLEAN value
        // e.g total the number of completed goal the  user has.
        public static decimal ReturnTotal(DataTable dt, string comparisonRow, bool condition, string totalRow)
        {
            decimal total = 0.00m;
            foreach (DataRow row in dt.Rows)
            {
                if (row.Field<Boolean>(comparisonRow) == condition)
                {
                    total += row.Field<Decimal>(totalRow);
                }
            }
            return Decimal.Round(total,2);
        }
        #endregion
        #region Payments and goals
        public static DataTable GetGoalsData(int ID)
        {
            // Read in the accounts Goals data as a LL then
            // For each node in that LL pass in as many SQL queries as needed
            // Then send that data into the main home page as a DataTable
            // something is wrong with the value of the ID
            string query = "select * from Goals where AccountID = @ID order by Goals.Priority asc;";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(query,connection))
            using(SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ID", ID);
                adapter?.Fill(dataTable); 
            }
            return dataTable;
        }
        public static DataTable GetPaymentsData(int ID)
        {
            {
                string query = "select * from Payments where AccountID = @ID order by PaymentAmount desc;";
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    adapter?.Fill(dataTable);
                }
                return dataTable;
            }
        }
        // We are using Foreign Keys so the order we delete is important
        // Delete the mapping table e.g CategoryGoals field First
        // Then delete the actual goal itself!
        public static void RemoveGoal(int GoalID)
        {
            string categoryGoalsQuery = "Delete From CategoryGoals where GoalID = @GoalID;";
            string GoalsQuery = "Delete From Goals where Goals.Id = @GoalID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(categoryGoalsQuery,connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@GoalID",GoalID);
                command.ExecuteScalar();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(GoalsQuery, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@GoalID", GoalID);
                command.ExecuteScalar();
            }
        }
        public static void RemovePayment(int PaymentID)
        {
            string categoryGoalsQuery = "Delete From PaymentCategory where PaymentID = @PaymentID;";
            string GoalsQuery = "Delete From Payments where Payments.Id = @PaymentID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(categoryGoalsQuery, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
                command.ExecuteScalar();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(GoalsQuery, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
                command.ExecuteScalar();
            }
        }
        public static DataTable GetCategoryNames(int ID)
        { 
            DataTable dataTable = new DataTable();
            string query = "Select * From Category Where AccountID = @ID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ID", ID);
                adapter?.Fill(dataTable);
            }
            return dataTable;
        }
        public static DataTable GetCategoryPNames(int ID)
        {
            DataTable dataTable = new DataTable();
            string query = "Select * From CategoryP Where AccountID = @ID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ID", ID);
                adapter?.Fill(dataTable);
            }
            return dataTable;
        }
        #endregion
    }
}
