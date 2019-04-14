using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegate
{
    public class SubMenu : MenuItem
    {
        private static int s_MenuLevelNumber;

        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();

       
        private void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine(string.Format("               Menu Level Number -> {0}" + Environment.NewLine, s_MenuLevelNumber));
            PrintOptions();
            Console.Write(string.Format(Environment.NewLine + "Select option -> "));
        }

        private void PrintOptions()
        {
            int currentIndex = 1;

            Console.WriteLine(string.Format(Name + Environment.NewLine));

            switch (s_MenuLevelNumber)
            {
                case 1:
                    Console.WriteLine("0 - Exit");
                    break;

                default:
                    Console.WriteLine("0 - Back");
                    break;
            }

            foreach (MenuItem menuItem in r_MenuItems)
            {
                Console.WriteLine(string.Format("{0} -> " + r_MenuItems[currentIndex - 1].Name, currentIndex++));
            }
        }

        private bool IsNumberInBorder(int i_ChoosenNumber)
        {
            return i_ChoosenNumber >= 0 && i_ChoosenNumber <= r_MenuItems.Count;
        }

        private int UserInput()
        {
            int selectedNumber = 0;
            bool inputIsLegal = false;

            while (!inputIsLegal)
            {
                if (!int.TryParse(Console.ReadLine(), out selectedNumber))
                {
                    Console.WriteLine("Just numbers please.");
                }
                else if (!IsNumberInBorder(selectedNumber))
                {
                    Console.WriteLine("You can select numbers from {0} to {1}. Try again. You can make it!", 0, r_MenuItems.Count);
                }
                else
                {
                    inputIsLegal = true;
                }
            }

            return selectedNumber;
        }

        

      

        public override void OnGettingMethod()
        {
            bool leaveTheMethod = false;
            int userChoice = 0;

            s_MenuLevelNumber++;
            do
            {
                leaveTheMethod = true;
                PrintMenu();
                userChoice = UserInput();

                if (userChoice != 0)
                {
                    leaveTheMethod = false;
                    r_MenuItems[userChoice - 1].OnGettingMethod();                  
                }
                else
                {
                    ReduceMenuLvl();
                }
            }
            while (!leaveTheMethod);
        }


        private void ReduceMenuLvl()
        {
            s_MenuLevelNumber = s_MenuLevelNumber != 1 ? --s_MenuLevelNumber: s_MenuLevelNumber;

        }

      

        public void AddItem(MenuItem i_SubMenu)
        {
            r_MenuItems.Add(i_SubMenu);
        }

        public int LayerNumber
        {
            get { return s_MenuLevelNumber; }

            set { s_MenuLevelNumber = value; }
        }

        public List<MenuItem> MenuItemsList
        {
            get { return r_MenuItems; }
        }
        public SubMenu(string i_MenuName) : base(i_MenuName)
        {
        }
    }
}
