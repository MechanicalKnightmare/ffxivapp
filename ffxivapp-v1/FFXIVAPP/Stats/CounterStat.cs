// FFXIVAPP
// CounterStat.cs
//  
// Created by Ryan Wilson.
// Copyright � 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System;

#endregion

namespace FFXIVAPP.Stats
{
    public class CounterStat : NumericStat
    {
        /// <summary>
        /// </summary>
        /// <param name="name"> </param>
        /// <param name="value"> </param>
        public CounterStat(String name, Decimal value) : base(name, value) {}

        /// <summary>
        /// </summary>
        /// <param name="name"> </param>
        public CounterStat(String name) : base(name) {}

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public Decimal Increment()
        {
            return Increment(1);
        }

        /// <summary>
        /// </summary>
        /// <param name="amount"> </param>
        /// <returns> </returns>
        private Decimal Increment(Decimal amount)
        {
            Value += amount;
            return Value;
        }
    }
}
