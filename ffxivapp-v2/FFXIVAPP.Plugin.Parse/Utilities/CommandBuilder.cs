﻿// FFXIVAPP.Plugin.Parse
// CommandBuilder.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using FFXIVAPP.Common.RegularExpressions;
using FFXIVAPP.Plugin.Parse.Models;
using FFXIVAPP.Plugin.Parse.Models.Stats;

#endregion

namespace FFXIVAPP.Plugin.Parse.Utilities
{
    internal static class CommandBuilder
    {
        /// <summary>
        /// </summary>
        /// <param name="line"> </param>
        /// <param name="commands"> </param>
        public static void GetCommands(string line, out List<string> commands)
        {
            List<string> temp = null;
            var reg = SharedRegEx.ParseCommands.Match(line);
            if (!reg.Success)
            {
                commands = null;
                return;
            }
            var cmd = reg.Groups["cmd"].Success ? reg.Groups["cmd"].Value : "";
            var cm = reg.Groups["cm"].Success ? reg.Groups["cm"].Value : "p";
            var sub = reg.Groups["sub"].Success ? reg.Groups["sub"].Value : "";
            var limit = reg.Groups["limit"].Success ? Convert.ToInt32(reg.Groups["limit"].Value) : 1000;
            limit = (limit == 0) ? 1000 : limit;
            var ptline = ParseControl.Instance.Timeline.Party;
            switch (cmd)
            {
                case "show-mob":
                    var results = new Dictionary<string, int>();
                    temp = new List<string> {
                        String.Format("/{0} * {1} *", cm, sub)
                    };
                    foreach (var player in ptline)
                    {
                        StatGroup m;
                        if (!player.TryGetGroup("Monsters", out m))
                        {
                            continue;
                        }
                        foreach (var stats in m.Where(s => s.Name == sub).Select(r => r.Stats))
                        {
                            results.Add(player.Name, (int) Math.Ceiling(stats.GetStatValue("Total")));
                        }
                    }
                    temp.AddRange(results.OrderByDescending(i => i.Value).Select(item => String.Format("/{0} ", cm) + item.Key + ": " + item.Value));
                    break;
                case "show-total":
                    string t;
                    switch (sub)
                    {
                        case "ability":

                            t = PluginViewModel.Instance.Locale["parse_partytab"];
                            temp = new List<string> {
                                String.Format("/{0} * {1} *", cm, t)
                            };
                            foreach (var item in ptline.OrderByDescending(i => i.Stats.GetStatValue("Total")).Take(limit))
                            {
                                var amount = Math.Ceiling(item.Stats.GetStatValue("Total"));
                                temp.Add(String.Format("/{0} ", cm) + item.Name + ": " + amount);
                            }
                            break;
                        case "healing":
                            t = PluginViewModel.Instance.Locale["parse_healingtab"];
                            temp = new List<string> {
                                String.Format("/{0} * {1} *", cm, t)
                            };
                            foreach (var item in ptline.OrderByDescending(i => i.Stats.GetStatValue("HTotal")).Take(limit))
                            {
                                var amount = Math.Ceiling(item.Stats.GetStatValue("HTotal"));
                                temp.Add(String.Format("/{0} ", cm) + item.Name + ": " + amount);
                            }
                            break;
                        case "damage":
                            t = PluginViewModel.Instance.Locale["parse_damagetab"];
                            temp = new List<string> {
                                String.Format("/{0} * {1} *", cm, t)
                            };
                            foreach (var item in ptline.OrderByDescending(i => i.Stats.GetStatValue("DTTotal")).Take(limit))
                            {
                                var amount = Math.Ceiling(item.Stats.GetStatValue("DTTotal"));
                                temp.Add(String.Format("/{0} ", cm) + item.Name + ": " + amount);
                            }
                            break;
                        case "dps":
                            t = "DPS";
                            temp = new List<string> {
                                String.Format("/{0} * {1} *", cm, t)
                            };
                            foreach (var item in ptline.OrderBy(i => Math.Ceiling((decimal) i.GetStatValue("DPS"))).Take(limit))
                            {
                                var amount = Math.Ceiling(item.Stats.GetStatValue("DPS"));
                                temp.Add(String.Format("/{0} ", cm) + item.Name + ": " + amount);
                            }
                            break;
                    }
                    break;
            }
            if (temp != null)
            {
                commands = temp.Count == 1 ? null : temp;
                return;
            }
            commands = null;
        }
    }
}
