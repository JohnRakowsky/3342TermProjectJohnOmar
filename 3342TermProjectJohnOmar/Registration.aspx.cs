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
    public partial class Registration : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Clear();
                // SQL statement to select all values from the states table 
                String strSQL = "SELECT * FROM TP_States";
                // data source 
                ddlStates.DataSource = objDB.GetDataSet(strSQL);
                // set the text displayed in the list to the State field value
                ddlStates.DataTextField = "State";
                //  the value of a selected item is the P.A.field value
                ddlStates.DataValueField = "PostalAbbreviations";
                // Bind the dataset data to the drop-down list
                ddlStates.DataBind();



                // SQL statement to select all values from the states table 
                String strSQL2 = "SELECT * FROM TP_Questions";
                // data source 
                ddlQuestion1.DataSource = objDB.GetDataSet(strSQL2);
                // set the text displayed in the list to the State field value
                ddlQuestion1.DataTextField = "Question";
                //  the value of a selected item is the P.A.field value
                ddlQuestion1.DataValueField = "Question";
                // Bind the dataset data to the drop-down list
                ddlQuestion1.DataBind();

                // data bind for Q 2
                ddlQuestion2.DataSource = objDB.GetDataSet(strSQL2);
                // set the text displayed in the list to the State field value
                ddlQuestion2.DataTextField = "Question";
                //  the value of a selected item is the P.A.field value
                ddlQuestion2.DataValueField = "Question";
                // Bind the dataset data to the drop-down list
                ddlQuestion2.DataBind();

                //data bind for Q3
                ddlQuestion3.DataSource = objDB.GetDataSet(strSQL2);
                // set the text displayed in the list to the State field value
                ddlQuestion3.DataTextField = "Question";
                //  the value of a selected item is the P.A.field value
                ddlQuestion3.DataValueField = "Question";
                // Bind the dataset data to the drop-down list
                ddlQuestion3.DataBind();

            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtFirstName.Text == ""
                || txtLastName.Text == "" || txtPassword.Text == "" || txtAnswer1.Text == ""
                || txtAnswer2.Text == "" || txtAnswer3.Text == "")
            {
                lblErrorMessage.Text = "Please fill All required fields!";
            }
            else
            {

                // validate if user email already exist
                Validate v = new Validate();
                // return 0 if there is no email in the DB
                string valueReturned = v.checkUser(txtEmail.Text);


                //  if the value is 0, then user is not in the database 
                if (valueReturned == "0")
                {


                    DBConnect con = new DBConnect();
                    SqlCommand sqlCmd = new SqlCommand("AddUser", con.openConc());
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    // passing the values to the table     
                    sqlCmd.Parameters.AddWithValue("@userEmail", txtEmail.Text);
                    sqlCmd.Parameters.AddWithValue("@userFirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userLastName", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userPassword", txtPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userAge", txtAge.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userQuestion1", ddlQuestion1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userAnswer1", txtAnswer1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userQuestion2", ddlQuestion2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userAnswer2", txtAnswer2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userQuestion3", ddlQuestion3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userAnswer3", txtAnswer3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userStreetAddress", txtStreetAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userZipCode", txtZip.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userCity", txtCity.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userState", ddlStates.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userGender", ddlGender.SelectedValue);
                    sqlCmd.Parameters.AddWithValue("@userPreference", txtPreference.Text.Trim());
                    // Executing the command
                    sqlCmd.ExecuteNonQuery();
                    // closing connection
                    con.CloseConnection();
                    //Add new row to profile table
                    SqlCommand newprofile = new SqlCommand("AddProfile", con.openConc());
                    newprofile.CommandType = CommandType.StoredProcedure;
                    newprofile.Parameters.AddWithValue("@userEmail", txtEmail.Text);
                    newprofile.ExecuteNonQuery();

                    con.CloseConnection();


                    // label to inform user is added to DB
                    lblSuccessMessage.Text = "Profile Created!";
                    Response.Redirect("LogIn.aspx");


                }

                // user enter existing email 
                else
                {

                    lblErrorMessage.Text = "ERROR : Email exist";
                }

            }
        }
        void Clear()
        {
            txtEmail.Text = txtFirstName.Text =
                txtLastName.Text = txtAge.Text =
                txtAnswer1.Text = txtAnswer2.Text =
                txtAnswer3.Text = txtCity.Text =
                txtPassword.Text = txtStreetAddress.Text
                = txtZip.Text = "";
            lblSuccessMessage.Text = lblSuccessMessage.Text = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }
    }
}