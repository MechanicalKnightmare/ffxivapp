﻿// FFXIVAPP.Common
// SoundPlayerHelper.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System;
using System.Media;
using FFXIVAPP.Common.Utilities;
using NLog;

#endregion

namespace FFXIVAPP.Common.Helpers
{
    public static class SoundPlayerHelper
    {
        /// <summary>
        /// </summary>
        /// <param name="path"> </param>
        /// <param name="filename"> </param>
        public static void Play(string path = "Sounds/", string filename = "aruba.wav")
        {
            using (var soundPlayer = new SoundPlayer())
            {
                try
                {
                    soundPlayer.SoundLocation = path + filename;
                    soundPlayer.PlaySync();
                }
                catch (Exception ex)
                {
                    Logging.Log(LogManager.GetCurrentClassLogger(), "", ex);
                }
            }
        }
    }
}
