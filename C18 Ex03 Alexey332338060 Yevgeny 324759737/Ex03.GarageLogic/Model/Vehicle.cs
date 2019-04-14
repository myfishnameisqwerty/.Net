//using System;
using System.Collections.Generic;
using System.Text;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
   

   public abstract class Vehicle
    {
        protected string m_Model;
        protected string m_LicencePlate;
        protected float m_EnergyRemained;
        protected List<Wheel> m_WheelSet;
        protected Engine m_Engine;
        




        protected Vehicle (GeneralRequest i_CommonDetails)
        {
            m_Model = i_CommonDetails.Model;
            m_LicencePlate = i_CommonDetails.LicencePlate;
            m_EnergyRemained = i_CommonDetails.EnergyRemained;
            m_WheelSet = i_CommonDetails.Wheels;
        }

        public void UpdateEnergyLvl()
        {
            m_EnergyRemained = (Engine.CurrentEnergyLevel / Engine.MaxEnergyLevel) * 100;
        }

        public Engine Engine
        {
            get { return m_Engine; }
            set { m_Engine = value; }
        }

        public List<Wheel> WheelSet
        {
            get { return m_WheelSet; }

            set {m_WheelSet = value;}

        }

        public string Model
        {
            get {return m_Model;}

            set{m_Model = value;}

        }

        public string LicencePlate {

            get {return m_LicencePlate;}

            set{LicencePlate = value;}
       }


        public float EnergyRemained
        {
            get { return m_EnergyRemained; }
            set { m_EnergyRemained = value; }
        }

        
        public static void RefillIfNotOverflowOrNegativeInput(ref float i_CurrentLevel,float i_ValueToAdd, float i_MaxLevel)
        {
            bool mustBePositive = true;
            if (ValueOutOfRangeException.LowerBoundRelationIsInvalid(i_ValueToAdd, mustBePositive) == true)
                throw new ValueOutOfRangeException();//Add an appropriate message

            float refill = i_CurrentLevel + i_ValueToAdd;
            CheckIfInTheRange(refill, i_MaxLevel);
            i_CurrentLevel = refill;
        }


        //all the setters check if input is valid!!!!!!!!!!

        public override bool Equals(object i_Obj)
        {
            bool equals = false;

            Vehicle toCompareTo = i_Obj as Vehicle;
            if (toCompareTo != null)
            {
                equals = this.GetHashCode() == toCompareTo.GetHashCode();
            }

            return equals;

        }


        public static void CheckIfInTheRange(float i_Value, float i_UpperBound)
        {
            bool maxLevel = false;

            ValueOutOfRangeException.MaxValue = i_UpperBound;
            ValueOutOfRangeException.MinValue = 0;

            if (i_Value == i_UpperBound)
            {
                maxLevel = true;

                if (ValueOutOfRangeException.LowerBoundRelationIsInvalid(i_Value, maxLevel))
                    throw new ValueOutOfRangeException();
            }

            else
            {
              if (ValueOutOfRangeException.IsNotInTheScope(i_Value, maxLevel))
                    throw new ValueOutOfRangeException();
            }
        }




        public override int GetHashCode()
        {
            return m_LicencePlate.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(300);
            string generalData = string.Format(
            @"Licence Plate : {0}
              Model: {1}
              Remained energy(in %): {2}
              ",LicencePlate, Model, EnergyRemained);
            output.Append(generalData);
            output.Append(WheelsDescription());
            output.Append(EngineData(Engine.EnergyType));

            return output.ToString();
        }

        public string EngineData(FuelType i_Energy)
        {
            string engineDescription;

            if (i_Energy.Equals(FuelType.Electricity))
            {
                engineDescription = string.Format(@"
            Current Battery Level : {0}
            Maximum Time For Battery(in hours) : {1}
            ", Engine.CurrentEnergyLevel, Engine.MaxEnergyLevel);
            }

            else
            {
                engineDescription = string.Format(@"
                Kind of fuel : {0}
                Gasoline level for now : {1}
                Maximum gasoline level : {2}
                ",Engine.EnergyType, Engine.CurrentEnergyLevel, Engine.MaxEnergyLevel);
            }

            return engineDescription;
        }

        


        public string WheelsDescription()
        {
            StringBuilder wheelsData = new StringBuilder(200);
            int count=1;
            string headline = string.Format(@"
            Wheels' description :
            
            ");
            wheelsData.Append(headline);

            foreach (Wheel wheel in WheelSet)
            {
               string description = string.Format(@"
               Wheel {0} details:
               Manufacturer: {1}
               Air pressure: {2}
               
               ",count,wheel.Producer,wheel.CurrentPressure);
                wheelsData.Append(description);
                count++;
             }

            return wheelsData.ToString();

        }




    }


}

