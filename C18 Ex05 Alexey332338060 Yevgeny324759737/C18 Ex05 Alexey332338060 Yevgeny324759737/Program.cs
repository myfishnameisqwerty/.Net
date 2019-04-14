using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05_FourinRow_GUI
{
    class Program
    {

        public static void Main()
        {
            GameSettings startScreen = new GameSettings();
            startScreen.ShowDialog();
            Application.Exit();

        }




    }
}
