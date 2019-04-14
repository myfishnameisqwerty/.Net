using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
   public class LiquidFuelCar : Car
    {

       

        public LiquidFuelCar(GeneralRequest i_GeneralDetails, CarRequest i_CarDetails, float i_CurrentEnergyLevel, float i_MaxEnergyLevel)
            : base(i_GeneralDetails,i_CarDetails)
        {
         Engine = new Engine(FuelType.Octan96, i_CurrentEnergyLevel, i_MaxEnergyLevel);
        }



        


    }
}
