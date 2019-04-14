using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
   public class Wheel
    {
        protected string m_Producer;
        private float m_CurrentPressure;
        private float m_MaxPressure;



        public Wheel (string i_Producer,float i_CurrentPressure, float i_MaxPressure)
        {
            Producer = i_Producer;
            MaxPressure = i_MaxPressure;
            CurrentPressure = i_CurrentPressure;
        }


        public void InflateTyre(float i_AirVolume)
        {
            Vehicle.RefillIfNotOverflowOrNegativeInput(ref m_CurrentPressure, i_AirVolume, m_MaxPressure);
        }

        

        public string Producer
        {
            get { return m_Producer; }
            set { m_Producer = value; }
        }

        public float CurrentPressure
        {
            get { return m_CurrentPressure; }
            set { m_CurrentPressure = value; }
        }

        public float MaxPressure
        {
            get { return m_MaxPressure; }
            set { m_MaxPressure = value; }
        }
    }
}
