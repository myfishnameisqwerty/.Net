using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck: Vehicle
    {
        private float m_TrunkVolume;
        private bool m_TrunkIsChilled;


       public Truck(GeneralRequest i_CommonDetails, TruckRequest i_TruckDetails, float i_CurrentEnergyLevel, float i_MaxEnergyLevel) : base(i_CommonDetails)
       {
            TrunkVolume = i_TruckDetails.TrunkVolume;
            TrunkIsChilled = i_TruckDetails.TrunkIsChilled;
            Engine = new Engine(FuelType.Solar, i_CurrentEnergyLevel, i_MaxEnergyLevel);

       }

        public float TrunkVolume
        {
            get { return m_TrunkVolume; }
            set { m_TrunkVolume = value; }
        }

        public bool TrunkIsChilled
        {
            get { return m_TrunkIsChilled; }

            set { m_TrunkIsChilled = value; }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(200);
            string truckDetails = string.Format(@"
            Trunk Volume : {0}
            Trunk is Chilled(1-yes, 0 -no): {1}
            ",TrunkVolume,TrunkIsChilled);

            output.Append(base.ToString());
            output.Append(truckDetails);

            return output.ToString();
        }



    }
}
