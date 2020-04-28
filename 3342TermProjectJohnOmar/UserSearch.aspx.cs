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
    public partial class UserSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] != null)
            {
                navbarAccount.Visible = true;
                navbarLogIn.Visible = false;
            }
            else
            {
                navbarAccount.Visible = false;
                navbarLogIn.Visible = true;
            }
            DBConnect dBConnect = new DBConnect();
            SqlCommand getall = new SqlCommand("GetAllProfiles", dBConnect.openConc());
            getall.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataadapter = new SqlDataAdapter();
            dataadapter.SelectCommand = getall;
            DataSet allusers = new DataSet();
            dataadapter.Fill(allusers);
            gvResults.DataSource = allusers;
            gvResults.DataBind();
            dBConnect.CloseConnection();


        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            GridViewRow classRow = (GridViewRow)btn.NamingContainer;

            Label lbl = (Label)classRow.FindControl("lblEmail");

            string email = lbl.Text;
            string link = "ProfilePage.aspx";
            var uriBuilder = new UriBuilder(link);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["userEmail"] = email;
            uriBuilder.Query = query.ToString();
            link = uriBuilder.ToString();

            Response.Redirect("ProfilePage.aspx?userEmail=" + email);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (ddlSearchOptions.SelectedValue == "Search By Name")
            {
                string search = txtSearch.Text;
                string[] array = search.Split(null);
                string firstname = array[0];
                string lastname;
                if (array.Length > 1)
                {
                    lastname = array[1];
                }
                else
                {
                    lastname = "";
                }
                DBConnect dBConnect = new DBConnect();
                SqlCommand getall = new SqlCommand("SearchByName", dBConnect.openConc());
                getall.CommandType = CommandType.StoredProcedure;
                getall.Parameters.AddWithValue("@FirstName", firstname);
                getall.Parameters.AddWithValue("@LastName", lastname);
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = getall;
                DataSet allusers = new DataSet();
                dataadapter.Fill(allusers);
                gvResults.DataSource = allusers;
                gvResults.DataBind();
                dBConnect.CloseConnection();
            }
            else if (ddlSearchOptions.SelectedValue == "Search By Preference")
            {
                string search = txtSearch.Text;
                DBConnect dBConnect = new DBConnect();
                SqlCommand getall = new SqlCommand("SearchByPreference", dBConnect.openConc());
                getall.CommandType = CommandType.StoredProcedure;
                getall.Parameters.AddWithValue("@Search", search);
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = getall;
                DataSet allusers = new DataSet();
                dataadapter.Fill(allusers);
                gvResults.DataSource = allusers;
                gvResults.DataBind();
                dBConnect.CloseConnection();
            }
            else if (ddlSearchOptions.SelectedValue == "Search By State")
            {
                string search = txtSearch.Text;
                DBConnect dBConnect = new DBConnect();
                SqlCommand getall = new SqlCommand("SearchByState", dBConnect.openConc());
                getall.CommandType = CommandType.StoredProcedure;
                getall.Parameters.AddWithValue("@Search", search);
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = getall;
                DataSet allusers = new DataSet();
                dataadapter.Fill(allusers);
                gvResults.DataSource = allusers;
                gvResults.DataBind();
                dBConnect.CloseConnection();
            }
            else if (ddlSearchOptions.SelectedValue == "Search By City")
            {
                string search = txtSearch.Text;
                DBConnect dBConnect = new DBConnect();
                SqlCommand getall = new SqlCommand("SearchByCity", dBConnect.openConc());
                getall.CommandType = CommandType.StoredProcedure;
                getall.Parameters.AddWithValue("@Search", search);
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = getall;
                DataSet allusers = new DataSet();
                dataadapter.Fill(allusers);
                gvResults.DataSource = allusers;
                gvResults.DataBind();
                dBConnect.CloseConnection();
            }
            else
            {
                string search = ddlGender.SelectedValue;
                DBConnect dBConnect = new DBConnect();
                SqlCommand getall = new SqlCommand("SearchByGender", dBConnect.openConc());
                getall.CommandType = CommandType.StoredProcedure;
                getall.Parameters.AddWithValue("@Search", search);
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = getall;
                DataSet allusers = new DataSet();
                dataadapter.Fill(allusers);
                gvResults.DataSource = allusers;
                gvResults.DataBind();
                dBConnect.CloseConnection();
            }
        }

        protected void ddlSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlSearchOptions.SelectedValue == "Search By Gender")
            {
                txtSearch.Visible = false;
                ddlGender.Visible = true;
            
            }
            else
            {
                txtSearch.Visible = true;
                ddlGender.Visible = false;

            }
        }
    }
}