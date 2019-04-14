using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegate;

namespace Ex04.Menus.Test
{
    public class UIDelegates
    {
        private const string k_Version = "18.3.4.0";

        private readonly MainMenu r_MainMenu;

        public UIDelegates()
        {
            r_MainMenu = new MainMenu();
            initialMainMenu();
        }

        public  void Run()
        {
            r_MainMenu.Show();
        }

        private void initialMainMenu()
        {
            
            SubMenu firstOption = new SubMenu("Show Date/Time");
            firstOption.AddItem(new MyMethod("Show Date", ShowDate));
            firstOption.AddItem(new MyMethod("Show Time", ShowTime));
            r_MainMenu.AddSubMenu(firstOption);


            SubMenu secondOption = new SubMenu("Version and Spaces");
            secondOption.AddItem(new MyMethod("Show Version", ShowVersion));
            secondOption.AddItem(new MyMethod("Count Spaces", CountCapitals));
            r_MainMenu.AddSubMenu(secondOption);

        }



        private void ShowDate()
        {
            string currentDate = null;

            currentDate = string.Format("Current Date -> " + DateTime.Today.ToShortDateString());
            Console.WriteLine(currentDate);
        }

        private void ShowTime()
        {
            string currentTime = null;

            currentTime = string.Format("Current Time -> " + DateTime.Now.ToShortTimeString());
            Console.WriteLine(currentTime);
        }

        private void ShowVersion()
        {
            Console.WriteLine("The version is : {0}", k_Version);
        }

        private void CountCapitals()
        {
            string userInput;
            int amountOfCapitalLetters = 0;

            userInput = GetUserInput();
            foreach (char currentChar in userInput)
            {
                if (char.IsUpper(currentChar))
                {
                    amountOfCapitalLetters++;
                }
            }

            Console.WriteLine("The amount of capital letters is : {0}", amountOfCapitalLetters);
        }

        private string GetUserInput()
        {
            string userInput = null;
            bool isStringIsValid = false;

            while (!isStringIsValid)
            {
                Console.Write("Please enter a sentence : ");
                userInput = Console.ReadLine();
                if (userInput.Length > 0)
                {
                    isStringIsValid = true;
                }
                else
                {
                    Console.WriteLine("I want an input!!!");
                }
            }

            return userInput;
        }
    }
}
