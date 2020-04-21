using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Utilities
{
    public class Validate
    {

        private string UserEmail;
        private string UserPassword;

        // method to returen if the user and password are correct 
        public string checkUser(string userEmail, string userPassword)
        {
            this.UserEmail = userEmail;
            this.UserPassword = userPassword;
            SqlCommand userNameCommand = new SqlCommand();
            DBConnect dBConnect = new DBConnect();
            // check if the user entered a valid user name and password 
            // first we do sql proc. 

            userNameCommand.CommandType = CommandType.StoredProcedure;

            userNameCommand.CommandText = "checkPasswordAndUser";     // identify the name of the stored procedure to execute

            // take the user input and add it to @userPassword
            SqlParameter userParameter = new SqlParameter("@userPassword", UserPassword);
            userParameter.Direction = ParameterDirection.Input;

            userParameter.SqlDbType = SqlDbType.VarChar;

            // addidn user input to the proc.

            userNameCommand.Parameters.Add(userParameter);

            // take the user input and add it to @userName

            userParameter = new SqlParameter("@userEmail", UserEmail);

            userParameter.Direction = ParameterDirection.Input;

            userParameter.SqlDbType = SqlDbType.VarChar;

            // adding it to proc.

            userNameCommand.Parameters.Add(userParameter);

            // closing connection before excuting (just to make sure the connection is closed 
            dBConnect.CloseConnection();


            //  open connection to DB
            dBConnect.openConc();

            // userVal holed the value coming from the proc. if the return value is 1 then there is a user with correct password, if the value is 0, then user is not in the database.
            string userVal = dBConnect.ExecuteScalarFunction(userNameCommand).ToString();




            // closing connection before excuting (just to make sure the connection is closed 
            dBConnect.CloseConnection();

            return userVal;


        }

    }
}
