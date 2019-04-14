using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    public class Helper : ICallable
    {
        public void Invoke(string i_Headline)
        {
            string value = "";
            

            switch (i_Headline)
            {
                case "Show Date":
                   value= DateTime.Now.ToString("dd/MM/yyyy");
                   break;

                case "Show Time":
                    value = DateTime.Now.ToString("h:mm:ss tt");
                    break;

                case "Show Version":
                    value = "18.3.4.0";
                    break;

                case "Count Capitals":
                    value = CountCapitals().ToString();
                    break;

                default:
                    Console.WriteLine("Unknown method");
                    break;
            }

            Console.WriteLine(@"{0} : {1}
            ",i_Headline,value);
        }
        
        public int CountCapitals()
        {

            Console.WriteLine(@"Please write your sentence
            ");
            string input = Console.ReadLine();
            int capitals = 0;

            foreach(char letter in input)
            {
                if (letter >= 'A' && letter <= 'Z')
                    capitals++;
            }

            return capitals;
        }

    }
}
