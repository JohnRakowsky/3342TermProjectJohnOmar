using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;     // needed for the encryption classes
using System.IO;                        // needed for the MemoryStream
using System.Net;                       // needed for the cookie

namespace Utilities
{

    public class RSA
    {
        // key and vectore to use in  RijndaelManaged encryption
        private byte[] key = { 250, 101, 18, 76, 45, 135, 207, 118, 4, 171, 3, 168, 202, 241, 37, 199 };
        private byte[] vector = { 146, 64, 191, 111, 23, 3, 113, 119, 231, 121, 252, 112, 79, 32, 114, 156 };




        // a method to encrypt password with RijndaelManaged
        public string PasswordEncryption(string password)
        {


            String plainTextPassword = password;
            String encryptedPassword;
            UTF8Encoding encoder = new UTF8Encoding();      // used to convert bytes to characters, and back

            Byte[] textBytes;                               // stores the plain text data as bytes

            textBytes = encoder.GetBytes(plainTextPassword);

            RijndaelManaged rmEncryption = new RijndaelManaged();
            MemoryStream myMemoryStream = new MemoryStream();
            CryptoStream myEncryptionStream = new CryptoStream(myMemoryStream, rmEncryption.CreateEncryptor(key, vector), CryptoStreamMode.Write);
            myEncryptionStream.Write(textBytes, 0, textBytes.Length);
            myEncryptionStream.FlushFinalBlock();
            myMemoryStream.Position = 0;
            Byte[] encryptedBytes = new Byte[myMemoryStream.Length];
            myMemoryStream.Read(encryptedBytes, 0, encryptedBytes.Length);

            //Close stream
            myEncryptionStream.Close();
            myMemoryStream.Close();

            // Convert the bytes to a string to return it.
            encryptedPassword = Convert.ToBase64String(encryptedBytes);

            return encryptedPassword;
        }






        public string PasswordDecryption(string password)
        {

            String encryptedPassword = password;
            Byte[] encryptedPasswordBytes = Convert.FromBase64String(encryptedPassword);
            Byte[] textBytes;
            String plainTextPassword;
            UTF8Encoding encoder = new UTF8Encoding();

            RijndaelManaged rmEncryption = new RijndaelManaged();

            MemoryStream myMemoryStream = new MemoryStream();

            CryptoStream myDecryptionStream = new CryptoStream(myMemoryStream, rmEncryption.CreateDecryptor(key, vector), CryptoStreamMode.Write);

            myDecryptionStream.Write(encryptedPasswordBytes, 0, encryptedPasswordBytes.Length);

            myDecryptionStream.FlushFinalBlock();

            myMemoryStream.Position = 0;

            textBytes = new Byte[myMemoryStream.Length];

            myMemoryStream.Read(textBytes, 0, textBytes.Length);



            // Close all the streams.

            myDecryptionStream.Close();

            myMemoryStream.Close();

            // Convert the bytes to a string and return it.

            plainTextPassword = encoder.GetString(textBytes);


            return plainTextPassword;
        }
        /// <summary>
        /// /// here we used RSA encryption 
        /// first we instantiate RSA crypto service provider 
        /// </summary>
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;

        public RSA()
        {
            // generate private and public key 
            _privateKey = rsa.ExportParameters(true);
            _publicKey = rsa.ExportParameters(false);
        }

        // a method to encrypt the password using RSA
        public string Encrypt1(string input)
        {

            rsa = new RSACryptoServiceProvider();
            // we import the public key ( in encrypting we use public key 
            rsa.ImportParameters(_publicKey);
            // turning the password into bytes
            var data = Encoding.Unicode.GetBytes(input);
            // preform encryption
            var Cypher = rsa.Encrypt(data, false);
            // return a string value from byts value 
            return Convert.ToBase64String(Cypher);

        }
        // a method to decrypt password
        public string Decrypt1(string cypherText)
        {

            var dataBytes = Convert.FromBase64String(cypherText);
            rsa = new RSACryptoServiceProvider();
            //we use private key to decrypt password
            rsa.ImportParameters(_privateKey);
            //preform decrypting
            var plainText = rsa.Decrypt(dataBytes, false);
            //return string from byte vale 
            return Encoding.Unicode.GetString(plainText);

        }

    }
}