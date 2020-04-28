using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                                          //needed for ADO.NET classes

using System.Data.SqlClient;                                //needed for the Sql data provider

using System.Runtime.Serialization.Formatters.Binary;       //needed for BinaryFormatter

using System.IO;                                            //needed for the MemoryStream

namespace Utilities
{
    [Serializable]

    public class Liked
    {



        private String userEmail;

        private String likedEmail;





        public String UserEmail

        {

            get { return userEmail; }

            set { userEmail = value; }

        }



        public String LikedEmail

        {

            get { return likedEmail; }

            set { likedEmail = value; }

        }





    }
}