using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public struct BikeRequest
    {
        private DrivingLicenceCategory m_LicenceCategory;



        public BikeRequest (DrivingLicenceCategory i_LicenceCategory)
        {
            m_LicenceCategory = i_LicenceCategory;
        }

        public DrivingLicenceCategory LicenceCategory
        {
            get { return m_LicenceCategory; }

            set { m_LicenceCategory = value; }

        }



    }
}
