using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public static class InterfaceMenu
    {
        public static void BuildMainMenu()
        {
            MainMenu mainMenu = new MainMenu("Interfaces Main Menu");
            MenuItem ItemDateOrTime = new MenuItem("Show Date/Time", mainMenu);
            MenuItem ItemVersionAndCapitals = new MenuItem("Version And Capitals", mainMenu);

            mainMenu.AddMenuItem(ItemDateOrTime);
            mainMenu.AddMenuItem(ItemVersionAndCapitals);

            MenuItem ItemDate = new MenuItem("Show Date", ItemDateOrTime);
            MenuItem ItemTime = new MenuItem("Show Time", ItemDateOrTime);
            MenuItem ItemVersion = new MenuItem("Show Version", ItemVersionAndCapitals);
            MenuItem ItemCountCapitals = new MenuItem("Count Capitals", ItemVersionAndCapitals);

            ItemDateOrTime.AddMenuItem(ItemDate);
            ItemDateOrTime.AddMenuItem(ItemTime);

            ItemVersionAndCapitals.AddMenuItem(ItemCountCapitals);
            ItemVersionAndCapitals.AddMenuItem(ItemVersion);

            ItemDate.AddListener(new CurrentDateMenuItem());
            ItemTime.AddListener(new CurrentTimeMenuItem());
            ItemVersion.AddListener(new VersionMenuItem());
            ItemCountCapitals.AddListener(new CountCapitalsMenuItem());

            mainMenu.Show();
        }
    }
}