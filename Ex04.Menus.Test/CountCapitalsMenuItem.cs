using System;
using System.Linq;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class CountCapitalsMenuItem : IMenuItemChoosenlistener
    {
        void IMenuItemChoosenlistener.ReportMenuItemChoosen()
        {
            displayCountCapitalLetter();
        }

        public void ReportMenuItemChoosen()
        {
            displayCountCapitalLetter();
        }

        private void displayCountCapitalLetter()
        {
            string input;
            Console.WriteLine("Please enter your sentence:");
            input = Console.ReadLine();
            Console.WriteLine(String.Format("There are {0} Capital letter in your sentence.", input.Count(char.IsUpper)));
        }
    }
}