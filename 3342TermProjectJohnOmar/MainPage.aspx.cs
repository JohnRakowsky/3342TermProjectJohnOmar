using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Data.SqlClient;                                //needed for the Sql data provider

using System.Runtime.Serialization.Formatters.Binary;       //needed for BinaryFormatter

using System.IO;                                            //needed for the MemoryStream



namespace _3342TermProjectJohnOmar
{
    public partial class MainPage : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        DBConnect objDB2 = new DBConnect();

        ArrayList myLikedList = new ArrayList();
        ArrayList myPassList = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userEmail"] != null)
                {
                    navbarAccount.Visible = true;
                    navbarLogIn.Visible = false;
                }
                else
                {
                    navbarAccount.Visible = false;
                    navbarLogIn.Visible = true;
                }

                ShowUseres();
            }




        }

        public void ShowUseres()
        {

            string email = Session["userEmail"].ToString();
            String strSQL = "SELECT TP_userLikedCollection.userLiked, TP_userLikedCollection.userEmail FROM TP_userLikedCollection INNER JOIN TP_Users ON TP_userLikedCollection.userEmail = TP_Users.userEmail";



            String strSQL1 = "SELECT userLiked FROM TP_userLikedCollection WHERE userEmail ='" + email + "'";
            String strSQL2 = "SELECT userPass FROM TP_userPassCollection WHERE userEmail ='" + email + "'";
            objDB.GetDataSet(strSQL1);
            objDB2.GetDataSet(strSQL2);


            String strLiked = "";
            String strPass = "";
            objDB.GetDataSet(strSQL1, out int theRecordCount);
            for (int i = 0; i < theRecordCount; i++)
            {
                Byte[] byteArray = (Byte[])objDB.GetField("userLiked", i);



                BinaryFormatter deSerializer = new BinaryFormatter();

                MemoryStream memStream = new MemoryStream(byteArray);



                Liked objliked = (Liked)deSerializer.Deserialize(memStream);

                string s = objliked.LikedEmail;

                myLikedList.Add(objliked);

                strLiked += myLikedList[i].ToString() + ",";


            }

            objDB2.GetDataSet(strSQL2, out int theRecordCountPass);
            for (int i = 0; i < theRecordCountPass; i++)
            {
                Byte[] byteArray = (Byte[])objDB2.GetField("userPass", i);



                BinaryFormatter deSerializerPass = new BinaryFormatter();

                MemoryStream memStream = new MemoryStream(byteArray);



                Liked objliked = (Liked)deSerializerPass.Deserialize(memStream);

                string s = objliked.LikedEmail;

                myPassList.Add(objliked);

                //  strPass += myLikedList[i].ToString() + ",";

                //  strLiked += myPassList[i].ToString() + ",";


            }



            gvLiked.DataSource = myLikedList;

            gvLiked.DataBind();

            gvPass.DataSource = myPassList;
            gvPass.DataBind();


        }

        protected void gvPass_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            // myPassList.RemoveAt(3);
            DBConnect delete = new DBConnect();
            Liked d = new Liked();
            Serialization serialize = new Serialization();

            string s = gvPass.Rows[e.RowIndex].Cells[0].Text;
            d.LikedEmail = s;

            d.UserEmail = Session["userEmail"].ToString();

            Byte[] returnedValue = serialize.doSerializeStringV(d, Session["userEmail"].ToString());


            ShowUseres();


        }

        protected void gvLiked_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // myPassList.RemoveAt(3);
            DBConnect delete = new DBConnect();
            Liked d = new Liked();
            Serialization serialize = new Serialization();

            string s = gvLiked.Rows[e.RowIndex].Cells[0].Text;
            d.LikedEmail = s;

            d.UserEmail = Session["userEmail"].ToString();

            Byte[] returnedValue = serialize.doSerializeStringL(d, Session["userEmail"].ToString());



            ShowUseres();

        }
    }
}
