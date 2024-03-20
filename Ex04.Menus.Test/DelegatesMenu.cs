using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    static class DelegatesMenu
    {
        public static void buildMainMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu");
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

            CurrentTimeMenuItem            currentTimeListener = new CurrentTimeMenuItem();
            CurrentDateMenuItem            currentDateListener = new CurrentDateMenuItem();
            VersionMenuItem             currentVersionListener = new VersionMenuItem();
            CountCapitalsMenuItem currentCountCapitalsListener = new CountCapitalsMenuItem();

            ItemTime.Chosen          += currentTimeListener.ReportMenuItemChoosen;
            ItemDate.Chosen          += currentDateListener.ReportMenuItemChoosen;
            ItemVersion.Chosen       += currentVersionListener.ReportMenuItemChoosen;
            ItemCountCapitals.Chosen += currentCountCapitalsListener.ReportMenuItemChoosen;

            mainMenu.Show();
        }
    }
}