using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class VersionMenuItem : IMenuItemChoosenlistener
    {
        void IMenuItemChoosenlistener.ReportMenuItemChoosen()
        {
            displayVersion();
        }

        public void ReportMenuItemChoosen()
        {
            displayVersion();
        }

        private static void displayVersion()
        {
            Console.WriteLine("Version: 24.1.4.9633");
        }
    }
}