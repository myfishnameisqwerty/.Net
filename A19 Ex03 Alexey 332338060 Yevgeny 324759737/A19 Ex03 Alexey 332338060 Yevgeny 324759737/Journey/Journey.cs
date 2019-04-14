using System;
using System.Collections.Generic;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{

    [Serializable]
    public abstract class Journey :IValuable
    {
        public Ticket FlightTicket { get; set; }

        public string Description { get; internal set; }
        
        protected internal abstract void LoadUniqueParameters(List<string> i_UniqueParams);
        public abstract float Cost();
    }
}
