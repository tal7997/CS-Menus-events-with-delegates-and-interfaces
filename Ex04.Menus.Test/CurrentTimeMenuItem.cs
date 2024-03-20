using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CurrentTimeMenuItem : IMenuItemChoosenlistener
    {
        void IMenuItemChoosenlistener.ReportMenuItemChoosen()
        {
            displayCurrentTime();
        }

        public void ReportMenuItemChoosen()
        {
            displayCurrentTime();
        }

        private static void displayCurrentTime()
        {
            Console.WriteLine(string.Format("The Hour is: {0}", DateTime.Now.ToString("HH:mm:ss")));
        }
    }
}