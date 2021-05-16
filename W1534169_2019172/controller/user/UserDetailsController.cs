using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using W1534169_2019172.model.user;

namespace W1534169_2019172.controller.user
{
    public class UserDetailsController
    {
        User user;
        public string SignUpUser(User userDetails, string confirmPassword)
        {

            if (!userDetails.Password.Equals(confirmPassword)){
                return "Passwords didn't match. Please confirm the password";
            }
            else
            {
                user = new User();
                /* Encrypting password prior to saving in the database */
                String encryptedPW = Encrypt(userDetails.Password, "sblw-3hn8-sqoy19");
                userDetails.Password = encryptedPW;

                /* Saving results in the database */
                user.createUser(userDetails);
                return "Successfully Registered!";
            }
        }

        public string SignInUser(User userDetails)
        {
            string message = "";

            user = new User();
            user = user.getUser(userDetails);

            if(user == null)
            {
                message = "Username or Password is incorrect. Please type again!";
            }
            else
            {
                /* Decrypiting password */
                
                if (user.Password == null)
                {
                    message = "Username or Password is incorrect. Please type again!";
                }
                else
                {
                    String decryptedPW = Decrypt(user.Password, "sblw-3hn8-sqoy19");
                    if (!decryptedPW.Equals(userDetails.Password))
                    {
                        message = "Username or Password is incorrect. Please type again!";
                    }
                    else
                    {
                        writeFile("currentUser.xml", user.Id);
                        message = "Success!";
                    }
                }
            }

            return message;
        }

        public static string Encrypt(string input, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();

            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static string Decrypt(string input, string key)
        {
            byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();

            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public void writeFile(string fileName, int userId)
        {
            String workingDir = Directory.GetCurrentDirectory();
            XmlTextWriter textWriter = new XmlTextWriter(string.Format("{0}\\{1}", workingDir, fileName), Encoding.UTF32);
            textWriter.WriteStartDocument();

            textWriter.WriteComment("This file contains the currently logged-in User ID");

            textWriter.WriteStartElement("UserID", "");
            textWriter.WriteValue(userId);
            textWriter.WriteEndElement();

            textWriter.WriteEndDocument();

            textWriter.Close();
            Console.ReadLine();
        }


        public int readFile(string fileName)
        {
            int userId = 0;
            String workingDir = Directory.GetCurrentDirectory();
            XmlTextReader textReader = new XmlTextReader(string.Format("{0}\\{1}", workingDir, fileName));
            Console.WriteLine("Base URI:" + textReader.BaseURI);
            textReader.Read();
            while (textReader.Read())
            {
                textReader.MoveToElement();
                if (textReader.Name == "UserID")
                {
                    textReader.Read();
                    XmlNodeType nType = textReader.NodeType;
                    if (nType == XmlNodeType.Text)
                    {
                        userId = Convert.ToInt32(textReader.Value.ToString());
                        Console.WriteLine("UserID:" + textReader.Value.ToString());
                    }
                }
            }
            Console.ReadLine();
            textReader.Close();
            return userId;
        }
    }
}
