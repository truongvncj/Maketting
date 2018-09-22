using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace Maketting.Model
{

    //The RSA algorithm is the most commonly used public key encryption algorithm.

    class SercurityFucntion
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
  //      byte[] plaintext;
     //   byte[] encryptedtext;

        public  bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            using (FileStream
            fileStream = new FileStream(fileName, FileMode.Create))
            {
                // Write the data to the file, byte by byte.
                for (int i = 0; i < byteArray.Length; i++)
                {
                    fileStream.WriteByte(byteArray[i]);
                }

                // Set the stream position to the beginning of the file.
                fileStream.Seek(0, SeekOrigin.Begin);

                // Read and verify the data.
                for (int i = 0; i < fileStream.Length; i++)
                {
                    if (byteArray[i] != fileStream.ReadByte())
                    {
                        MessageBox.Show("Error to write file");
                        return false;
                    }
                }
                return true;
            }
        }

        public byte[] ReadBytesfromfile(string fileName)
        {

            byte[] buffer = null;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }
            return buffer;


        }



        public byte[] encryptedtextdo(string inputextforencrypt)
        {
            byte[] plaintext = ByteConverter.GetBytes(inputextforencrypt);
            //   MessageBox.Show(inputextforencrypt);
            byte[] encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
            //  string returnstring = ByteConverter.GetString(encryptedtext);
            //    MessageBox.Show(inputextforencrypt);

         

            return encryptedtext;
        }

        public string dencryptedtextdo(byte[] encryptedtextforde)
        {
           

            byte[] decryptedtex = Decryption(encryptedtextforde, RSA.ExportParameters(true), false);
            if (decryptedtex != null)
            {
                string returnstring = ByteConverter.GetString(decryptedtex);
                return returnstring;
            }
            else
            {
                return "";
            }
          
         //   MessageBox.Show(returnstring);
           

        }

        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey); encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
            //    MessageBox.Show(e.Message);
                return null;
            }
        }

        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
               //    MessageBox.Show(e.Message);
                return null;
            }
        }


    }
}
