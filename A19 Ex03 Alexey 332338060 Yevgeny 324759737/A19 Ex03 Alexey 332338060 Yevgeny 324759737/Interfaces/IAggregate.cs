using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    interface IAggregate
    {
        void CreateIterator(params object[] i_Parameters);
    }
}
