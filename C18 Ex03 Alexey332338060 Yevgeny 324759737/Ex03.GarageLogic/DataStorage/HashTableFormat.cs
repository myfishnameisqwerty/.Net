using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03.GarageLogic
{

    public class HashTableFormat
    {
        private Vehicle m_Vehicle;//Better to save it as a Vehicle instance!!!!

        private bool m_IsElectric;
        private Person m_Person;
        private VehicleStatus m_Status;
        private VehicleType m_VehicleType;
        public HashTableFormat(Vehicle i_Vehicle, bool i_IsElectric, string i_ClientName, string i_ClientPhone, VehicleType i_VehicleType)
        {
            m_Vehicle = i_Vehicle;
            m_IsElectric = i_IsElectric;
            m_Status = VehicleStatus.repairing;
            m_Person = new Person(i_ClientName, i_ClientPhone);
            m_VehicleType = i_VehicleType;
        }

        public VehicleType VehicleType
        {
            get { return m_VehicleType; }
        }
        public Vehicle Vehicle
        {
            get { return m_Vehicle; }
        }
        public VehicleStatus CarStatus
        {
            get { return m_Status; }
            set { m_Status = value; }
        }

        public Person ContactPerson
        {
            get { return m_Person; }

        }

        public bool IsElectric
        {
            get { return m_IsElectric; }
        }


    }
}