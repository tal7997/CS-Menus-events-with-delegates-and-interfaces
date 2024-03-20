﻿using System;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class CurrentDateMenuItem : IMenuItemChoosenlistener
    {
        void IMenuItemChoosenlistener.ReportMenuItemChoosen()
        {
            displayCurrentDate();
        }

        public void ReportMenuItemChoosen()
        {
            displayCurrentDate();
        }
        private static void displayCurrentDate()
        {
            Console.WriteLine(string.Format("Today's date is: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")));
        }
    }
}