using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class FillCollectionStrategy
    {

        public Action<int> Filler {get; set;}


        public FillCollectionStrategy(Action<int> i_Delegate)
        {
            Filler = i_Delegate;
        }






        public void FillCollection(int i_Value)
        {
            Filler.Invoke(i_Value);
        }


    }
}
