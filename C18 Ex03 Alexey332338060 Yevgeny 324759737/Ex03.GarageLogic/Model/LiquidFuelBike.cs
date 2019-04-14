using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class LiquidFuelBike: Bike
    {

        


        public LiquidFuelBike (GeneralRequest i_GeneralDetails, BikeRequest i_BikeData, float i_CurrentEnergyLevel, float i_MaxEnergyLevel)
           :base(i_GeneralDetails, i_BikeData)
        {

            Engine = new Engine(FuelType.Octan95, i_CurrentEnergyLevel, i_MaxEnergyLevel);

        }

        


    }
}
