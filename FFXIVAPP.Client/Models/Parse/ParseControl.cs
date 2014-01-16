﻿// FFXIVAPP.Client
// ParseControl.cs
// 
// © 2013 Ryan Wilson

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using FFXIVAPP.Client.Helpers;
using FFXIVAPP.Client.Models.Parse.StatGroups;
using FFXIVAPP.Client.Models.Parse.Timelines;
using FFXIVAPP.Client.Monitors;
using FFXIVAPP.Common.Core.Memory.Enums;
using FFXIVAPP.Common.Core.Parse;
using Newtonsoft.Json;
using NLog;
using SmartAssembly.Attributes;

namespace FFXIVAPP.Client.Models.Parse
{
    [DoNotObfuscate]
    public class ParseControl : IParsingControl, INotifyPropertyChanged
    {
        #region Logger

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Auto Properties

        public bool IsHistoryBased { get; set; }
        public bool FirstActionFound { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        #endregion

        #region Declarations

        private readonly Timer _parseEntityTimer = new Timer(100);
        private ParseEntity LastParseEntity { get; set; }

        #endregion

        public ParseControl(bool isHistoryBased = false)
        {
            IsHistoryBased = isHistoryBased;
            Timeline = new Timeline(this);
            TimelineMonitor = new TimelineMonitor(this);
            StatMonitor = new StatMonitor(this);
            StartTime = DateTime.Now;
            if (isHistoryBased)
            {
                return;
            }
            _parseEntityTimer.Elapsed += ParseEntityTimerOnElapsed;
            _parseEntityTimer.Start();
        }

        private bool ParseEntityTimerProcessing { get; set; }

        private void ParseEntityTimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            EndTime = DateTime.Now;
            try
            {
                if (ParseEntityTimerProcessing)
                {
                    return;
                }
                ParseEntityTimerProcessing = true;
                var parseEntity = new ParseEntity
                {
                    Players = new List<PlayerEntity>()
                };
                foreach (Player player in Timeline.Party)
                {
                    var playerEntity = new PlayerEntity
                    {
                        Name = player.Name,
                        Job = Actor.Job.Unknown,
                        DPS = (decimal) player.GetStatValue("DPS"),
                        HPS = (decimal) player.GetStatValue("HPS"),
                        DTPS = (decimal) player.GetStatValue("DTPS"),
                        TotalOverallDamage = (decimal) player.GetStatValue("TotalOverallDamage"),
                        TotalOverallHealing = (decimal) player.GetStatValue("TotalOverallHealing"),
                        TotalOverallDamageTaken = (decimal) player.GetStatValue("TotalOverallDamageTaken"),
                        PercentOfTotalOverallDamage = (decimal) player.GetStatValue("PercentOfTotalOverallDamage"),
                        PercentOfTotalOverallHealing = (decimal) player.GetStatValue("PercentOfTotalOverallHealing"),
                        PercentOfTotalOverallDamageTaken = (decimal) player.GetStatValue("PercentOfTotalOverallDamageTaken")
                    };
                    if (player.NPCEntry != null)
                    {
                        playerEntity.Job = player.NPCEntry.Job;
                    }
                    parseEntity.Players.Add(playerEntity);
                }
                parseEntity.DPS = (decimal) Timeline.Overall.GetStatValue("DPS");
                parseEntity.HPS = (decimal) Timeline.Overall.GetStatValue("HPS");
                parseEntity.DTPS = (decimal) Timeline.Overall.GetStatValue("DTPS");
                parseEntity.TotalOverallDamage = (decimal) Timeline.Overall.GetStatValue("TotalOverallDamage");
                parseEntity.TotalOverallHealing = (decimal) Timeline.Overall.GetStatValue("TotalOverallHealing");
                parseEntity.TotalOverallDamageTaken = (decimal) Timeline.Overall.GetStatValue("TotalOverallDamageTaken");
                var notify = false;
                if (LastParseEntity == null)
                {
                    LastParseEntity = parseEntity;
                    notify = true;
                }
                else
                {
                    var hash1 = JsonConvert.SerializeObject(LastParseEntity)
                                           .GetHashCode();
                    var hash2 = JsonConvert.SerializeObject(parseEntity)
                                           .GetHashCode();
                    if (!hash1.Equals(hash2))
                    {
                        LastParseEntity = parseEntity;
                        notify = true;
                    }
                }
                if (notify)
                {
                    AppContextHelper.Instance.RaiseNewParseEntity(parseEntity);
                }
            }
            catch (Exception ex)
            {
            }
            ParseEntityTimerProcessing = false;
        }

        #region Implementation of IParsingControl

        private static ParseControl _instance;
        private StatMonitor _statMonitor;
        private Timeline _timeline;
        private TimelineMonitor _timelineMonitor;

        public static ParseControl Instance
        {
            get { return _instance ?? (_instance = new ParseControl()); }
            set { _instance = value; }
        }

        IParsingControl IParsingControl.Instance
        {
            get { return Instance; }
        }

        public Timeline Timeline
        {
            get { return _timeline ?? (_timeline = new Timeline(this)); }
            set
            {
                _timeline = value;
                RaisePropertyChanged();
            }
        }

        public StatMonitor StatMonitor
        {
            get { return _statMonitor ?? (_statMonitor = new StatMonitor(this)); }
            set
            {
                _statMonitor = value;
                RaisePropertyChanged();
            }
        }

        public TimelineMonitor TimelineMonitor
        {
            get { return _timelineMonitor ?? (_timelineMonitor = new TimelineMonitor(this)); }
            set
            {
                _timelineMonitor = value;
                RaisePropertyChanged();
            }
        }

        public void Initialize()
        {
        }

        public void Reset()
        {
            _parseEntityTimer.Stop();
            _parseEntityTimer.Elapsed -= ParseEntityTimerOnElapsed;
            StartTime = DateTime.Now;
            FirstActionFound = !FirstActionFound;
            StatMonitor.Clear();
            Timeline.Clear();
            TimelineMonitor.Clear();
            var parseEntity = new ParseEntity
            {
                Players = new List<PlayerEntity>()
            };
            AppContextHelper.Instance.RaiseNewParseEntity(parseEntity);
            if (IsHistoryBased)
            {
                return;
            }
            _parseEntityTimer.Elapsed += ParseEntityTimerOnElapsed;
            _parseEntityTimer.Start();
        }

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