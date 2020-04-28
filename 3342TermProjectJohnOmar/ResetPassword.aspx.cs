using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace _3342TermProjectJohnOmar
{
    public partial class ResetPasswod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            string s = txtUeserEmail.Text;



            Session["userEmail"] = s;
            if (s == "")
            {

                lblErrorMessage.Text = "Please fill All required fields!";
            }
            else
            {

                // validate if user email already exist
                Validate v = new Validate();
                // return 0 if there is no email in the DB
                string valueReturned = v.checkUser(s);


                //  if the value is 0, then user is not in the database 
                if (valueReturned == "0")
                {
                    lblErrorMessage.Text = "ERROR : Email doesn't exist";



                }

                // user enter existing email 
                else
                {
                    DBConnect con = new DBConnect();
                    SqlCommand sqlCMD = new SqlCommand();
                    sqlCMD.CommandType = CommandType.StoredProcedure;

                    sqlCMD.CommandText = "getQuestions";     // identify the name of the stored procedure to execute

                    // take the user input and add it to @userPassword
                    SqlParameter userParameter = new SqlParameter("@userEmail", s);
                    userParameter.Direction = ParameterDirection.Input;

                    userParameter.SqlDbType = SqlDbType.VarChar;

                    // addidn user input to the proc.

                    sqlCMD.Parameters.Add(userParameter);
                    con.CloseConnection();

                    con.openConc();

                    string userVal = con.ExecuteScalarFunction(sqlCMD).ToString();
                    txtUserAnswer.Visible = true;
                    btnSubmit.Visible = true;
                    btnSubmit.Visible = true;
                    lblQuestion.Visible = true;
                    lblQuestion.Text = userVal;


                    txtUeserEmail.Visible = false;
                    btnReset.Visible = false;




                }

            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string userAnswer = txtUserAnswer.Text;

            DBConnect con = new DBConnect();
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = CommandType.StoredProcedure;

            string s = Session["userEmail"].ToString();

            sqlCMD.CommandText = "getAnswers";     // identify the name of the stored procedure to execute

            // take the user input and add it to @userPassword
            SqlParameter userParameter = new SqlParameter("@userEmail", s);
            userParameter.Direction = ParameterDirection.Input;

            userParameter.SqlDbType = SqlDbType.VarChar;

            // addidn user input to the proc.

            sqlCMD.Parameters.Add(userParameter);
            con.CloseConnection();

            con.openConc();

            string userVal = con.ExecuteScalarFunction(sqlCMD).ToString();

            if (userAnswer == userVal)
            {
                lblErrorMessage.Text = "";
                lblQuestion.Text = "please type your new password...";
                btnSubmit.Visible = false;
                btnRPassword.Visible = true;
                txtUserAnswer.Text = "";
            }
            else
            {
                lblErrorMessage.Text = "Wrong answer!";
            }

        }

        protected void btnRPassword_Click(object sender, EventArgs e)
        {
            string userNewPassword = txtUserAnswer.Text;
            if (userNewPassword != "")
            {

                //  DBConnect con = new DBConnect();
                SqlCommand sqlCMD = new SqlCommand();
                sqlCMD.CommandType = CommandType.StoredProcedure;
                string s = Session["userEmail"].ToString();


                DBConnect con = new DBConnect();
                SqlCommand sqlCmd = new SqlCommand("UpdatePassword", con.openConc());
                sqlCmd.CommandType = CommandType.StoredProcedure;
                // passing the values to the table     
                sqlCmd.Parameters.AddWithValue("@userPassword", userNewPassword);
                sqlCmd.Parameters.AddWithValue("@userEmail", s);

                // Executing the command
                sqlCmd.ExecuteNonQuery();
                // closing connection
                con.CloseConnection();
                Response.Redirect("LogIn.aspx");
            }

        }
    }
}