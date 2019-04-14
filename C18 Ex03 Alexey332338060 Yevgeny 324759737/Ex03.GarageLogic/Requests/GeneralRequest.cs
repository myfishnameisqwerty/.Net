using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public struct GeneralRequest
    {
        private string m_Model;
        private string m_LicencePlate;
        private List<Wheel> m_Wheels;
        private float m_EnergyRemained;

        public GeneralRequest(string i_Model, string i_LicencePlate,float i_EnergyRemained)
        {
            m_Model = i_Model;
            m_LicencePlate = i_LicencePlate;
            m_Wheels = new List<Wheel>();
            m_EnergyRemained = i_EnergyRemained;
        }


        public string Model
        {
            get { return m_Model; }
            
        }

        public float EnergyRemained
        {
            get { return m_EnergyRemained; }
        }

         public string LicencePlate
        {
            get { return m_LicencePlate; }
         }

         public List<Wheel> Wheels
        {
            get { return m_Wheels; }
         }



        public void AddWheel(string i_Producer, float i_CurrentPressure, float i_MaxPressure)
        {
            //we call this method number of wheels times which in turn depends on vehicle type
            Wheel wheel = new Wheel(i_Producer, i_CurrentPressure, i_MaxPressure);

            

            m_Wheels.Add(wheel);
        }
    }
    
}
