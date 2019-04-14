using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Person
    {
        string m_Name;
        string m_Phone;
        public Person(string i_Name, string i_Phone)
        {
            m_Name = i_Name;
            Phone = i_Phone;
        }
        public string Name
        {
            get { return m_Name; }
        }
        public string Phone
        {
            get { return m_Phone; }
            set { m_Phone = value; }
        }
    }
}
