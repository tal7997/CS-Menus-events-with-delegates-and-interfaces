namespace Ex04.Menus.Interfaces
{
    public class MainMenu : Menu
    {
        public MainMenu(string i_Title)
        {
            Title = i_Title;
            ExitOrBackOption = "Exit";
        }
    }
}