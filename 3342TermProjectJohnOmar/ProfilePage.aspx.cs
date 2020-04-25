using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3342TermProjectJohnOmar
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
        }
    }
}