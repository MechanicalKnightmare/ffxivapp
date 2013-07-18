﻿// FFXIVAPP.Plugin.Parse
// French.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2013 Ryan Wilson - All Rights Reserved

#region Usings

using System.Windows;

#endregion

namespace FFXIVAPP.Plugin.Parse.Localization
{
    public abstract class French
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("parse_PLACEHOLDER", "*PH*");
            Dictionary.Add("parse_NameHeader", "Name");
            Dictionary.Add("parse_TotalOverallDamageHeader", "Total");
            Dictionary.Add("parse_RegularDamageHeader", "Reg");
            Dictionary.Add("parse_CriticalDamageHeader", "Crit");
            Dictionary.Add("parse_TotalDamageActionsUsedHeader", "Used");
            Dictionary.Add("parse_DPSHeader", "DPS");
            Dictionary.Add("parse_DamageDOTHeader", "DOT");
            Dictionary.Add("parse_DamageDOTAverageHeader", "DOT Avg");
            Dictionary.Add("parse_DamageRegHitHeader", "Hit");
            Dictionary.Add("parse_DamageRegMissHeader", "Miss");
            Dictionary.Add("parse_DamageRegAccuracyHeader", "Acc");
            Dictionary.Add("parse_DamageRegLowHeader", "Low");
            Dictionary.Add("parse_DamageRegHighHeader", "High");
            Dictionary.Add("parse_DamageRegAverageHeader", "Avg");
            Dictionary.Add("parse_DamageRegModHeader", "Reg Mod");
            Dictionary.Add("parse_DamageRegModAverageHeader", "Reg Mod Avg");
            Dictionary.Add("parse_DamageCritHitHeader", "C.Hit");
            Dictionary.Add("parse_DamageCritPercentHeader", "Crit %");
            Dictionary.Add("parse_DamageCritLowHeader", "C.Low");
            Dictionary.Add("parse_DamageCritHighHeader", "C.High");
            Dictionary.Add("parse_DamageCritAverageHeader", "C.Avg");
            Dictionary.Add("parse_DamageCritModHeader", "Crit Mod");
            Dictionary.Add("parse_DamageCritModAverageHeader", "Crit Mod Avg");
            Dictionary.Add("parse_DamageCounterHeader", "Counter");
            Dictionary.Add("parse_DamageCounterPercentHeader", "Counter %");
            Dictionary.Add("parse_DamageCounterModHeader", "C. Mod");
            Dictionary.Add("parse_DamageCounterModAverageHeader", "C. Mod Avg");
            Dictionary.Add("parse_DamageBlockHeader", "Block");
            Dictionary.Add("parse_DamageBlockPercentHeader", "Block %");
            Dictionary.Add("parse_DamageBlockModHeader", "B. Mod");
            Dictionary.Add("parse_DamageBlockModAverageHeader", "B. Mod Avg");
            Dictionary.Add("parse_DamageParryHeader", "Parry");
            Dictionary.Add("parse_DamageParryPercentHeader", "Parry %");
            Dictionary.Add("parse_DamageParryModHeader", "P. Mod");
            Dictionary.Add("parse_DamageParryModAverageHeader", "P. Mod Avg");
            Dictionary.Add("parse_DamageResistHeader", "Resist");
            Dictionary.Add("parse_DamageResistPercentHeader", "Resist %");
            Dictionary.Add("parse_DamageResistModHeader", "R. Mod");
            Dictionary.Add("parse_DamageResistModAverageHeader", "R. Mod Avg");
            Dictionary.Add("parse_DamageEvadeHeader", "Evade");
            Dictionary.Add("parse_DamageEvadePercentHeader", "Evade %");
            Dictionary.Add("parse_DamageEvadeModHeader", "E. Mod");
            Dictionary.Add("parse_DamageEvadeModAverageHeader", "E. Mod Avg");
            Dictionary.Add("parse_PercentOfTotalOverallDamageHeader", "% of Total");
            Dictionary.Add("parse_PercentOfRegularDamageHeader", "% of Reg");
            Dictionary.Add("parse_PercentOfCriticalDamageHeader", "% of Crit");
            Dictionary.Add("parse_TotalOverallHealingHeader", "Total");
            Dictionary.Add("parse_RegularHealingHeader", "Reg");
            Dictionary.Add("parse_CriticalHealingHeader", "Crit");
            Dictionary.Add("parse_TotalHealingActionsUsedHeader", "Used");
            Dictionary.Add("parse_HPSHeader", "HPS");
            Dictionary.Add("parse_HealingRegHitHeader", "Hit");
            Dictionary.Add("parse_HealingRegLowHeader", "Low");
            Dictionary.Add("parse_HealingRegHighHeader", "High");
            Dictionary.Add("parse_HealingRegAverageHeader", "Avg");
            Dictionary.Add("parse_HealingRegModHeader", "Reg Mod");
            Dictionary.Add("parse_HealingRegModAverageHeader", "Reg Mod Avg");
            Dictionary.Add("parse_HealingCritHitHeader", "C.Hit");
            Dictionary.Add("parse_HealingCritPercentHeader", "Crit %");
            Dictionary.Add("parse_HealingCritLowHeader", "C.Low");
            Dictionary.Add("parse_HealingCritHighHeader", "C.High");
            Dictionary.Add("parse_HealingCritAverageHeader", "C.Avg");
            Dictionary.Add("parse_HealingCritModHeader", "Crit Mod");
            Dictionary.Add("parse_HealingCritModAverageHeader", "Crit Mod Avg");
            Dictionary.Add("parse_PercentOfTotalOverallHealingHeader", "% of Total");
            Dictionary.Add("parse_PercentOfRegularHealingHeader", "% of Reg");
            Dictionary.Add("parse_PercentOfCriticalHealingHeader", "% of Crit");
            Dictionary.Add("parse_TotalOverallDamageTakenHeader", "Total");
            Dictionary.Add("parse_RegularDamageTakenHeader", "Reg");
            Dictionary.Add("parse_CriticalDamageTakenHeader", "Crit");
            Dictionary.Add("parse_TotalDamageTakenActionsUsedHeader", "Used");
            Dictionary.Add("parse_DTPSHeader", "DTPS");
            Dictionary.Add("parse_DamageTakenDOTHeader", "DOT");
            Dictionary.Add("parse_DamageTakenDOTAverageHeader", "DOT Avg");
            Dictionary.Add("parse_DamageTakenRegHitHeader", "Hit");
            Dictionary.Add("parse_DamageTakenRegMissHeader", "Miss");
            Dictionary.Add("parse_DamageTakenRegAccuracyHeader", "Acc");
            Dictionary.Add("parse_DamageTakenRegLowHeader", "Low");
            Dictionary.Add("parse_DamageTakenRegHighHeader", "High");
            Dictionary.Add("parse_DamageTakenRegAverageHeader", "Avg");
            Dictionary.Add("parse_DamageTakenRegModHeader", "Reg Mod");
            Dictionary.Add("parse_DamageTakenRegModAverageHeader", "Reg Mod Avg");
            Dictionary.Add("parse_DamageTakenCritHitHeader", "C.Hit");
            Dictionary.Add("parse_DamageTakenCritPercentHeader", "Crit %");
            Dictionary.Add("parse_DamageTakenCritLowHeader", "C.Low");
            Dictionary.Add("parse_DamageTakenCritHighHeader", "C.High");
            Dictionary.Add("parse_DamageTakenCritAverageHeader", "C.Avg");
            Dictionary.Add("parse_DamageTakenCritModHeader", "Crit Mod");
            Dictionary.Add("parse_DamageTakenCritModAverageHeader", "Crit Mod Avg");
            Dictionary.Add("parse_DamageTakenCounterHeader", "Counter");
            Dictionary.Add("parse_DamageTakenCounterPercentHeader", "Counter %");
            Dictionary.Add("parse_DamageTakenCounterModHeader", "C. Mod");
            Dictionary.Add("parse_DamageTakenCounterModAverageHeader", "C. Mod Avg");
            Dictionary.Add("parse_DamageTakenBlockHeader", "Block");
            Dictionary.Add("parse_DamageTakenBlockPercentHeader", "Block %");
            Dictionary.Add("parse_DamageTakenBlockModHeader", "B. Mod");
            Dictionary.Add("parse_DamageTakenBlockModAverageHeader", "B. Mod Avg");
            Dictionary.Add("parse_DamageTakenParryHeader", "Parry");
            Dictionary.Add("parse_DamageTakenParryPercentHeader", "Parry %");
            Dictionary.Add("parse_DamageTakenParryModHeader", "P. Mod");
            Dictionary.Add("parse_DamageTakenParryModAverageHeader", "P. Mod Avg");
            Dictionary.Add("parse_DamageTakenResistHeader", "Resist");
            Dictionary.Add("parse_DamageTakenResistPercentHeader", "Resist %");
            Dictionary.Add("parse_DamageTakenResistModHeader", "R. Mod");
            Dictionary.Add("parse_DamageTakenResistModAverageHeader", "R. Mod Avg");
            Dictionary.Add("parse_DamageTakenEvadeHeader", "Evade");
            Dictionary.Add("parse_DamageTakenEvadePercentHeader", "Evade %");
            Dictionary.Add("parse_DamageTakenEvadeModHeader", "E. Mod");
            Dictionary.Add("parse_DamageTakenEvadeModAverageHeader", "E. Mod Avg");
            Dictionary.Add("parse_PercentOfTotalOverallDamageTakenHeader", "% of Total");
            Dictionary.Add("parse_PercentOfRegularDamageTakenHeader", "% of Reg");
            Dictionary.Add("parse_PercentOfCriticalDamageTakenHeader", "% of Crit");
            Dictionary.Add("parse_BasicTabHeader", "Basique");
            Dictionary.Add("parse_ActionLogTabHeader", "Log d'action");
            Dictionary.Add("parse_PartyDamageTabHeader", "Dégâts de l'équipe");
            Dictionary.Add("parse_PartyHealingTabHeader", "Soins de l'équipe");
            Dictionary.Add("parse_PartyDamageTakenTabHeader", "Dégâts subis par l'équipe");
            Dictionary.Add("parse_MonsterDamageTabHeader", "Dégâts des monstres");
            Dictionary.Add("parse_MonsterHealingTabHeader", "Soins des monstres");
            Dictionary.Add("parse_MonsterDamageTakenTabHeader", "Dégâts subis par les monstres");
            Dictionary.Add("parse_ResetStatsToolTip", "Réinitialiser les stats");
            Dictionary.Add("parse_ShowActionLogHeader", "Afficher le log d'action");
            Dictionary.Add("parse_ShowPartyDamageHeader", "Afficher les dégâts de l'équipe");
            Dictionary.Add("parse_ShowPartyHealingHeader", "Afficher les soins de l'équipe");
            Dictionary.Add("parse_ShowPartyDamageTakenHeader", "Afficher les dégâts subis par l'équipe");
            Dictionary.Add("parse_ShowMonsterDamageHeader", "Afficher les dégâts par les monstres");
            Dictionary.Add("parse_ShowMonsterHealingHeader", "Afficher les soins par les monstres");
            Dictionary.Add("parse_ShowMonsterDamageTakenHeader", "Afficher les dégâts subis par les monstres");
            Dictionary.Add("parse_UploadParseHeader", "Upload le parse");
            Dictionary.Add("parse_ExportXMLHeader", "Exporter XML");
            Dictionary.Add("parse_PlayerDamageByActionText", "Dégâts  par action par joueur sélectionné");
            Dictionary.Add("parse_PlayerDamageToMonstersText", "Dégâts infligés aux monstres par joueur sélectionné ");
            Dictionary.Add("parse_PlayerDamageToMonstersByActionText", "Dégâts infligés aux monstres par action par joueur sélectionné");
            Dictionary.Add("parse_PlayerHealingByActionText", "Soins octroyés par action par joueur sélectionné");
            Dictionary.Add("parse_PlayerHealingToPlayersText", "Soins octroyés aux joueurs par joueur sélectionné");
            Dictionary.Add("parse_PlayerHealingToPlayersByActionText", "Soins octroyés aux joueurs par action par joueur sélectionné");
            Dictionary.Add("parse_PlayerDamageTakenByActionText", "Dégâts infligés par les monstres par action par joueur sélectionné");
            Dictionary.Add("parse_PlayerDamageTakenByMonstersText", "Dégâts infligés par les monstres par joueur sélectionné");
            Dictionary.Add("parse_PlayerDamageTakenByMonstersByActionText", "Dégâts infligés par les monstres par action par monstre sélectionné par joueur sélectionné");
            Dictionary.Add("parse_MonsterDamageByActionText", "Dégâts par action par monstre sélectionné");
            Dictionary.Add("parse_MonsterDamageToPlayersText", "Dégâts infligés aux joueurs par monstre sélectionné");
            Dictionary.Add("parse_MonsterDamageToPlayersByActionText", "Dégâts infligés aux joueurs par action par monstre sélectionné");
            Dictionary.Add("parse_MonsterHealingByActionText", "Soins par action par monstre sélectionné");
            Dictionary.Add("parse_MonsterHealingToMonstersText", "Soins octroyés aux monstres par monstre sélectionné");
            Dictionary.Add("parse_MonsterHealingToMonstersByActionText", "Soins octroyés aux monstres par action par monstre sélectionné");
            Dictionary.Add("parse_MonsterDamageTakenByActionText", "Dégâts infligés par action par monstre sélectionné");
            Dictionary.Add("parse_MonsterDamageTakenByPlayersText", "Dégâts infligés par les joueurs par action par monstre sélectionné");
            Dictionary.Add("parse_MonsterDamageTakenByPlayersByActionText", "Dégâts infligés par les joueurs par action par joueur sélectionné par monstre sélectionné");
            Dictionary.Add("parse_MonsterDropsByMonsterText", "Butin par monstre sélectionné");
            Dictionary.Add("parse_TotalOverallDropsHeader", "Drops");
            Dictionary.Add("parse_TotalKilledHeader", "Killed");
            Dictionary.Add("parse_AverageHPHeader", "Avg HP");
            Dictionary.Add("parse_TotalDropsHeader", "Total");
            Dictionary.Add("parse_DropPercentHeader", "Drop %");
            Dictionary.Add("parse_ResetStatsMessage", "Souhaitez-vous réinitialiser et supprimer toutes vos stats actuelles ?");
            Dictionary.Add("parse_ColumnDisplaySettingsTabHeader", "Paramètres d'affichage des colonnes");
            Dictionary.Add("parse_BasicDisplaySettingsTabHeader", "Paramètres d'affichage de Basique");
            Dictionary.Add("parse_TotalOverallDamageLabel", "Total Overall Damage:");
            Dictionary.Add("parse_RegularDamageLabel", "Regular Damage:");
            Dictionary.Add("parse_CriticalDamageLabel", "Critical Damage:");
            Dictionary.Add("parse_TotalDamageActionsUsedLabel", "Total Damage Actions Used:");
            Dictionary.Add("parse_DPSLabel", "DPS:");
            Dictionary.Add("parse_DamageDOTLabel", "Damage DOT:");
            Dictionary.Add("parse_DamageDOTAverageLabel", "Damage DOT Average:");
            Dictionary.Add("parse_DamageRegHitLabel", "Damage Reg Hit:");
            Dictionary.Add("parse_DamageRegMissLabel", "Damage Reg Miss:");
            Dictionary.Add("parse_DamageRegAccuracyLabel", "Damage Reg Accuracy:");
            Dictionary.Add("parse_DamageRegLowLabel", "Damage Reg Low:");
            Dictionary.Add("parse_DamageRegHighLabel", "Damage Reg High:");
            Dictionary.Add("parse_DamageRegAverageLabel", "Damage Reg Average:");
            Dictionary.Add("parse_DamageRegModLabel", "Damage Reg Mod:");
            Dictionary.Add("parse_DamageRegModAverageLabel", "Damage Reg Mod Average:");
            Dictionary.Add("parse_DamageCritHitLabel", "Damage Crit Hit:");
            Dictionary.Add("parse_DamageCritPercentLabel", "Damage Crit Percent:");
            Dictionary.Add("parse_DamageCritLowLabel", "Damage Crit Low:");
            Dictionary.Add("parse_DamageCritHighLabel", "Damage Crit High:");
            Dictionary.Add("parse_DamageCritAverageLabel", "Damage Crit Average:");
            Dictionary.Add("parse_DamageCritModLabel", "Damage Crit Mod:");
            Dictionary.Add("parse_DamageCritModAverageLabel", "Damage Crit Mod Average:");
            Dictionary.Add("parse_DamageCounterLabel", "Damage Counter:");
            Dictionary.Add("parse_DamageCounterPercentLabel", "Damage Counter Percent:");
            Dictionary.Add("parse_DamageCounterModLabel", "Damage Counter Mod:");
            Dictionary.Add("parse_DamageCounterModAverageLabel", "Damage Counter Mod Average:");
            Dictionary.Add("parse_DamageBlockLabel", "Damage Block:");
            Dictionary.Add("parse_DamageBlockPercentLabel", "Damage Block Percent:");
            Dictionary.Add("parse_DamageBlockModLabel", "Damage Block Mod:");
            Dictionary.Add("parse_DamageBlockModAverageLabel", "Damage Block Mod Average:");
            Dictionary.Add("parse_DamageParryLabel", "Damage Parry:");
            Dictionary.Add("parse_DamageParryPercentLabel", "Damage Parry Percent:");
            Dictionary.Add("parse_DamageParryModLabel", "Damage Parry Mod:");
            Dictionary.Add("parse_DamageParryModAverageLabel", "Damage Parry Mod Average:");
            Dictionary.Add("parse_DamageResistLabel", "Damage Resist:");
            Dictionary.Add("parse_DamageResistPercentLabel", "Damage Resist Percent:");
            Dictionary.Add("parse_DamageResistModLabel", "Damage Resist Mod:");
            Dictionary.Add("parse_DamageResistModAverageLabel", "Damage Resist Mod Average:");
            Dictionary.Add("parse_DamageEvadeLabel", "Damage Evade:");
            Dictionary.Add("parse_DamageEvadePercentLabel", "Damage Evade Percent:");
            Dictionary.Add("parse_DamageEvadeModLabel", "Damage Evade Mod:");
            Dictionary.Add("parse_DamageEvadeModAverageLabel", "Damage Evade Mod Average:");
            Dictionary.Add("parse_PercentOfTotalOverallDamageLabel", "Percent Of Total Overall Damage:");
            Dictionary.Add("parse_PercentOfRegularDamageLabel", "Percent Of Regular Damage:");
            Dictionary.Add("parse_PercentOfCriticalDamageLabel", "Percent Of Critical Damage:");
            Dictionary.Add("parse_TotalOverallHealingLabel", "Total Overall Healing:");
            Dictionary.Add("parse_RegularHealingLabel", "Regular Healing:");
            Dictionary.Add("parse_CriticalHealingLabel", "Critical Healing:");
            Dictionary.Add("parse_TotalHealingActionsUsedLabel", "Total Healing Actions Used:");
            Dictionary.Add("parse_HPSLabel", "HPS:");
            Dictionary.Add("parse_HealingRegHitLabel", "Healing Reg Hit:");
            Dictionary.Add("parse_HealingRegLowLabel", "Healing Reg Low:");
            Dictionary.Add("parse_HealingRegHighLabel", "Healing Reg High:");
            Dictionary.Add("parse_HealingRegAverageLabel", "Healing Reg Average:");
            Dictionary.Add("parse_HealingRegModLabel", "Healing Reg Mod:");
            Dictionary.Add("parse_HealingRegModAverageLabel", "Healing Reg Mod Average:");
            Dictionary.Add("parse_HealingCritHitLabel", "Healing Crit Hit:");
            Dictionary.Add("parse_HealingCritPercentLabel", "Healing Crit Percent:");
            Dictionary.Add("parse_HealingCritLowLabel", "Healing Crit Low:");
            Dictionary.Add("parse_HealingCritHighLabel", "Healing Crit High:");
            Dictionary.Add("parse_HealingCritAverageLabel", "Healing Crit Average:");
            Dictionary.Add("parse_HealingCritModLabel", "Healing Crit Mod:");
            Dictionary.Add("parse_HealingCritModAverageLabel", "Healing Crit Mod Average:");
            Dictionary.Add("parse_PercentOfTotalOverallHealingLabel", "Percent Of Total Overall Healing:");
            Dictionary.Add("parse_PercentOfRegularHealingLabel", "Percent Of Regular Healing:");
            Dictionary.Add("parse_PercentOfCriticalHealingLabel", "Percent Of Critical Healing:");
            Dictionary.Add("parse_TotalOverallDamageTakenLabel", "Total Overall Damage Taken:");
            Dictionary.Add("parse_RegularDamageTakenLabel", "Regular Damage Taken:");
            Dictionary.Add("parse_CriticalDamageTakenLabel", "Critical Damage Taken:");
            Dictionary.Add("parse_TotalDamageTakenActionsUsedLabel", "Total Damage Taken Actions Used:");
            Dictionary.Add("parse_DTPSLabel", "DTPS:");
            Dictionary.Add("parse_DamageTakenDOTLabel", "Damage Taken DOT:");
            Dictionary.Add("parse_DamageTakenDOTAverageLabel", "Damage Taken DOT Average:");
            Dictionary.Add("parse_DamageTakenRegHitLabel", "Damage Taken Reg Hit:");
            Dictionary.Add("parse_DamageTakenRegMissLabel", "Damage Taken Reg Miss:");
            Dictionary.Add("parse_DamageTakenRegAccuracyLabel", "Damage Taken Reg Accuracy:");
            Dictionary.Add("parse_DamageTakenRegLowLabel", "Damage Taken Reg Low:");
            Dictionary.Add("parse_DamageTakenRegHighLabel", "Damage Taken Reg High:");
            Dictionary.Add("parse_DamageTakenRegAverageLabel", "Damage Taken Reg Average:");
            Dictionary.Add("parse_DamageTakenRegModLabel", "Damage Taken Reg Mod:");
            Dictionary.Add("parse_DamageTakenRegModAverageLabel", "Damage Taken Reg Mod Average:");
            Dictionary.Add("parse_DamageTakenCritHitLabel", "Damage Taken Crit Hit:");
            Dictionary.Add("parse_DamageTakenCritPercentLabel", "Damage Taken Crit Percent:");
            Dictionary.Add("parse_DamageTakenCritLowLabel", "Damage Taken Crit Low:");
            Dictionary.Add("parse_DamageTakenCritHighLabel", "Damage Taken Crit High:");
            Dictionary.Add("parse_DamageTakenCritAverageLabel", "Damage Taken Crit Average:");
            Dictionary.Add("parse_DamageTakenCritModLabel", "Damage Taken Crit Mod:");
            Dictionary.Add("parse_DamageTakenCritModAverageLabel", "Damage Taken Crit Mod Average:");
            Dictionary.Add("parse_DamageTakenCounterLabel", "Damage Taken Counter:");
            Dictionary.Add("parse_DamageTakenCounterPercentLabel", "Damage Taken Counter Percent:");
            Dictionary.Add("parse_DamageTakenCounterModLabel", "Damage Taken Counter Mod:");
            Dictionary.Add("parse_DamageTakenCounterModAverageLabel", "Damage Taken Counter Mod Average:");
            Dictionary.Add("parse_DamageTakenBlockLabel", "Damage Taken Block:");
            Dictionary.Add("parse_DamageTakenBlockPercentLabel", "Damage Taken Block Percent:");
            Dictionary.Add("parse_DamageTakenBlockModLabel", "Damage Taken Block Mod:");
            Dictionary.Add("parse_DamageTakenBlockModAverageLabel", "Damage Taken Block Mod Average:");
            Dictionary.Add("parse_DamageTakenParryLabel", "Damage Taken Parry:");
            Dictionary.Add("parse_DamageTakenParryPercentLabel", "Damage Taken Parry Percent:");
            Dictionary.Add("parse_DamageTakenParryModLabel", "Damage Taken Parry Mod:");
            Dictionary.Add("parse_DamageTakenParryModAverageLabel", "Damage Taken Parry Mod Average:");
            Dictionary.Add("parse_DamageTakenResistLabel", "Damage Taken Resist:");
            Dictionary.Add("parse_DamageTakenResistPercentLabel", "Damage Taken Resist Percent:");
            Dictionary.Add("parse_DamageTakenResistModLabel", "Damage Taken Resist Mod:");
            Dictionary.Add("parse_DamageTakenResistModAverageLabel", "Damage Taken Resist Mod Average:");
            Dictionary.Add("parse_DamageTakenEvadeLabel", "Damage Taken Evade:");
            Dictionary.Add("parse_DamageTakenEvadePercentLabel", "Damage Taken Evade Percent:");
            Dictionary.Add("parse_DamageTakenEvadeModLabel", "Damage Taken Evade Mod:");
            Dictionary.Add("parse_DamageTakenEvadeModAverageLabel", "Damage Taken Evade Mod Average:");
            Dictionary.Add("parse_PercentOfTotalOverallDamageTakenLabel", "Percent Of Total Overall Damage Taken:");
            Dictionary.Add("parse_PercentOfRegularDamageTakenLabel", "Percent Of Regular Damage Taken:");
            Dictionary.Add("parse_PercentOfCriticalDamageTakenLabel", "Percent Of Critical Damage Taken:");
            Dictionary.Add("parse_ShowTotalOverallDamageInfoHeader", "Show Total Overall Damage Information");
            Dictionary.Add("parse_ShowRegularDamageInfoHeader", "Show Regular Damage Information");
            Dictionary.Add("parse_ShowCriticalDamageInfoHeader", "Show Critical Damage Information");
            Dictionary.Add("parse_ShowTotalDamageActionsUsedInfoHeader", "Show Total Damage Actions Used Information");
            Dictionary.Add("parse_ShowDPSInfoHeader", "Show DPS Information");
            Dictionary.Add("parse_ShowDamageDOTInfoHeader", "Show Damage DOT Information");
            Dictionary.Add("parse_ShowDamageDOTAverageInfoHeader", "Show Damage DOT Average Information");
            Dictionary.Add("parse_ShowDamageRegHitInfoHeader", "Show Damage Reg Hit Information");
            Dictionary.Add("parse_ShowDamageRegMissInfoHeader", "Show Damage Reg Miss Information");
            Dictionary.Add("parse_ShowDamageRegAccuracyInfoHeader", "Show Damage Reg Accuracy Information");
            Dictionary.Add("parse_ShowDamageRegLowInfoHeader", "Show Damage Reg Low Information");
            Dictionary.Add("parse_ShowDamageRegHighInfoHeader", "Show Damage Reg High Information");
            Dictionary.Add("parse_ShowDamageRegAverageInfoHeader", "Show Damage Reg Average Information");
            Dictionary.Add("parse_ShowDamageRegModInfoHeader", "Show Damage Reg Mod Information");
            Dictionary.Add("parse_ShowDamageRegModAverageInfoHeader", "Show Damage Reg Mod Average Information");
            Dictionary.Add("parse_ShowDamageCritHitInfoHeader", "Show Damage Crit Hit Information");
            Dictionary.Add("parse_ShowDamageCritPercentInfoHeader", "Show Damage Crit Percent Information");
            Dictionary.Add("parse_ShowDamageCritLowInfoHeader", "Show Damage Crit Low Information");
            Dictionary.Add("parse_ShowDamageCritHighInfoHeader", "Show Damage Crit High Information");
            Dictionary.Add("parse_ShowDamageCritAverageInfoHeader", "Show Damage Crit Average Information");
            Dictionary.Add("parse_ShowDamageCritModInfoHeader", "Show Damage Crit Mod Information");
            Dictionary.Add("parse_ShowDamageCritModAverageInfoHeader", "Show Damage Crit Mod Average Information");
            Dictionary.Add("parse_ShowDamageCounterInfoHeader", "Show Damage Counter Information");
            Dictionary.Add("parse_ShowDamageCounterPercentInfoHeader", "Show Damage Counter Percent Information");
            Dictionary.Add("parse_ShowDamageCounterModInfoHeader", "Show Damage Counter Mod Information");
            Dictionary.Add("parse_ShowDamageCounterModAverageInfoHeader", "Show Damage Counter Mod Average Information");
            Dictionary.Add("parse_ShowDamageBlockInfoHeader", "Show Damage Block Information");
            Dictionary.Add("parse_ShowDamageBlockPercentInfoHeader", "Show Damage Block Percent Information");
            Dictionary.Add("parse_ShowDamageBlockModInfoHeader", "Show Damage Block Mod Information");
            Dictionary.Add("parse_ShowDamageBlockModAverageInfoHeader", "Show Damage Block Mod Average Information");
            Dictionary.Add("parse_ShowDamageParryInfoHeader", "Show Damage Parry Information");
            Dictionary.Add("parse_ShowDamageParryPercentInfoHeader", "Show Damage Parry Percent Information");
            Dictionary.Add("parse_ShowDamageParryModInfoHeader", "Show Damage Parry Mod Information");
            Dictionary.Add("parse_ShowDamageParryModAverageInfoHeader", "Show Damage Parry Mod Average Information");
            Dictionary.Add("parse_ShowDamageResistInfoHeader", "Show Damage Resist Information");
            Dictionary.Add("parse_ShowDamageResistPercentInfoHeader", "Show Damage Resist Percent Information");
            Dictionary.Add("parse_ShowDamageResistModInfoHeader", "Show Damage Resist Mod Information");
            Dictionary.Add("parse_ShowDamageResistModAverageInfoHeader", "Show Damage Resist Mod Average Information");
            Dictionary.Add("parse_ShowDamageEvadeInfoHeader", "Show Damage Evade Information");
            Dictionary.Add("parse_ShowDamageEvadePercentInfoHeader", "Show Damage Evade Percent Information");
            Dictionary.Add("parse_ShowDamageEvadeModInfoHeader", "Show Damage Evade Mod Information");
            Dictionary.Add("parse_ShowDamageEvadeModAverageInfoHeader", "Show Damage Evade Mod Average Information");
            Dictionary.Add("parse_ShowPercentOfTotalOverallDamageInfoHeader", "Show Percent Of Total Overall Damage Information");
            Dictionary.Add("parse_ShowPercentOfRegularDamageInfoHeader", "Show Percent Of Regular Damage Information");
            Dictionary.Add("parse_ShowPercentOfCriticalDamageInfoHeader", "Show Percent Of Critical Damage Information");
            Dictionary.Add("parse_ShowTotalOverallHealingInfoHeader", "Show Total Overall Healing Information");
            Dictionary.Add("parse_ShowRegularHealingInfoHeader", "Show Regular Healing Information");
            Dictionary.Add("parse_ShowCriticalHealingInfoHeader", "Show Critical Healing Information");
            Dictionary.Add("parse_ShowTotalHealingActionsUsedInfoHeader", "Show Total Healing Actions Used Information");
            Dictionary.Add("parse_ShowHPSInfoHeader", "Show HPS Information");
            Dictionary.Add("parse_ShowHealingRegHitInfoHeader", "Show Healing Reg Hit Information");
            Dictionary.Add("parse_ShowHealingRegLowInfoHeader", "Show Healing Reg Low Information");
            Dictionary.Add("parse_ShowHealingRegHighInfoHeader", "Show Healing Reg High Information");
            Dictionary.Add("parse_ShowHealingRegAverageInfoHeader", "Show Healing Reg Average Information");
            Dictionary.Add("parse_ShowHealingRegModInfoHeader", "Show Healing Reg Mod Information");
            Dictionary.Add("parse_ShowHealingRegModAverageInfoHeader", "Show Healing Reg Mod Average Information");
            Dictionary.Add("parse_ShowHealingCritHitInfoHeader", "Show Healing Crit Hit Information");
            Dictionary.Add("parse_ShowHealingCritPercentInfoHeader", "Show Healing Crit Percent Information");
            Dictionary.Add("parse_ShowHealingCritLowInfoHeader", "Show Healing Crit Low Information");
            Dictionary.Add("parse_ShowHealingCritHighInfoHeader", "Show Healing Crit High Information");
            Dictionary.Add("parse_ShowHealingCritAverageInfoHeader", "Show Healing Crit Average Information");
            Dictionary.Add("parse_ShowHealingCritModInfoHeader", "Show Healing Crit Mod Information");
            Dictionary.Add("parse_ShowHealingCritModAverageInfoHeader", "Show Healing Crit Mod Average Information");
            Dictionary.Add("parse_ShowPercentOfTotalOverallHealingInfoHeader", "Show Percent Of Total Overall Healing Information");
            Dictionary.Add("parse_ShowPercentOfRegularHealingInfoHeader", "Show Percent Of Regular Healing Information");
            Dictionary.Add("parse_ShowPercentOfCriticalHealingInfoHeader", "Show Percent Of Critical Healing Information");
            Dictionary.Add("parse_ShowTotalOverallDamageTakenInfoHeader", "Show Total Overall Damage Taken Information");
            Dictionary.Add("parse_ShowRegularDamageTakenInfoHeader", "Show Regular Damage Taken Information");
            Dictionary.Add("parse_ShowCriticalDamageTakenInfoHeader", "Show Critical Damage Taken Information");
            Dictionary.Add("parse_ShowTotalDamageTakenActionsUsedInfoHeader", "Show Total Damage Taken Actions Used Information");
            Dictionary.Add("parse_ShowDTPSInfoHeader", "Show DTPS Information");
            Dictionary.Add("parse_ShowDamageTakenDOTInfoHeader", "Show Damage Taken DOT Information");
            Dictionary.Add("parse_ShowDamageTakenDOTAverageInfoHeader", "Show Damage Taken DOT Average Information");
            Dictionary.Add("parse_ShowDamageTakenRegHitInfoHeader", "Show Damage Taken Reg Hit Information");
            Dictionary.Add("parse_ShowDamageTakenRegMissInfoHeader", "Show Damage Taken Reg Miss Information");
            Dictionary.Add("parse_ShowDamageTakenRegAccuracyInfoHeader", "Show Damage Taken Reg Accuracy Information");
            Dictionary.Add("parse_ShowDamageTakenRegLowInfoHeader", "Show Damage Taken Reg Low Information");
            Dictionary.Add("parse_ShowDamageTakenRegHighInfoHeader", "Show Damage Taken Reg High Information");
            Dictionary.Add("parse_ShowDamageTakenRegAverageInfoHeader", "Show Damage Taken Reg Average Information");
            Dictionary.Add("parse_ShowDamageTakenRegModInfoHeader", "Show Damage Taken Reg Mod Information");
            Dictionary.Add("parse_ShowDamageTakenRegModAverageInfoHeader", "Show Damage Taken Reg Mod Average Information");
            Dictionary.Add("parse_ShowDamageTakenCritHitInfoHeader", "Show Damage Taken Crit Hit Information");
            Dictionary.Add("parse_ShowDamageTakenCritPercentInfoHeader", "Show Damage Taken Crit Percent Information");
            Dictionary.Add("parse_ShowDamageTakenCritLowInfoHeader", "Show Damage Taken Crit Low Information");
            Dictionary.Add("parse_ShowDamageTakenCritHighInfoHeader", "Show Damage Taken Crit High Information");
            Dictionary.Add("parse_ShowDamageTakenCritAverageInfoHeader", "Show Damage Taken Crit Average Information");
            Dictionary.Add("parse_ShowDamageTakenCritModInfoHeader", "Show Damage Taken Crit Mod Information");
            Dictionary.Add("parse_ShowDamageTakenCritModAverageInfoHeader", "Show Damage Taken Crit Mod Average Information");
            Dictionary.Add("parse_ShowDamageTakenCounterInfoHeader", "Show Damage Taken Counter Information");
            Dictionary.Add("parse_ShowDamageTakenCounterPercentInfoHeader", "Show Damage Taken Counter Percent Information");
            Dictionary.Add("parse_ShowDamageTakenCounterModInfoHeader", "Show Damage Taken Counter Mod Information");
            Dictionary.Add("parse_ShowDamageTakenCounterModAverageInfoHeader", "Show Damage Taken Counter Mod Average Information");
            Dictionary.Add("parse_ShowDamageTakenBlockInfoHeader", "Show Damage Taken Block Information");
            Dictionary.Add("parse_ShowDamageTakenBlockPercentInfoHeader", "Show Damage Taken Block Percent Information");
            Dictionary.Add("parse_ShowDamageTakenBlockModInfoHeader", "Show Damage Taken Block Mod Information");
            Dictionary.Add("parse_ShowDamageTakenBlockModAverageInfoHeader", "Show Damage Taken Block Mod Average Information");
            Dictionary.Add("parse_ShowDamageTakenParryInfoHeader", "Show Damage Taken Parry Information");
            Dictionary.Add("parse_ShowDamageTakenParryPercentInfoHeader", "Show Damage Taken Parry Percent Information");
            Dictionary.Add("parse_ShowDamageTakenParryModInfoHeader", "Show Damage Taken Parry Mod Information");
            Dictionary.Add("parse_ShowDamageTakenParryModAverageInfoHeader", "Show Damage Taken Parry Mod Average Information");
            Dictionary.Add("parse_ShowDamageTakenResistInfoHeader", "Show Damage Taken Resist Information");
            Dictionary.Add("parse_ShowDamageTakenResistPercentInfoHeader", "Show Damage Taken Resist Percent Information");
            Dictionary.Add("parse_ShowDamageTakenResistModInfoHeader", "Show Damage Taken Resist Mod Information");
            Dictionary.Add("parse_ShowDamageTakenResistModAverageInfoHeader", "Show Damage Taken Resist Mod Average Information");
            Dictionary.Add("parse_ShowDamageTakenEvadeInfoHeader", "Show Damage Taken Evade Information");
            Dictionary.Add("parse_ShowDamageTakenEvadePercentInfoHeader", "Show Damage Taken Evade Percent Information");
            Dictionary.Add("parse_ShowDamageTakenEvadeModInfoHeader", "Show Damage Taken Evade Mod Information");
            Dictionary.Add("parse_ShowDamageTakenEvadeModAverageInfoHeader", "Show Damage Taken Evade Mod Average Information");
            Dictionary.Add("parse_ShowPercentOfTotalOverallDamageTakenInfoHeader", "Show Percent Of Total Overall Damage Taken Information");
            Dictionary.Add("parse_ShowPercentOfRegularDamageTakenInfoHeader", "Show Percent Of Regular Damage Taken Information");
            Dictionary.Add("parse_ShowPercentOfCriticalDamageTakenInfoHeader", "Show Percent Of Critical Damage Taken Information");
            Dictionary.Add("parse_LoadExistingLogFileButtonText", "Charger un fichier Log existant");
            return Dictionary;
        }
    }
}
