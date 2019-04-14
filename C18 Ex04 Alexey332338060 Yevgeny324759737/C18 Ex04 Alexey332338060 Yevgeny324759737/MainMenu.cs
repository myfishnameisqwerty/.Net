using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public class MainMenu : MenuUnit, IBackOrQuit
    {

        private readonly List<MenuUnit> r_Menu;
        protected MenuUnit m_CurrentItem;


        public MainMenu(MainMenu i_Father, string i_Title) : base(i_Father, i_Title)
        {
            r_Menu = new List<MenuUnit>();
            m_CurrentItem = this;
        }


        public List<MenuUnit> Menu
        {
            get { return r_Menu; }
        }


        public void AddMenuUnit(MenuUnit i_UnitToAdd)
        {
            r_Menu.Add(i_UnitToAdd);
        }

        public void RemoveMenuUnit(MenuUnit i_UnitToRemove)
        {
            r_Menu.Remove(i_UnitToRemove);

        }

        public void Navigate()
        {
            int userChoice;
            MenuScreen();

            do
            {
                ChooseYourOption(out userChoice);

                if (userChoice != 0)
                {
                    m_CurrentItem = (m_CurrentItem as MainMenu).Menu.ElementAt(userChoice - 1);
                    EnfoldOrTrigger();
                }

                else
                    GoBack();
            } while (true);
        }

        private void EnfoldOrTrigger()
        {
            SubMenu subList = m_CurrentItem as SubMenu;

            if (subList != null)
            {
                m_CurrentItem = subList;
                subList.MenuScreen();

            }
            else
            {
                ActionItem trigger = m_CurrentItem as ActionItem;

                if (trigger != null)
                {
                    m_CurrentItem = trigger;
                    trigger.Action.Invoke(trigger.Title);
                    Continue();
                    GoBack();
                }
            }
        }


        public void GoBack()
        {

            if (m_CurrentItem.Ancestor != null)
            {
                m_CurrentItem.Ancestor.MenuScreen();
                m_CurrentItem = m_CurrentItem.Ancestor;
            }

            else
            {
                Console.WriteLine(@"We are sorry to hear about that. 
Hope to see you again");
                Environment.Exit(0);
            }
        }




        private void ChooseYourOption(out int i_Choice)
        {
            do
            {
                //Console.Clear();
                Console.WriteLine("Choose your option :");
            } while (!(int.TryParse(Console.ReadLine(), out i_Choice) && ChoiceIsValid(i_Choice)));
        }

        private bool ChoiceIsValid(int i_Choice)
        {
            return i_Choice >= 0 && i_Choice <= Menu.Count;
        }


        public void MenuScreen()
        {

            Console.Clear();
            Console.WriteLine(Title + Environment.NewLine);

            foreach (MenuUnit item in r_Menu)
            {
                Console.WriteLine(@"{0} - {1}
                ", r_Menu.IndexOf(item) + 1, item.Title);

            }
            Continue();
        }

        private void Continue()
        {

            do
            {
                Console.WriteLine(@"Press ENTER to continue
                ");

            } while (Console.ReadLine() != "");

        }
    }
}
