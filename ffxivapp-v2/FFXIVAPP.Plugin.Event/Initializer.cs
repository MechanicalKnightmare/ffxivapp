﻿// FFXIVAPP.Plugin.Event
// Initializer.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System;
using System.Linq;
using System.Xml.Linq;
using FFXIVAPP.Common.Models;
using FFXIVAPP.Plugin.Event.Properties;

#endregion

namespace FFXIVAPP.Plugin.Event
{
    internal static class Initializer
    {
        #region Declarations

        #endregion

        /// <summary>
        /// </summary>
        public static void LoadSettings()
        {
            if (Constants.XSettings != null)
            {
                foreach (var xElement in Constants.XSettings.Descendants().Elements("Setting"))
                {
                    var xKey = (string) xElement.Attribute("Key");
                    var xValue = (string) xElement.Element("Value");
                    if (String.IsNullOrWhiteSpace(xKey) || String.IsNullOrWhiteSpace(xValue))
                    {
                        return;
                    }
                    Settings.SetValue(xKey, xValue);
                    if (!Constants.Settings.Contains(xKey))
                    {
                        Constants.Settings.Add(xKey);
                    }
                }
            }
        }

        /// <summary>
        /// </summary>
        public static void LoadEvents()
        {
            if (Constants.XSettings != null)
            {
                foreach (var xElement in Constants.XSettings.Descendants().Elements("Event"))
                {
                    var xKey = (string) xElement.Attribute("Key");
                    var xValue = (string) xElement.Element("Value");
                    if (String.IsNullOrWhiteSpace(xKey))
                    {
                        return;
                    }
                    xValue = String.IsNullOrWhiteSpace(xValue) ? "aruba.wav" : xValue;
                    var valuePair = new XValuePair {
                        Key = xKey,
                        Value = xValue
                    };
                    var found = PluginViewModel.Instance.Events.Any(pair => pair.Key == valuePair.Key);
                    if (!found)
                    {
                        PluginViewModel.Instance.Events.Add(valuePair);
                    }
                }
            }
        }
    }
}
