using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Utilities;
using System.Collections;
using System.Data.SqlClient;

namespace _3342TermProjectJohnOmar
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            SqlCommand userNameCommand = new SqlCommand();
            // check if there is a cookie stored in the user browser 
            if (Request.Cookies["authenticationCookie"] != null)
            {
                // set UserEmail to user email from the cookie 
                txtUserEmail.Text = Request.Cookies["authenticationCookie"]["userEmail"];
                // we have to use the attribute value because txtPass is used in password textmode. 
                txtPass.Attributes["value"] = Request.Cookies["authenticationCookie"]["userPassword"];

            }

            // if there is no user found display error
            lblError.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            Validate v = new Validate();

            string valueReturned = v.checkUser(txtUserEmail.Text, txtPass.Text);


            //  if the value is 0, then user is not in the database or didn't enter valid user name and password.
            if (valueReturned == "0")
            {
                lblError.Visible = true;

            }


            else
            {

                // check if the user clicked remember me check box. if yes store useremail and password in a cookie
                if (cbRemember.Checked)
                {
                    Response.Cookies["authenticationCookie"]["userEmail"] = txtUserEmail.Text;
                    Response.Cookies["authenticationCookie"]["userPassword"] = txtPass.Text;
                }


                // redirect to profile page. 
                Response.Redirect("ProfilePage.aspx");
            }
        }
            protected void btnRegisterNew_Click(object sender, EventArgs e)
            {

            Response.Redirect("Registration.aspx");
            }



            }
        }
    
