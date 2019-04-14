using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public struct CarRequest
    {

        private CarColor m_CarColor;
        private Doors m_numberOfDoors;


       public CarRequest(CarColor i_Colour, Doors i_NumberOfDoors)
        {
            m_CarColor = i_Colour;
            m_numberOfDoors = i_NumberOfDoors;

        }

        public CarColor CarColor
        {
          get{ return m_CarColor;}
        }


        public Doors NumberOfDoors
        {
            get { return m_numberOfDoors; }
        }



    }

}

