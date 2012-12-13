﻿// FFXIVAPP.Plugin.Log
// PluginViewModel.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using FFXIVAPP.Common.Events;

#endregion

namespace FFXIVAPP.Plugin.Log
{
    internal sealed class PluginViewModel : INotifyPropertyChanged
    {
        //used for global static properties

        public event EventHandler<PopupResultEvent> PopupResultChanged = delegate { };

        public void OnPopupResultChanged(PopupResultEvent e)
        {
            PopupResultChanged(this, e);
        }

        #region Property Bindings

        private static PluginViewModel _instance;
        private Dictionary<string, string> _locale;
        private ObservableCollection<UIElement> _tabs;

        public static PluginViewModel Instance
        {
            get { return _instance ?? (_instance = new PluginViewModel()); }
        }

        public Dictionary<string, string> Locale
        {
            get { return _locale ?? (_locale = new Dictionary<string, string>()); }
            set
            {
                _locale = value;
                RaisePropertyChanged();
            }
        }

        public static Dictionary<string, string> PluginInfo
        {
            get
            {
                var pluginInfo = new Dictionary<string, string>();
                pluginInfo.Add("Icon", "Logo.png");
                pluginInfo.Add("Name", Constants.PluginName);
                pluginInfo.Add("Description", Constants.PluginDescription);
                pluginInfo.Add("Copyright", Constants.PluginCopyright);
                pluginInfo.Add("Version", Constants.PluginVersion.ToString());
                return pluginInfo;
            }
        }

        public ObservableCollection<UIElement> Tabs
        {
            get { return _tabs ?? (_tabs = new ObservableCollection<UIElement>()); }
            set
            {
                _tabs = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Declarations

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}
