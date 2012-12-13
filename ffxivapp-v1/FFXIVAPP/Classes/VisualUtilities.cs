// FFXIVAPP
// VisualUtilities.cs
//  
// Created by Ryan Wilson.
// Copyright � 2007-2012 Ryan Wilson - All Rights Reserved

#region Usings

using System;
using System.Text;
using System.Windows;
using System.Windows.Media;

#endregion

namespace FFXIVAPP.Classes
{
    public class VisualUtilities
    {
        private string _finalAnswer = "";
        private int _indentDepth;

        /// <summary>
        /// </summary>
        /// <param name="v"> </param>
        public void PrintVisualTree(Visual v)
        {
            string name = null;
            IncreaseIndent();
            var frameworkElement = v as FrameworkElement;
            if (frameworkElement != null)
            {
                name = (frameworkElement).Name;
            }
            Print("Visual Type: " + v.GetType() + (name != null ? ", Name: " + name : ""));
            for (var i = 0; i < VisualTreeHelper.GetChildrenCount(v); i++)
            {
                PrintVisualTree((Visual) VisualTreeHelper.GetChild(v, i));
            }
            DecreaseIndent();
        }

        /// <summary>
        /// </summary>
        /// <param name="obj"> </param>
        public void PrintLogicalTree(Object obj)
        {
            IncreaseIndent();
            if (obj is FrameworkElement)
            {
                var fe = (FrameworkElement) obj;
                Print("Logical Type: " + fe.GetType() + ", Name: " + fe.Name);
                var children = LogicalTreeHelper.GetChildren(fe);
                foreach (var child in children)
                {
                    PrintLogicalTree(child);
                }
            }
            else
            {
                Print("Logical Type: " + obj.GetType());
            }
            DecreaseIndent();
        }

        /// <summary>
        /// </summary>
        /// <param name="line"> </param>
        private void Print(String line)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < _indentDepth; i++)
            {
                builder.Append("\t");
            }
            builder.Append(line);
            _finalAnswer += line + "\n";
        }

        /// <summary>
        /// </summary>
        private void IncreaseIndent()
        {
            _indentDepth++;
        }

        /// <summary>
        /// </summary>
        private void DecreaseIndent()
        {
            _indentDepth--;
        }
    }
}
