using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace _3342TermProjectJohnOmar
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["userEmail"] != null)
            {
                string useremail = Request.QueryString["userEmail"];
                btnEditProfile.Visible = false;
                DBConnect dBConnect = new DBConnect();
                SqlCommand getall = new SqlCommand("GetSingleProfile", dBConnect.openConc());
                getall.CommandType = CommandType.StoredProcedure;
                getall.Parameters.AddWithValue("@userEmail", useremail);
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = getall;
                DataSet singleuser = new DataSet();
                dataadapter.Fill(singleuser);
                dBConnect.CloseConnection();
                lblEmail.Text   = singleuser.Tables[0].Rows[0]["userEmail"].ToString();
                lblAge.Text = singleuser.Tables[0].Rows[0]["userAge"].ToString();
                lblKids.Text  = singleuser.Tables[0].Rows[0]["userKids"].ToString();
                lblPhoneNumber.Text = singleuser.Tables[0].Rows[0]["userPhoneNumber"].ToString();
                lblPreference.Text = singleuser.Tables[0].Rows[0]["userPreference"].ToString();
                lblSchool.Text = singleuser.Tables[0].Rows[0]["userSchool"].ToString();
                txtOldBio.Text = singleuser.Tables[0].Rows[0]["userBio"].ToString();
                ttlName.InnerText = singleuser.Tables[0].Rows[0]["userFirstName"].ToString() + singleuser.Tables[0].Rows[0]["userLastName"].ToString();



            }
            else
            {
                if(Session["userEmail"] != null)
                {
                    string useremail = Session["userEmail"].ToString();
                    DBConnect dBConnect = new DBConnect();
                    SqlCommand getall = new SqlCommand("GetSingleProfile", dBConnect.openConc());
                    getall.CommandType = CommandType.StoredProcedure;
                    getall.Parameters.AddWithValue("@userEmail", useremail);
                    SqlDataAdapter dataadapter = new SqlDataAdapter();
                    dataadapter.SelectCommand = getall;
                    DataSet singleuser = new DataSet();
                    dataadapter.Fill(singleuser);
                    dBConnect.CloseConnection();
                    lblEmail.Text = singleuser.Tables[0].Rows[0]["userEmail"].ToString();
                    lblAge.Text = singleuser.Tables[0].Rows[0]["userAge"].ToString();
                    lblKids.Text = singleuser.Tables[0].Rows[0]["userKids"].ToString();
                    lblPhoneNumber.Text = singleuser.Tables[0].Rows[0]["userPhoneNumber"].ToString();
                    lblPreference.Text = singleuser.Tables[0].Rows[0]["userPreference"].ToString();
                    lblSchool.Text = singleuser.Tables[0].Rows[0]["userSchool"].ToString();
                    txtOldBio.Text = singleuser.Tables[0].Rows[0]["userBio"].ToString();
                    ttlName.InnerText = singleuser.Tables[0].Rows[0]["userFirstName"].ToString() + singleuser.Tables[0].Rows[0]["userLastName"].ToString();
                }
                else
                {

                }



            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            editProfile.Visible = false;
            viewProfile.Visible = true;
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            viewProfile.Visible = false;
            editProfile.Visible = true;

            txtEmail.Text = lblEmail.Text;
            txtAge.Text = lblEmail.Text;
            txtKids.Text = lblEmail.Text;
            txtPhoneNumber.Text = lblEmail.Text;
            txtPreference.Text = lblEmail.Text;
            txtSchool.Text = lblEmail.Text;
            txtBio.Text = txtOldBio.Text;
        }
    }
}