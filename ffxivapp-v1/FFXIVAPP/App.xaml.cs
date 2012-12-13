﻿// FFXIVAPP
// App.xaml.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using System.Xml;
using System.Xml.Linq;
using FFXIVAPP.Classes.Helpers;
using FFXIVAPP.Properties;
using NLog;
using NLog.Config;

#endregion

namespace FFXIVAPP
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static String[] MArgs;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly string[] _clean = {"Ionic.Zip.dll", "Updater.exe"};
        private readonly string[] _directories = {"./Logs/", "./Resources/", "./Settings/", "./ScreenShots/", "./Plugins/", "./Sounds/"};
        private readonly string[] _main = {"FFXIVAPP.exe.nlog", "Ionic.Zip.dll", "Updater.exe"};
        private readonly string[] _settings = {"Colors.xml", "Events.xml", "Settings.xml", "RegularExpressions.xml"};
        private readonly string[] _sounds = {"aruba.wav"};

        public App()
        {
            try
            {
                if (Settings.Default.Application_UpgradeRequired)
                {
                    Settings.Default.Upgrade();
                    Settings.Default.Reload();
                    Settings.Default.Application_UpgradeRequired = false;
                }
            }
            catch
            {
                SettingsHelper.Default();
            }
            Dispatcher.UnhandledException += OnDispatcherUnhandledException;
            Configure();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length > 0)
            {
                MArgs = e.Args;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private static void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            Logger.Error("{0} :\n{1}", e.Exception.Message, e.Exception.StackTrace);
            e.Handled = true;
        }

        #region Startup

        /// <summary>
        /// </summary>
        private void Configure()
        {
            DirectoryStructure();
            ConfigureNLog();
            UpdateResources();
        }

        /// <summary>
        /// </summary>
        private void DirectoryStructure()
        {
            foreach (var item in _directories.Where(item => !Directory.Exists(item)))
            {
                Directory.CreateDirectory(item);
            }
        }

        /// <summary>
        /// </summary>
        private static void ConfigureNLog()
        {
            if (!File.Exists("./FFXIVAPP.exe.nlog"))
            {
                var resourceUri = new Uri("pack://application:,,,/FFXIVAPP;component/Resources/FFXIVAPP.exe.nlog");
                var resource = GetResourceStream(resourceUri);
                if (resource != null)
                {
                    var sr = new StringReader(XElement.Load(resource.Stream).ToString());
                    var xr = XmlReader.Create(sr);
                    LogManager.Configuration = new XmlLoggingConfiguration(xr, null);
                }
            }
        }

        /// <summary>
        /// </summary>
        private void UpdateResources()
        {
            foreach (var item in _clean)
            {
                Delete(item, "./");
            }
            foreach (var item in _settings)
            {
                Extract(item, "./Settings/", "Settings");
            }
            foreach (var item in _sounds)
            {
                Extract(item, "./Sounds/", "Media/Sounds");
            }
            foreach (var item in _main)
            {
                Extract(item, "./", "Resources");
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="name"> </param>
        /// <param name="path"> </param>
        private static void Delete(string name, string path)
        {
            var saved = path + name;
            try
            {
                if (File.Exists(saved))
                {
                    File.Delete(saved);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("{0} :\n{1}", ex.Message, ex.StackTrace);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="name"> </param>
        /// <param name="path"> </param>
        /// <param name="type"> </param>
        private static void Extract(string name, string path, string type)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var saved = path + name;
            try
            {
                var resourceUri = new Uri(String.Format("pack://application:,,,/FFXIVAPP;component/{0}/{1}", type, name));
                if (!File.Exists(saved))
                {
                    var streamResourceInfo = GetResourceStream(resourceUri);
                    if (streamResourceInfo != null)
                    {
                        using (var s = streamResourceInfo.Stream)
                        {
                            if (s == null)
                            {
                                Logger.Error("ErrorEvent : {0}", "Resource Is Null : '" + name + "'");
                                Current.Shutdown();
                            }
                            var buffer = new byte[s.Length];
                            s.Read(buffer, 0, buffer.Length);
                            using (var sw = new BinaryWriter(File.Open(saved, FileMode.Create)))
                            {
                                sw.Write(buffer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("{0} :\n{1}", ex.Message, ex.StackTrace);
                Current.Shutdown();
            }
        }

        #endregion
    }
}
