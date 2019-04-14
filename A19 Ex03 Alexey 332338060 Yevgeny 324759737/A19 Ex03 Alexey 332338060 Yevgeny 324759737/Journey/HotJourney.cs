using System;
using System.Collections.Generic;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class HotJourney : Journey
    {

        public string SexualPreference { get; set; }
        public bool TakesDrugs { get; set; }

        public override float Cost()
        {
            return 1235.4f;
        }

        protected internal override void LoadUniqueParameters(List<string> i_UniqueParams)
        {
            SexualPreference = i_UniqueParams[0];
            TakesDrugs = bool.Parse(i_UniqueParams[1]);
        }
    }
}
