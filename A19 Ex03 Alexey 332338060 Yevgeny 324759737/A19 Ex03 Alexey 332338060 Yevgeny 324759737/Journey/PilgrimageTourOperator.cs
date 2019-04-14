

using System;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class PilgrimageTourOperator : TourOperator
    {
        public override string GetDescription()
        {
            return "Religion";
        }

        protected override Journey CreateJourney()
        {
            return new PilgrimageTrip(); 
        }
    }
}
