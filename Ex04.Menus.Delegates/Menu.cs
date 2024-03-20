using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public abstract class Menu
    {
        private const string k_Separation = "---------------------";
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        private string m_Title;
        private string m_ExitOrBackOption = null;
        private Menu m_PreMenu;

        public List<MenuItem> MenuItems
        {
            get { return r_MenuItems; }
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public string ExitOrBackOption
        {
            get { return m_ExitOrBackOption; }
            set { m_ExitOrBackOption = value; }
        }

        public Menu PreMenu
        {
            get { return m_PreMenu; }
            set { m_PreMenu = value; }
        }

        public void AddMenuItem(MenuItem i_Item)
        {
            if (i_Item != null)
            {
                r_MenuItems.Add(i_Item);
            }
        }

        public void RemoveMenuItem(MenuItem i_Item)
        {
            if (i_Item != null)
            {
                r_MenuItems.Remove(i_Item);
            }
        }

        public void Show()
        {
            int userInput;
            const bool v_ContinueLoop = true;

            while (v_ContinueLoop)
            {
                ShowTitle();
                Console.WriteLine(k_Separation);

                for (int i = 1; i <= r_MenuItems.Count; i++)
                {
                    Console.WriteLine(string.Format($"{i} -> {r_MenuItems[i - 1]}"));
                }

                Console.WriteLine(string.Format($"0 -> {m_ExitOrBackOption}"));
                Console.WriteLine(k_Separation);

                try
                {
                    EnterYourRequest();
                    userInput = GetUserInput();
                }
                catch (ArgumentException i_Aex)
                {
                    Console.WriteLine(i_Aex.Message);
                    continue;
                }
                catch (FormatException i_Fex)
                {
                    Console.WriteLine(i_Fex.Message);
                    continue;
                }

                break;
            }

            NavigateToNextMenuLevel(userInput);
        }

        public void ShowTitle()
        {
            Console.WriteLine(string.Format($"**{m_Title}**"));
        }

        public void EnterYourRequest()
        {
            Console.WriteLine(string.Format($"Enter your request: (1 to {r_MenuItems.Count} or press 0 to {m_ExitOrBackOption})."));
        }

        public int GetUserInput()
        {
            int answer;

            if (!(int.TryParse(Console.ReadLine(), out answer)))
            {
                throw new FormatException("Invalid Input!");
            }
            else if (answer < 0 || answer > r_MenuItems.Count)
            {
                throw new ArgumentException("Invalid Input!");
            }
            else
            {
                return answer;
            }
        }

        public void NavigateToNextMenuLevel(int i_Input)
        {
            Console.Clear();
            if (i_Input == 0)
            {
                if (PreMenu != null)
                {
                    PreMenu.Show();
                }
            }
            else if (MenuItems[i_Input - 1].MenuItems.Count > 0)
            {
                MenuItems[i_Input - 1].Show();
            }
            else
            {
                MenuItems[i_Input - 1].OnChosen();
                Show();
            }
        }
    }
}