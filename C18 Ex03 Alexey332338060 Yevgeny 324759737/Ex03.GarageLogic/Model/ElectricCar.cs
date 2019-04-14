using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricCar : Car
    {
        
        

        public ElectricCar(GeneralRequest i_GlobalRequest,CarRequest i_GenericCar, float i_EnergyRemined, float i_MaxEnergyLevel) 
            : base(i_GlobalRequest, i_GenericCar)
        {
            Engine = new Engine(FuelType.Electricity, i_EnergyRemined, i_MaxEnergyLevel);
            
        }

       


        


    }
}
