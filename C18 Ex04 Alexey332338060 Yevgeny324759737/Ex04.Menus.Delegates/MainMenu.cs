using Ex04.Menus.Delegate;

namespace Ex04.Menus.Delegate
{
    public class MainMenu
    {
        private readonly MenuItem r_MainMenu = new SubMenu("Delegates Method");

        public void AddSubMenu(MenuItem i_MenuItemToAdd)
        {
            (r_MainMenu as SubMenu).AddItem(i_MenuItemToAdd);
        }



        public void Show()
        {
            if ((r_MainMenu as SubMenu).MenuItemsList.Count > 0)
            {
                r_MainMenu.OnGettingMethod();
            }
        }
    }
}
