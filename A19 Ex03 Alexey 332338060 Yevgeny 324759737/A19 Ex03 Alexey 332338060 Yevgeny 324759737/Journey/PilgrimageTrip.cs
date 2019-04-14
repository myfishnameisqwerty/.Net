using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class PilgrimageTrip : Journey
    {

        String Faith { get; set; }

        public override float Cost()
        {
            return 2500.25f;
        }

        protected internal override void LoadUniqueParameters(List<string> i_UniqueParams)
        {
            Faith = i_UniqueParams[0];
        }
    }
}
