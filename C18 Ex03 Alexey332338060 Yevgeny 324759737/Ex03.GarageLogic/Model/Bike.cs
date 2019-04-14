using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
   

    public abstract class Bike : Vehicle
    {
        protected DrivingLicenceCategory m_LicenceCategory;


        protected Bike(GeneralRequest i_CommonDetails, BikeRequest i_BikeDetails) : base(i_CommonDetails)
        {
            LicenceCategory = i_BikeDetails.LicenceCategory;
        }
        
        public DrivingLicenceCategory LicenceCategory
        {
            get { return m_LicenceCategory; }

            set { m_LicenceCategory = value; }

        }




        public override string ToString()
        {
            StringBuilder inConclusion = new StringBuilder(300);
            string bikeData = string.Format(@"
            LicenceCategory : {0}
            ",m_LicenceCategory);

            inConclusion.Append(base.ToString());
            inConclusion.Append(bikeData);

            return inConclusion.ToString();

        }


    }
}
