﻿// FFXIVAPP.Plugin.Log
// Settings.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media;
using FFXIVAPP.Common.Controls;
using FFXIVAPP.Common.Helpers;
using FFXIVAPP.Common.Models;
using FFXIVAPP.Common.Utilities;
using NLog;
using Color = System.Windows.Media.Color;
using ColorConverter = System.Windows.Media.ColorConverter;
using FontFamily = System.Drawing.FontFamily;

#endregion

namespace FFXIVAPP.Plugin.Log.Properties
{
    internal class Settings : ApplicationSettingsBase, INotifyPropertyChanged
    {
        private static Settings _default;

        public static Settings Default
        {
            get { return _default ?? (_default = ((Settings) (Synchronized(new Settings())))); }
        }

        public override void Save()
        {
            XmlHelper.DeleteXmlNode(Constants.XSettings, "Tab");
            foreach (var tab in PluginViewModel.Instance.Tabs)
            {
                var tabItem = (TabItem) tab;
                var flowDoc = (xFlowDocument) tabItem.Content;
                var xKey = tabItem.Header.ToString();
                var xValue = flowDoc.Codes.Items.Cast<object>().Aggregate("", (c, code) => c + "," + code).Substring(1);
                var xRegularExpression = flowDoc.RegEx.Text;
                var keyPairList = new List<XValuePair>();
                keyPairList.Add(new XValuePair {
                    Key = "Value",
                    Value = xValue
                });
                keyPairList.Add(new XValuePair {
                    Key = "RegularExpression",
                    Value = xRegularExpression
                });
                XmlHelper.SaveXmlNode(Constants.XSettings, "Settings", "Tab", xKey, keyPairList);
            }
            XmlHelper.DeleteXmlNode(Constants.XSettings, "Setting");
            if (Constants.Settings.Count == 0)
            {
                Constants.Settings.Add("EnableDebug");
                Constants.Settings.Add("ShowASCIIDebug");
                Constants.Settings.Add("EnableTranslate");
                Constants.Settings.Add("SendToEcho");
                Constants.Settings.Add("SendToGame");
                Constants.Settings.Add("SendRomanization");
                Constants.Settings.Add("TranslateTo");
                Constants.Settings.Add("ManualTranslate");
                Constants.Settings.Add("TranslateJPOnly");
                Constants.Settings.Add("TSay");
                Constants.Settings.Add("TTell");
                Constants.Settings.Add("TParty");
                Constants.Settings.Add("TLS");
                Constants.Settings.Add("TShout");
                Constants.Settings.Add("Zoom");
            }
            foreach (var i in Constants.Settings)
            {
                var xKey = i;
                var xValue = Default[xKey].ToString();
                var keyPairList = new List<XValuePair> {
                    new XValuePair {
                        Key = "Value",
                        Value = xValue
                    }
                };
                XmlHelper.SaveXmlNode(Constants.XSettings, "Settings", "Setting", xKey, keyPairList);
            }
            Constants.XSettings.Save(Constants.BaseDirectory + "Settings.xml");
        }

        public new void Reset()
        {
            foreach (var key in Constants.Settings)
            {
                var value = Default.Properties[key].DefaultValue.ToString();
                SetValue(key, value);
            }
        }

        public static void SetValue(string key, string value)
        {
            try
            {
                var type = Default[key].GetType().Name;
                switch (type)
                {
                    case "Boolean":
                        Default[key] = Convert.ToBoolean(value);
                        break;
                    case "Color":
                        var cc = new ColorConverter();
                        var color = cc.ConvertFrom(value);
                        Default[key] = color ?? Colors.Black;
                        break;
                    case "Double":
                        Default[key] = Convert.ToDouble(value);
                        break;
                    case "Font":
                        var fc = new FontConverter();
                        var font = fc.ConvertFromString(value);
                        Default[key] = font ?? new Font(new FontFamily("Microsoft Sans Serif"), 12);
                        break;
                    default:
                        Default[key] = value;
                        break;
                }
            }
            catch (SettingsPropertyNotFoundException ex)
            {
                Logging.Log(LogManager.GetCurrentClassLogger(), "", ex);
            }
            catch (SettingsPropertyWrongTypeException ex)
            {
                Logging.Log(LogManager.GetCurrentClassLogger(), "", ex);
            }
        }

        #region Property Bindings (Settings)

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("#FF000000")]
        public Color ChatBackgroundColor
        {
            get { return ((Color) (this["ChatBackgroundColor"])); }
            set
            {
                this["ChatBackgroundColor"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("#FF800080")]
        public Color TimeStampColor
        {
            get { return ((Color) (this["TimeStampColor"])); }
            set
            {
                this["TimeStampColor"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("Microsoft Sans Serif, 12pt")]
        public Font ChatFont
        {
            get { return ((Font) (this["ChatFont"])); }
            set
            {
                this["ChatFont"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool EnableDebug
        {
            get { return ((bool) (this["EnableDebug"])); }
            set
            {
                this["EnableDebug"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool ShowAsciiDebug
        {
            get { return ((bool) (this["ShowASCIIDebug"])); }
            set
            {
                this["ShowASCIIDebug"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool EnableTranslate
        {
            get { return ((bool) (this["EnableTranslate"])); }
            set
            {
                this["EnableTranslate"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool SendToEcho
        {
            get { return ((bool) (this["SendToEcho"])); }
            set
            {
                this["SendToEcho"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool SendToGame
        {
            get { return ((bool) (this["SendToGame"])); }
            set
            {
                this["SendToGame"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool SendRomanization
        {
            get { return ((bool) (this["SendRomanization"])); }
            set
            {
                this["SendRomanization"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("English")]
        public string TranslateTo
        {
            get { return ((string) (this["TranslateTo"])); }
            set
            {
                this["TranslateTo"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("Japanese")]
        public string ManualTranslate
        {
            get { return ((string) (this["ManualTranslate"])); }
            set
            {
                this["ManualTranslate"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool TranslateJPOnly
        {
            get { return ((bool) (this["TranslateJPOnly"])); }
            set
            {
                this["TranslateJPOnly"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool TSay
        {
            get { return ((bool) (this["TSay"])); }
            set
            {
                this["TSay"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool TTell
        {
            get { return ((bool) (this["TTell"])); }
            set
            {
                this["TTell"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool TParty
        {
            get { return ((bool) (this["TParty"])); }
            set
            {
                this["TParty"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool TLS
        {
            get { return ((bool) (this["TLS"])); }
            set
            {
                this["TLS"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool TShout
        {
            get { return ((bool) (this["TShout"])); }
            set
            {
                this["TShout"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("100")]
        public Double Zoom
        {
            get { return ((Double) (this["Zoom"])); }
            set
            {
                this["Zoom"] = value;
                RaisePropertyChanged();
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Albanian</string>
  <string>Arabic</string>
  <string>Bulgarian</string>
  <string>Catalan</string>
  <string>Chinese (Simplified)</string>
  <string>Chinese (Traditional)</string>
  <string>Croatian</string>
  <string>Czech</string>
  <string>Danish</string>
  <string>Dutch</string>
  <string>English</string>
  <string>Estonian</string>
  <string>Filipino</string>
  <string>Finnish</string>
  <string>French</string>
  <string>Galician</string>
  <string>German</string>
  <string>Greek</string>
  <string>Hebrew</string>
  <string>Hindi</string>
  <string>Hungarian</string>
  <string>Indonesian</string>
  <string>Italian</string>
  <string>Japanese</string>
  <string>Korean</string>
  <string>Latvian</string>
  <string>Lithuanian</string>
  <string>Maltese</string>
  <string>Norwegian</string>
  <string>Polish</string>
  <string>Portuguese</string>
  <string>Romanian</string>
  <string>Russian</string>
  <string>Serbian</string>
  <string>Slovak</string>
  <string>Slovenian</string>
  <string>Spanish</string>
  <string>Swedish</string>
  <string>Thai</string>
  <string>Turkish</string>
  <string>Ukrainian</string>
  <string>Vietnamese</string>
</ArrayOfString>")]
        public StringCollection TranslateLanguages
        {
            get { return ((StringCollection) (this["TranslateLanguages"])); }
            set { this["TranslateLanguages"] = value; }
        }

        #endregion

        #region Implementation of INotifyPropertyChanged

        public new event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}
