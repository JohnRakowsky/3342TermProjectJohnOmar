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
using System.Text;
using System.IO;                        // needed for the MemoryStream



namespace _3342TermProjectJohnOmar
{
    public partial class LogIn : System.Web.UI.Page
    {

        RSA enc = new RSA();


        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            DBConnect dBConnect = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            SqlCommand userNameCommand = new SqlCommand();





            // check if there is a cookie stored in the user browser 
            if (!IsPostBack && Request.Cookies["authenticationCookie"] != null)
            {
                // set UserEmail to user email from the cookie 
                txtUserEmail.Text = Request.Cookies["authenticationCookie"]["userEmail"];


                HttpCookie useCookie = Request.Cookies["authenticationCookie"];
                string encPassword = useCookie.Values["userPassword"];
                // this should decrypt if you have the private key 
                //
                // var plainText = enc.Decrypt1(encPassword);

                // should return the decrypted password
                // txtPass.Text = plainText;

                string passCookie = enc.PasswordDecryption(encPassword);

                txtPass.Attributes["value"] = passCookie;



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


                    string password = txtPass.Text;

                    // encrypting the password with RSA 
                    // then saving it to the cookie 
                    // string cypheredPass = enc.Encrypt1(password);
                    //
                    // enc.PasswordEncryption is using RijndaelManaged encryption 
                    string pass = enc.PasswordEncryption(password);
                    Response.Cookies["authenticationCookie"]["userEmail"] = txtUserEmail.Text;

                    //CypherPass is used when you want to use RSA encryption
                    Response.Cookies["authenticationCookie"]["userPassword"] = pass;//cypheredPass;
                }



                string email = txtUserEmail.Text;
                // redirect to profile page. 

                Session["userEmail"] = email;

                Response.Redirect("ProfilePage.aspx?userEmail=" + email);

            }
        }
        protected void btnRegisterNew_Click(object sender, EventArgs e)
        {

            Response.Redirect("Registration.aspx");
        }
    }




}


