using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interface;


namespace Ex04.Menus.Test
{
    public class InterfacesTest
    {

        public static MainMenu CollectData()
        {
            MainMenu homeScreen = new MainMenu(null,"Home Screen");
            SubMenu infoSubmenu = new SubMenu(homeScreen, "Show Date/Time");
            SubMenu metaDataAndActions= new SubMenu(homeScreen,"Version and Capitals");

            infoSubmenu.AddMenuUnit(new ActionItem(infoSubmenu, "Show Date", new Helper()));
            infoSubmenu.AddMenuUnit(new ActionItem(infoSubmenu, "Show Time", new Helper()));

            metaDataAndActions.AddMenuUnit(new ActionItem(metaDataAndActions,"Show Version", new Helper()));
            metaDataAndActions.AddMenuUnit(new ActionItem(metaDataAndActions, "Count Capitals", new Helper()));

            homeScreen.AddMenuUnit(infoSubmenu);
            homeScreen.AddMenuUnit(metaDataAndActions);

            return homeScreen;

        }

        public static void RunInterface()
        {
            MainMenu homeScreen = CollectData();
            homeScreen.Navigate();
        }






    }
}
