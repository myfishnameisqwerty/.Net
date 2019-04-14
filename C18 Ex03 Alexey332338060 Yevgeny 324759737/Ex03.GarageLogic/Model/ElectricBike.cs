using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricBike : Bike
    {

        public ElectricBike(GeneralRequest i_GeneralData, BikeRequest i_BikeData, float i_CurrentEnergyLevel, float i_MaxEnergyLevel)
           : base(i_GeneralData, i_BikeData)
        {

            Engine = new Engine(FuelType.Electricity, i_CurrentEnergyLevel, i_MaxEnergyLevel);

        }


        


    }
}
