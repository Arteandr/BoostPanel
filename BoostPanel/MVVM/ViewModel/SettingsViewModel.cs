using BoostPanel.Server;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BoostPanel.MVVM.ViewModel
{
    public class SettingsViewModel
    {
        public SettingsViewModel()
        {
            Cs_go_path = Program.cs_go_path;
            Steam_path = Program.steam_path;
        }

        #region Fields
        public string Cs_go_path { get; set; }
        public string Steam_path { get; set; }
        #endregion

        public void OpenFile()
        {
            OpenFileDialog fl = new OpenFileDialog();
            if (fl.ShowDialog() == true)
            {
                this.Steam_path = fl.FileName;
            }
        }

    }
}