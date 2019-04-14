using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public class  ActionItem : MenuUnit
    {

        private readonly ICallable r_Action;

        public ActionItem (MainMenu i_Ancestor, string i_Title, ICallable i_Action) :base(i_Ancestor, i_Title)
        {
            r_Action = i_Action;
        }


        


        public ICallable Action
        {
            get { return r_Action; }
        }





    }
}
