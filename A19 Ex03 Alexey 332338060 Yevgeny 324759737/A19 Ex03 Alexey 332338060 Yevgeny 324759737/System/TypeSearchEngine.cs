using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public static class TypeSearchEngine
    {

        public static Type TypeSearchAssemblyIsUnknown(string i_Namespace, string i_Input)
        {
           string fullName = string.Format(@"{0}.{1}", i_Namespace, i_Input);

            Type chosenType = null;

            foreach (Assembly dll in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in dll.GetTypes())
                {
                    if (type == Type.GetType(fullName, true, true))
                    {
                        chosenType = type;
                        break;
                    }
                }
            }

            return chosenType;
        }

        

    }
}
