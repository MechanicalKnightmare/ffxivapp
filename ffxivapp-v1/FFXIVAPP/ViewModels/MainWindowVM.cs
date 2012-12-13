﻿// FFXIVAPP
// MainWindowVM.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System;
using System.IO;
using System.Windows.Input;
using FFXIVAPP.Classes;
using FFXIVAPP.Classes.Helpers;

#endregion

namespace FFXIVAPP.ViewModels
{
    public class MainWindowVM
    {
        private static string _currentView = "main";

        public MainWindowVM()
        {
            SwitchViewCommand = new DelegateCommand<string>(SwitchView);
            ScreenShotCommand = new DelegateCommand(ScreenShot);
        }

        #region GUI Functions

        /// <summary>
        /// </summary>
        /// <param name="t"> </param>
        public static void SwitchView(string t)
        {
            if (_currentView == t)
            {
                return;
            }
            if (_currentView == "settings")
            {
                SettingsVM.SaveCharacter();
            }
            switch (t)
            {
                case "main":
                    MainWindow.View.MainWindowTC.SelectedItem = MainWindow.View.MainWindowTC.FindName("MainTI");
                    //ThemeHelper.ChangeTheme(Settings.Default.Theme);
                    break;
                case "chat":
                    MainWindow.View.MainWindowTC.SelectedItem = MainWindow.View.MainWindowTC.FindName("ChatTI");
                    //ThemeHelper.ChangeTheme(Settings.Default.ChatTheme);
                    break;
                case "log":
                    MainWindow.View.MainWindowTC.SelectedItem = MainWindow.View.MainWindowTC.FindName("LogTI");
                    //ThemeHelper.ChangeTheme(Settings.Default.LogTheme);
                    break;
                case "parse":
                    MainWindow.View.MainWindowTC.SelectedItem = MainWindow.View.MainWindowTC.FindName("ParseTI");
                    //ThemeHelper.ChangeTheme(Settings.Default.ParseTheme);
                    break;
                case "event":
                    MainWindow.View.MainWindowTC.SelectedItem = MainWindow.View.MainWindowTC.FindName("EventTI");
                    //ThemeHelper.ChangeTheme(Settings.Default.ParseTheme);
                    break;
                case "settings":
                    MainWindow.View.MainWindowTC.SelectedItem = MainWindow.View.MainWindowTC.FindName("SettingsTI");
                    //ThemeHelper.ChangeTheme(Settings.Default.Theme);
                    break;
                case "about":
                    MainWindow.View.MainWindowTC.SelectedItem = MainWindow.View.MainWindowTC.FindName("AboutTI");
                    //ThemeHelper.ChangeTheme(Settings.Default.Theme);
                    break;
            }
            SettingsHelper.Save();
            _currentView = t;
        }

        /// <summary>
        /// </summary>
        private static void ScreenShot()
        {
            var fileName = MainWindow.View.Ipath + DateTime.Now.ToString("dd.MM.yyyy-HH.mm.ss_") + ".jpg";
            var screenshot = ScreenCapture.GetJpgImage(MainWindow.View, 1, 100);
            var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            using (var s = new BinaryWriter(fileStream))
            {
                s.Write(screenshot);
                s.Close();
            }
        }

        #endregion

        public ICommand SwitchViewCommand { get; private set; }
        public ICommand ScreenShotCommand { get; private set; }
    }
}
