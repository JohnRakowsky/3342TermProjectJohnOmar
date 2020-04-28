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
            if (Request.QueryString["userEmail"] != null)
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
                lblEmail.Text = singleuser.Tables[0].Rows[0]["userEmail"].ToString();
                lblAge.Text = singleuser.Tables[0].Rows[0]["userAge"].ToString();
                lblKids.Text = singleuser.Tables[0].Rows[0]["userKids"].ToString();
                lblPhoneNumber.Text = singleuser.Tables[0].Rows[0]["userPhone"].ToString();
                lblPreference.Text = singleuser.Tables[0].Rows[0]["userPreference"].ToString();
                lblSchool.Text = singleuser.Tables[0].Rows[0]["userSchool"].ToString();
                txtOldBio.Text = singleuser.Tables[0].Rows[0]["userBio"].ToString();
                ttlName.InnerText = singleuser.Tables[0].Rows[0]["userFirstName"].ToString() + " " + singleuser.Tables[0].Rows[0]["userLastName"].ToString();
                imgOldProfilePic.ImageUrl = singleuser.Tables[0].Rows[0]["userProfilePic"].ToString();



            }
            else if (Session["userEmail"] != null)
            {
                string useremail = Session["userEmail"].ToString();
                btnLike.Visible = false;
                btnPass.Visible = false;
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
                lblPhoneNumber.Text = singleuser.Tables[0].Rows[0]["userPhone"].ToString();
                lblPreference.Text = singleuser.Tables[0].Rows[0]["userPreference"].ToString();
                lblSchool.Text = singleuser.Tables[0].Rows[0]["userSchool"].ToString();
                txtOldBio.Text = singleuser.Tables[0].Rows[0]["userBio"].ToString();
                ttlName.InnerText = singleuser.Tables[0].Rows[0]["userFirstName"].ToString() + " " + singleuser.Tables[0].Rows[0]["userLastName"].ToString();




            }
            else
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            SqlCommand update = new SqlCommand("UpdateProfile", dBConnect.openConc());
            update.CommandType = CommandType.StoredProcedure;
            update.Parameters.AddWithValue("@userEmail", txtEmail.Text);
            update.Parameters.AddWithValue("@userAge", txtAge.Text);
            update.Parameters.AddWithValue("@userPhoneNumber", txtPhoneNumber.Text);
            update.Parameters.AddWithValue("@userPreference", txtPreference.Text);
            update.Parameters.AddWithValue("@userSchool", txtSchool.Text);
            update.Parameters.AddWithValue("@userBio", txtBio.Text);
            update.Parameters.AddWithValue("@userProfilePic", txtProfilePic.Text);
            update.ExecuteNonQuery();
            dBConnect.CloseConnection();



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
            txtAge.Text = lblAge.Text;
            txtKids.Text = lblKids.Text;
            txtPhoneNumber.Text = lblPhoneNumber.Text;
            txtPreference.Text = lblPreference.Text;
            txtSchool.Text = lblSchool.Text;
            txtBio.Text = txtOldBio.Text;
            imgNewProfilePic.ImageUrl = imgOldProfilePic.ImageUrl.ToString();
        }

        protected void btnPass_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["userEmail"] != null)
            {
                //  lblPhoneNumber.Text= Request.QueryString["userEmail"];
                Liked pass = new Liked();
                string userEmail = Session["userEmail"].ToString();
                pass.LikedEmail = Request.QueryString["userEmail"];
                pass.UserEmail = userEmail;

                Serialization serialize = new Serialization();

                string returnedValue = serialize.doSerializePass(pass, userEmail);

                lblPhoneNumber.Text = returnedValue;


            }

        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            Liked liked = new Liked();
            if (Request.QueryString["userEmail"] != null)
            {
                //  lblPhoneNumber.Text= Request.QueryString["userEmail"];

                string userEmail = Session["userEmail"].ToString();

                string likedEmail = Request.QueryString["userEmail"];

                liked.LikedEmail = likedEmail;
                liked.UserEmail = userEmail;

                Serialization serialize = new Serialization();

                string returnedValue = serialize.doSerialize(liked, userEmail);

                lblPhoneNumber.Text = returnedValue;


            }
        }
    }
}