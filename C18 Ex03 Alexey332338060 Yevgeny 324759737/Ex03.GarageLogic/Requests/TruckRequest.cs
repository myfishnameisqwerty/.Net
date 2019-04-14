using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
   public struct TruckRequest
    {

        private float m_TrunkVolume;
        private bool m_TrunkIsChilled;


        public TruckRequest(float i_TrunkVolume,bool i_isChilled) {
            m_TrunkVolume = i_TrunkVolume;
            m_TrunkIsChilled = i_isChilled;
        }

        public float TrunkVolume
        {
            get { return m_TrunkVolume; }
            set { m_TrunkVolume = value; }
        }

        public bool TrunkIsChilled
        {
            get{ return m_TrunkIsChilled; }
           
            set { m_TrunkIsChilled = value; }
        }

    }
}
