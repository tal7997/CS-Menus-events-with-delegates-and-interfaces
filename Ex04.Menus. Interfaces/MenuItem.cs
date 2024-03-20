using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : Menu
    {
        private List<IMenuItemChoosenlistener> m_MenuItemsChoosenlisteners = null;

        public MenuItem(string i_Title, Menu i_PreMenu)
        {
            Title = i_Title;
            PreMenu = i_PreMenu;
            ExitOrBackOption = "Back";
        }

        public void AddListener(IMenuItemChoosenlistener i_Listener)
        {
            if (m_MenuItemsChoosenlisteners == null)
            {
                m_MenuItemsChoosenlisteners = new List<IMenuItemChoosenlistener>();
            }

            m_MenuItemsChoosenlisteners.Add(i_Listener);
        }

        public void RemoveListener(IMenuItemChoosenlistener i_Listener)
        {
            if ( m_MenuItemsChoosenlisteners != null)
            {
                m_MenuItemsChoosenlisteners.Remove(i_Listener);
            }
        }

        public void NotifyAllListeners()
        {
            foreach (IMenuItemChoosenlistener listener in m_MenuItemsChoosenlisteners)
            {
                listener.ReportMenuItemChoosen();
            }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}