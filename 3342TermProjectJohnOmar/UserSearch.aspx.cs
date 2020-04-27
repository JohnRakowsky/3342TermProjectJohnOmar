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
            


        }
    }
}