using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
         private static  float m_MaxValue;
         private static float m_MinValue;



        public static bool LowerBoundRelationIsInvalid(float i_Value,bool i_MustBePositive)
        {
            return (i_MustBePositive == true? i_Value <= m_MinValue : i_Value < m_MinValue);
        }




        public static bool IsNotInTheScope(float i_Value, bool i_MaxLevel) {

            return LowerBoundRelationIsInvalid(i_Value, i_MaxLevel) || i_Value> m_MaxValue;

        }




        public override string Message
        {
            get
            {
                return "Your value is either negative/zero or exceeds an upper bound";
            }
        }

        public static float MaxValue
        {
            set { m_MaxValue = value; }
        }

        public static float MinValue
        {
            set { m_MinValue = value; }
        }



    }
}
