using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03.GarageLogic
{
    

    public class Engine
    {

       private FuelType m_EnergyType;
       private float m_CurrentEnergyLevel;
       private float m_MaxEnergyLevel;


        public Engine(FuelType i_KindOfFuel, float i_CurrentEnergyLevel, float i_MaxEnergyLevel){

            EnergyType = i_KindOfFuel;
            MaxEnergyLevel = i_MaxEnergyLevel;
            CurrentEnergyLevel = i_CurrentEnergyLevel;
        }


        public FuelType EnergyType
        {
            get { return m_EnergyType; }

            set {m_EnergyType = value;}
        }


        public float CurrentEnergyLevel
        {
            get { return m_CurrentEnergyLevel; }

            set {m_CurrentEnergyLevel = value;}
         }

        public void RefuelVehicle(float i_Quantity, FuelType i_FuelType)
        {
            if (i_FuelType != EnergyType)
                throw new ArgumentException("Inappropriate fuel type");

            Vehicle.RefillIfNotOverflowOrNegativeInput(ref m_CurrentEnergyLevel, i_Quantity, m_MaxEnergyLevel);
            
        }

        public float MaxEnergyLevel
        {
            get { return m_MaxEnergyLevel; }

            set{m_MaxEnergyLevel = value;}

        }






    }
}
