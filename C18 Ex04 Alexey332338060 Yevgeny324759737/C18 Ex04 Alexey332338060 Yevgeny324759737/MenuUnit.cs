using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public abstract class MenuUnit 
    {
       private readonly MainMenu r_Ancestor;
       private readonly string r_Title;
        
        

        protected MenuUnit(MainMenu i_Father,string i_Title)
        {
            r_Ancestor = i_Father;
            r_Title = i_Title;
        }


        public MainMenu Ancestor
        {
            get { return r_Ancestor; }
        }

        
        public string Title
        {
            get { return r_Title; }
        }

    }

}
