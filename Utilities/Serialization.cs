using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

using System.Data;                                          //needed for ADO.NET classes

using System.Data.SqlClient;                                //needed for the Sql data provider

using System.Runtime.Serialization.Formatters.Binary;       //needed for BinaryFormatter

using System.IO;                                            //needed for the MemoryStream

namespace Utilities
{

    public class Serialization
    {
        DBConnect objDB = new DBConnect();

        SqlCommand objCommand = new SqlCommand();

        public string doSerialize(Liked liked, string userEmail)
        {

            string rVal;
            BinaryFormatter serializer = new BinaryFormatter();

            MemoryStream memStream = new MemoryStream();

            Byte[] byteArray;

            serializer.Serialize(memStream, liked);

            byteArray = memStream.ToArray();
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.CommandText = "addLiked";



            objCommand.Parameters.AddWithValue("@userEmail", userEmail);

            objCommand.Parameters.AddWithValue("@userLiked", byteArray);



            int retVal = objDB.DoUpdateUsingCmdObj(objCommand);



            //// Check to see whether the update was successful

            if (retVal > 0)
            {

                rVal = " added to liked collection";
            }
            else
            {

                rVal = "A problem occured in storing the liked profile";

            }
            return rVal;


        }

        public string doSerializePass(Liked pass, string userEmail)
        {

            string rVal;
            BinaryFormatter serializer = new BinaryFormatter();

            MemoryStream memStream = new MemoryStream();

            Byte[] byteArray;

            serializer.Serialize(memStream, pass);

            byteArray = memStream.ToArray();
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.CommandText = "addPass";



            objCommand.Parameters.AddWithValue("@userEmail", userEmail);

            objCommand.Parameters.AddWithValue("@userPass", byteArray);



            int retVal = objDB.DoUpdateUsingCmdObj(objCommand);



            //// Check to see whether the update was successful

            if (retVal > 0)
            {

                rVal = " added to liked collection";
            }
            else
            {

                rVal = "A problem occured in storing the liked profile";

            }
            return rVal;


        }


        public Byte[] doSerializeStringV(Liked delete, string userEmail)
        {

            string rVal;
            BinaryFormatter serializer = new BinaryFormatter();

            MemoryStream memStream = new MemoryStream();

            Byte[] byteArray;

            serializer.Serialize(memStream, delete);

            byteArray = memStream.ToArray();
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.CommandText = "deletePass";



            objCommand.Parameters.AddWithValue("@userEmail", userEmail);

            objCommand.Parameters.AddWithValue("@userPass", byteArray);



            int retVal = objDB.DoUpdateUsingCmdObj(objCommand);



            //// Check to see whether the update was successful

            if (retVal > 0)
            {

                rVal = " added to liked collection";
            }
            else
            {

                rVal = "A problem occured in storing the liked profile";

            }


            return byteArray;


        }

        public Byte[] doSerializeStringL(Liked delete, string userEmail)
        {

            string rVal;
            BinaryFormatter serializer = new BinaryFormatter();

            MemoryStream memStream = new MemoryStream();

            Byte[] byteArray;

            serializer.Serialize(memStream, delete);

            byteArray = memStream.ToArray();
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.CommandText = "deleteLiked";



            objCommand.Parameters.AddWithValue("@userEmail", userEmail);

            objCommand.Parameters.AddWithValue("@userLiked", byteArray);



            int retVal = objDB.DoUpdateUsingCmdObj(objCommand);



            //// Check to see whether the update was successful

            if (retVal > 0)
            {

                rVal = " added to liked collection";
            }
            else
            {

                rVal = "A problem occured in storing the liked profile";

            }


            return byteArray;


        }
    }
}
