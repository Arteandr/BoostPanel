
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Documents;

namespace BoostPanel.AccountsImport
{
    public partial class AccountsImport
    {
        private static List<List<string>> accs;
        private static bool _contentLoaded;


        private static void SetUploaded(List<List<string>> accs)
        {
            if (accs.Count <= 0)
                return;
            AccountsImport.accs = accs;
            Console.WriteLine($"Загружено {accs.Count} аккаунтов");
            foreach (List<string> acc in accs)
            {
                Console.WriteLine($"Login: {acc[0]} Password: {acc[1]}");
            }
        }

        public static void Upload()
        {
            List<List<string>> accs = new List<List<string>>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string path;
            try
            {
                path = openFileDialog.FileName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                path = "";
            }

            try
            {
                foreach (string readAllLine in File.ReadAllLines(path))
                {
                    char[] chArray = new char[1] { ':' };   // login:password
                    string[] strArray = readAllLine.Split(chArray);
                    if(strArray.Length >= 2)
                    {
                        string str1 = strArray[0].Replace(" ", "");
                        string str2 = strArray[1].Replace(" ", "");
                        if (str1.Length >= 1 && str2.Length >= 1)
                            accs.Add(new List<string>() { str1, str2 });
                    }
                }
                SetUploaded(accs);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
