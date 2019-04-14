using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Ex03.GarageLogic;

namespace Ex03.GarageLogic
{
    public class GarageLogic
    {

        private Dictionary<string, HashTableFormat> m_HashTable;
        public GarageLogic()
        {
            m_HashTable = new Dictionary<string, HashTableFormat>();
        }
        public Dictionary<string, HashTableFormat> HashTable
        {
            get { return m_HashTable; }
        }


        private bool PressureIsNormal(Vehicle i_Vehicle)
        {
            bool normalPressure = true;

            foreach (Wheel wheel in i_Vehicle.WheelSet) {
                if (wheel.CurrentPressure != wheel.MaxPressure)
                {
                    normalPressure = false;
                    break;
                }
            }
            return normalPressure;
        }

        private bool FullTank(Vehicle i_Vehicle)
        {
            return i_Vehicle.EnergyRemained == 100.0f;
        }

        public float NeededToMaxLevelOfEnergy(string i_Key)
        {
            float toMax = (HashTable[i_Key].Vehicle as Vehicle).Engine.MaxEnergyLevel - (HashTable[i_Key].Vehicle as Vehicle).Engine.CurrentEnergyLevel;
            return toMax;
        }

        private bool CarIsRepaired(string i_Plate)
        {
            return FullTank(m_HashTable[i_Plate].Vehicle) && PressureIsNormal(m_HashTable[i_Plate].Vehicle);
        }


        private bool IsPayed(string i_LicencePlate)
        {
            return m_HashTable[i_LicencePlate].CarStatus == VehicleStatus.payed;
        }

        public bool TryToChangeStatus(string i_Id, VehicleStatus i_State)
        {
            bool ifSucceed = false;
            if (m_HashTable.ContainsKey(i_Id) && IsPayed(i_Id) == false && m_HashTable[i_Id].CarStatus!=i_State)
            {
                if (CarIsRepaired(i_Id))
                {
                    m_HashTable[i_Id].CarStatus = i_State;
                    ifSucceed = true;
                }
            
            }
            return ifSucceed;
        }

        public Vehicle CreateVehicle(GeneralRequest generalRequest, object vehicleRequest, bool IsElectric)
        {
            const float electricCarMaxEnergyLevel = 4.8f;
            const float electricBikeMaxEnergyLevel = 3.2f;
            const float liquidFuelBikeMaxEnergyLevel = 5f;
            const float liquidFuelCarMaxEnergyLevel = 48f;
            const float truckMaxEnergyLevel = 105f;

            float remainadEnergy = generalRequest.EnergyRemained;
            Vehicle vehicle = null;

            if (vehicleRequest.GetType().Name == "CarRequest")
            {
                if (IsElectric)
                {
                    vehicle = new ElectricCar(generalRequest, (CarRequest)vehicleRequest, CurrentEnergyLevel(electricCarMaxEnergyLevel, remainadEnergy), electricCarMaxEnergyLevel);
                }
                else
                    vehicle = new LiquidFuelCar(generalRequest, (CarRequest)vehicleRequest, CurrentEnergyLevel(liquidFuelCarMaxEnergyLevel, remainadEnergy), liquidFuelCarMaxEnergyLevel);

            }
            else if (vehicleRequest.GetType().Name == "BikeRequest")
            {
                if (IsElectric)
                {
                    vehicle = new ElectricBike(generalRequest, (BikeRequest)vehicleRequest, CurrentEnergyLevel(electricBikeMaxEnergyLevel, remainadEnergy), electricBikeMaxEnergyLevel);
                }
                else
                    vehicle = new LiquidFuelBike(generalRequest, (BikeRequest)vehicleRequest, CurrentEnergyLevel(liquidFuelBikeMaxEnergyLevel, remainadEnergy), liquidFuelBikeMaxEnergyLevel);

            }
            else if (vehicleRequest.GetType().Name == "TruckRequest")
            {
                vehicle = new Truck(generalRequest, (TruckRequest)vehicleRequest, CurrentEnergyLevel(truckMaxEnergyLevel, remainadEnergy), truckMaxEnergyLevel);
            }
            return vehicle;
        }

        private float CurrentEnergyLevel(float i_MaxValue, float i_EnergyInPercent)
        {
            return (i_EnergyInPercent *i_MaxValue) / 100;
        }
        public bool AddItemToHashTable(string i_LicensePlate, Vehicle i_Vehicle, bool i_IsElectric, string i_ClientName, string i_ClientPhone, VehicleType i_VehicleType)
        {
            bool ifsucceed = true;
            try
            {
                HashTableFormat newItem = new HashTableFormat(i_Vehicle, i_IsElectric, i_ClientName, i_ClientPhone, i_VehicleType);
                HashTable.Add(i_LicensePlate, newItem);

            }
            catch(OutOfMemoryException)
            {
                ifsucceed = false;
            }
            return ifsucceed;
        }

        public float GetMaxPressure(VehicleType i_Type)
        {
            float maximumPressure = 0.0f;

            switch (i_Type)
            {
                case VehicleType.Bike:
                    maximumPressure = 28.0f;
                    break;
                case VehicleType.Car:
                    maximumPressure = 30.0f;
                    break;
                case VehicleType.Truck:
                    maximumPressure = 32.0f;
                    break;
            }

            return maximumPressure;

        }


        public int GetNumberOfWheels(VehicleType i_Type)
        {
            int numberOfWheels = 0;

            switch (i_Type)
            {
                case VehicleType.Car:
                    numberOfWheels = 4;
                    break;
                case VehicleType.Bike:
                    numberOfWheels = 2;
                    break;

                case VehicleType.Truck:
                    numberOfWheels = 16;
                    break;

            }

            return numberOfWheels;
        }
    }
}
