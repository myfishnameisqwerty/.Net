using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
   
   

     public abstract class Car :Vehicle
     {
        protected CarColor m_carColor;
        protected Doors m_numberOfDoors;


        protected Car (GeneralRequest i_CommonDetails,CarRequest i_CarDetails): base (i_CommonDetails)
        {
            CarColor = i_CarDetails.CarColor;
            NumberOfDoors = i_CarDetails.NumberOfDoors;

        }


        public CarColor CarColor
        {
            get { return m_carColor; }

            set { m_carColor = value; }
            
        }


        public Doors NumberOfDoors
        {
            get { return m_numberOfDoors; }

            set { m_numberOfDoors = value; }
        }

        public override string ToString()
        {
            string carData = string.Format
            (@"Color: {0}
             Number of doors:{1}
            ",CarColor,NumberOfDoors);

            StringBuilder inConclusion = new StringBuilder(300);
            inConclusion.Append(base.ToString());
            inConclusion.Append(carData);

            return inConclusion.ToString();
            
        }


    }
}
