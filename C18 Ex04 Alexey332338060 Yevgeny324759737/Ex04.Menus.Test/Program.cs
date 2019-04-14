using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(@"Delegates test is running {0}", Environment.NewLine);
            new UIDelegates().Run();
            Console.WriteLine(@"Interface test is running {0}", Environment.NewLine);
            InterfacesTest.RunInterface();
            

        }





    }
}
