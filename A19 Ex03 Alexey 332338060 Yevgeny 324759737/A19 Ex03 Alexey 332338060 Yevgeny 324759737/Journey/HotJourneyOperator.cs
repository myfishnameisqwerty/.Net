using System;


namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class HotJourneyOperator : TourOperator
    {
        public override string GetDescription()
        {
            return "Sex trip";
        }

        protected override Journey CreateJourney()
        {
            return new HotJourney();
        }
    }
}
