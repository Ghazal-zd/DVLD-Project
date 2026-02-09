using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BuisnessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace DVLD.Classes
{
    internal static  class clsGlobal
    {
        public static clsUser CurrentUser;

        static string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
        static string UserName = "UserName";
        static string Password = "Password";
        public static bool RememberUsernameAndPassword(string username, string password)
        {
            /* 
             * Store login in information using text file:
             
             string currentDirectory = System.IO.Directory.GetCurrentDirectory();
             string filePath = currentDirectory + "\\UserInfoFile.txt";

             if (Username == "" && File.Exists(filePath)) 
             { 
                 File.Delete(filePath);
                 return true;
             }

             string dataToSave = Username + "#//#" + Password;

             using (StreamWriter writer = new StreamWriter(filePath))
             {
                 writer.WriteLine(dataToSave);
                 return true;
             }
         }
         catch (Exception ex)
         {
             MessageBox.Show($"An error occurred: {ex.Message}");
             return false;
         }
            */
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\DVLD", true))
                        {
                            if (key != null)
                            {
                                key.DeleteValue(UserName,false);
                                key.DeleteValue(Password,false);
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    Registry.SetValue(keyPath, UserName, username, RegistryValueKind.String);
                    Registry.SetValue(keyPath, Password, password, RegistryValueKind.String);
                    return true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("UnauthorizedAccessException: Run the program with administrative privileges.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }
        public static bool GetStoredCredential(ref string username, ref string password)
        {
            /*
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();
                string filePath = currentDirectory + "\\UserInfoFile.txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
            */
            try
            {
                username = Registry.GetValue(keyPath, UserName, null) as string;
                password = Registry.GetValue(keyPath, Password, null) as string;

                if(username != null && password != null)
                {
                    return true;
                }
                return false;
            }        
            
            catch (Exception ex)
            {
                MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;   
            }

        }
    }
}
