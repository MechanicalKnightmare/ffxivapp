// FFXIVAPP
// ChildUtilities.cs
//  
// Created by Ryan Wilson.
// Copyright � 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System.Windows;
using System.Windows.Media;

#endregion

namespace FFXIVAPP.Classes
{
    public class ChildUtilities
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="parent"> </param>
        /// <param name="name"> </param>
        /// <returns> </returns>
        public static T FindChild<T>(DependencyObject parent, string name) where T : DependencyObject
        {
            for (var i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                var controlName = child.GetValue(FrameworkElement.NameProperty) as string;
                if (controlName == name)
                {
                    return child as T;
                }
                var result = FindChild<T>(child, name);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }
    }
}
