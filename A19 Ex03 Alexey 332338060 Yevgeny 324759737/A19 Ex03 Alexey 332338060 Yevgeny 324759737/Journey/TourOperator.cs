using System;
using System.Collections.Generic;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public abstract class TourOperator : IDescribable
    {
        protected Journey m_Trip;

        public abstract string GetDescription();

        protected abstract Journey  CreateJourney();


        public  Journey OrderTrip(Ticket i_Ticket,List<string> i_UniqueParams)
        {
            m_Trip = CreateJourney();
            m_Trip.FlightTicket = i_Ticket;
            m_Trip.Description = GetDescription();
            m_Trip.LoadUniqueParameters(i_UniqueParams);
            return m_Trip;

        }

    }
}
