using System;

namespace Ex04.Menus.Delegates
{
    public class MenuItem : Menu
    {
        public event Action Chosen;

        public MenuItem(string i_Title, Menu i_PreMenu = null)
        {
            Title = i_Title;
            PreMenu = i_PreMenu;
            ExitOrBackOption = "Back";
        }

        public override string ToString()
        {
            return Title;
        }

        public void OnChosen()
        {
            if (Chosen != null)
            {
                Chosen.Invoke();
            }
        }
    }
}