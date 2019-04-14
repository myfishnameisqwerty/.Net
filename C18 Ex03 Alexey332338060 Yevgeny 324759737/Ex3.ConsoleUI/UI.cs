using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Globalization;

namespace Ex3.ConsoleUI
{

    public class UI
    {
        private GeneralRequest m_GeneralRequest;
        private object m_VehicleRequest;
        private  GarageLogic m_Logic;
        private bool m_Flag = false;
        private enum ParseValidity { LicencePlate, ClientName, ClientPhone }
        VehicleType m_VehicleType;
        public UI()
        {
            m_Logic = new GarageLogic();
        }

        public void StartMenu()
        {
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine(@"Select one of the options:
1 - Enter vehicle to garage
2 - Show all license plates
3 - Change vehicle status to fixed or payed
4 - Inflate tyre
5 - Tank up fuel vehicle
6 - Charge electric vehicle
7 - Show vehicle data
0 - Exit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        EnterVehicleToGarage();
                        break;
                    case "2":
                        PrintLicencePlates();
                        break;

                    case "3":
                        ChangeVehicleStatusToFixedOrPayed();
                        
                        break;

                    case "4":
                        PumpUpTyres(GetLicencePlate());
                       
                        break;

                    case "5":
                        FillTankOrChargeBattery(GetLicencePlate(), ChooseFuel());
                      
                        break;

                    case "6":
                        FillTankOrChargeBattery(GetLicencePlate(), FuelType.Electricity);
                       
                        break;

                    case "7":
                        FullVehicleDescription(GetLicencePlate());
                        
                        break;

                    case "0":
                        Console.WriteLine("Buy-buy, and remember, I KNOW WHAT YOU DID LAST SUMMER!!!!");
                        break;
                }
                    PressAnyKey();
            } while (input.Equals("0") == false);

        }

        private void PrintLicencePlates()
        {

            Console.WriteLine(@"Select the option
1 - print all license plates that in the garage
2 - just bikes
3 - just cars
4 - just trucks
5 - status repairing
6 - status repaired
7 - status payed
");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    PrintAllPlates();
                    PressAnyKey();
                    break;
                case "2":
                    PrintPlatesByFilter(VehicleType.Bike);
                    break;
                case "3":
                    PrintPlatesByFilter(VehicleType.Car);
                    break;
                case "4":
                    PrintPlatesByFilter(VehicleType.Truck);
                    break;
                case "5":
                    OutputByStatusFilter(VehicleStatus.repairing);
                    break;
                case "6":
                    OutputByStatusFilter(VehicleStatus.repaired);
                    break;
                case "7":
                    OutputByStatusFilter(VehicleStatus.payed);
                    break;
            }

        }
        private void PrintPlatesByFilter(VehicleType i_VehicleType)
        {
            foreach (string key in m_Logic.HashTable.Keys)
            {
                if (m_Logic.HashTable[key].VehicleType == i_VehicleType)
                    Console.WriteLine(key);
            }
        }
        private void PressAnyKey()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        private void ChangeVehicleStatusToFixedOrPayed ()
        {
            Console.WriteLine("For changing status to fixed, vehicle have to be fully charged or fueled and maxim pressure in all the wheels.");
            if (m_Logic.TryToChangeStatus(GetLicencePlate(), GetStatusForChange()) == false)
            {
                Console.WriteLine(@"Can't change to this status. Some requirements are not matching.
For changing status to fixed, vehicle have to be fully charged or fueled and maxim pressure in all the wheels.
Drive safety and don't try to kill our clients.");
            }
        }

        private void PrintAllPlates()
        {
            foreach (string key in m_Logic.HashTable.Keys)
            {
                Console.WriteLine(key);
            }

        }


        private void EnterVehicleToGarage()
        {
            string licensePlate;
            Console.Clear();

            try
            {
                licensePlate = GetLicencePlate();
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
                return;
            }


            if (m_Logic.HashTable.ContainsKey(licensePlate))
            {
                Console.WriteLine(@"This license plate is all ready in garage.
Press '1' for re-enter the plate or '2' for exit to menu");
                bool runTillInvalidInput = true;
                while (runTillInvalidInput)
                {
                    string choise = Console.ReadLine();
                    if (choise == "1")
                    {
                        runTillInvalidInput = false;
                        EnterVehicleToGarage();
                    }
                    else if (choise == "2")
                    {
                        break;
                    }
                    Console.WriteLine("Press '1' for re-enter the plate or '2' for exit to menu");
                }
            }
            else
            {
                CreateNewHashTableRecord(licensePlate);
                
            }

        }
        private void CreateNewHashTableRecord(string i_LicensePlate)
        {

            bool isElectric = false;
            string clientName = "";
            string clientPhone = "";

            clientName = GetClientName();
            clientPhone = GetClientPhone();
            BuildRequests(i_LicensePlate, ref isElectric);

            m_Logic.AddItemToHashTable(i_LicensePlate,
                m_Logic.CreateVehicle(m_GeneralRequest, m_VehicleRequest, isElectric),
                                                                                        isElectric, clientName, clientPhone, m_VehicleType);

        }


        private void SpecialFormatCheck(string i_Input, ParseValidity i_Format)
        {
            switch (i_Format)
            {
                case ParseValidity.LicencePlate:
                    if (Regex.IsMatch(i_Input, @"^[a-zA-Z0-9]+$") == false)
                        throw new FormatException("Licence plate must contain digits and/or letters only");
                    break;

                case ParseValidity.ClientName:
                    if (Regex.IsMatch(i_Input, @"^[a-zA-Z]+$") == false)
                        throw new FormatException("Client's name must contain letters only");
                    break;
                case ParseValidity.ClientPhone:
                    if (Regex.IsMatch(i_Input, @"^[0-9]+$") == false)
                        throw new FormatException("Client's phone must contain digits only");
                    break;
            }

        }


        private string GetLicencePlate()
        {
            string input;
            int plateLength = 6;
            do
            {
                Console.WriteLine("Enter license plate number");
                input = Console.ReadLine();
            } while (CallToSpecialFormatCheck(input, plateLength, ParseValidity.LicencePlate));
            return input;
        }



        private void CheckLengthAndSpecialFormatValidity(string i_Input, int i_Length, ParseValidity i_Format)
        {
            if (i_Input.Length < i_Length)
            {
                string msg = string.Format(@"The parameter must be {0} at least signs long", i_Length);
                throw new FormatException(msg);
            }
            SpecialFormatCheck(i_Input, i_Format);
        }


        private bool CallToSpecialFormatCheck(string i_Input, int i_Length, ParseValidity i_Format) 
        {
            bool returnStatement = true;
            try
            {
                CheckLengthAndSpecialFormatValidity(i_Input, i_Length, i_Format);
                returnStatement = false;
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
                
            }
            return returnStatement;
        }


        private string GetClientPhone()
        {
            string input;
            int phoneLength = 10;
            do
            {
                Console.WriteLine("Enter client's phone number");
                input = Console.ReadLine();
            } while (CallToSpecialFormatCheck(input, phoneLength, ParseValidity.ClientPhone));
            return input;
        }


        private string GetClientName()
        {
            string input;
            int nameLength = 2;
            do
            {
                Console.WriteLine("Enter client's name");
                input = Console.ReadLine();
            } while (CallToSpecialFormatCheck(input, nameLength, ParseValidity.ClientName));
            return input;
        }

        private void BuildRequests(string i_LicensePlate, ref bool io_IsElectric)
        {

            // Vehicle vehicle=null;
            Console.Clear();
            Console.WriteLine("Fill the data about the vehicle");
            string vehicleType = SelectType();
            float energyRemained = EnergyRemained();

            BuildGeneralRequest(i_LicensePlate, vehicleType, energyRemained);

            if (vehicleType.Equals("truck") == false)
            {
                io_IsElectric = IsElectric();
            }

            if (vehicleType.Equals("car"))
            {
                Doors numOfDoors = GetNumberOfDoors();
                CarColor carColor = GetColor();
                m_VehicleType = VehicleType.Car;
                
                m_VehicleRequest = new CarRequest(carColor, numOfDoors);
            }
            else if (vehicleType.Equals("bike"))
            {
                DrivingLicenceCategory licenseCategory = GetLicenseCategory();
                m_VehicleType = VehicleType.Bike;
                
                m_VehicleRequest = new BikeRequest(licenseCategory);
            }
            else if (vehicleType.Equals("truck"))
            {
                bool trunkIsChilled = DoesTheTrunkHaveARefrigerator();
                float trunkVolume = GetTrunkVolume();
                m_VehicleType = VehicleType.Truck;
                
                m_VehicleRequest = new TruckRequest(trunkVolume, trunkIsChilled);
            }
            AddWheelsToRequest(m_VehicleType);

        }

        private float GetTrunkVolume()
        {
            float volume = 0.0f;
            do
            {
                Console.WriteLine("Enter trunk volume");
                 CallToTryParse<float>(ref volume, Console.ReadLine());
                ;
            } while (m_Flag || CheckIfInDomainSet(volume, volume));
            return volume;
        }

        private bool DoesTheTrunkHaveARefrigerator()
        {
            string input;
            do
            {
                Console.WriteLine(@"Does the truck have a refrigerator?
1 - Yes
2 - No");
                input = Console.ReadLine();
            } while (!(input.Equals("1") || input.Equals("2")));

            return input == "1";
        }

        private int GetEngineCC()
        {
            int engineCC = 0;
            string input;
            do
            {
                Console.WriteLine("Enter engine CC");
                input = Console.ReadLine();

                 CallToTryParse<int>(ref engineCC, Console.ReadLine());
            } while (m_Flag || CheckIfInDomainSet(engineCC, engineCC));
            return engineCC;
        }


        private DrivingLicenceCategory GetLicenseCategory()
        {
            int category;
            string input;
            DrivingLicenceCategory licenseCategory;
            do
            {
                Console.WriteLine(@"Select license category:
1 - A1
2 - A2
3 - AB
4 - B");
                input = Console.ReadLine();
                
            } while (int.TryParse(input, out category) == false || Enum.IsDefined(typeof(DrivingLicenceCategory), category) == false);

            licenseCategory= (DrivingLicenceCategory)Enum.Parse(typeof(DrivingLicenceCategory), input);
            return licenseCategory;
        }

        private CarColor GetColor()
        {
            int color;
            string input;
            CarColor carColor;
            do
            {
                Console.WriteLine(@"Select car color
1 - Grey
2 - White
3 - Green
4 - Violet");
                input = Console.ReadLine();
                
            } while (int.TryParse(input, out color) == false || Enum.IsDefined(typeof(CarColor), color) == false);


            carColor = (CarColor)Enum.Parse(typeof(CarColor), input);
            return carColor;
        }

        private float EnergyRemained()
        {
            float percent = 0.0f;
            float upperBound = 100.0f;
            do
            {

                Console.WriteLine("Energy remained(in percent)");
                CallToTryParse<float>(ref percent, Console.ReadLine());
            } while (m_Flag || CheckIfInDomainSet(percent, upperBound));
            return percent;
        }






        public static T TryParse<T>(string inValue)
        {
            TypeConverter converter =
                TypeDescriptor.GetConverter(typeof(T));

            return (T)converter.ConvertFromString(null,
                CultureInfo.InvariantCulture, inValue);
        }


        private void CallToTryParse<T>(ref T inVariable, string inValue)
        {
            try
            {
                inVariable = TryParse<T>(inValue);
                m_Flag = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                m_Flag = true;
                return;
            }

            
        }


        private bool CheckIfInDomainSet(float i_CurrentValue, float i_MaxValue)
        {
            bool returnStatement = true;
            try
            {
                Vehicle.CheckIfInTheRange(i_CurrentValue, i_MaxValue);
                returnStatement = false;
            }
            catch (ValueOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
            }

            return returnStatement;
        }



        private void GetCurrentPressure(ref float i_CurrentPressure, float i_MaximumPressure, int i_Index)
        {
            do
            {
                Console.WriteLine("{0} current wheel pressure", i_Index);
                CallToTryParse<float>(ref i_CurrentPressure, Console.ReadLine());
            } while (m_Flag || CheckIfInDomainSet(i_CurrentPressure, i_MaximumPressure));
        }



        private void AddWheelsToRequest(VehicleType i_Type)
        {
            float maximumPressure = 0.0f;
            //DON'T pass number of wheels here, use your VehicleType enum 

            int numberOfWheels = m_Logic.GetNumberOfWheels(i_Type);

            maximumPressure = m_Logic.GetMaxPressure(i_Type);
            CheckIfInDomainSet(maximumPressure, maximumPressure);

            for (int i = 1; i <= numberOfWheels; i++)
            {

                float currentPressure = 0.0f; ;
                Console.WriteLine("{0} wheel manufacturer", i);
                string manufacturer = Console.ReadLine();

                GetCurrentPressure(ref currentPressure, maximumPressure, i);

                if (currentPressure > 0.0f)//Do we need this statement if 
                    m_GeneralRequest.AddWheel(manufacturer, currentPressure, maximumPressure);
            }
        }
        private void BuildGeneralRequest(string i_LicencePlate, string i_VehicleType, float i_EnergyRemained)
        {
            Console.WriteLine("Enter vehicle model");
            string model = Console.ReadLine();

            m_GeneralRequest = new GeneralRequest(model, i_LicencePlate, i_EnergyRemained);


        }
        private Doors GetNumberOfDoors()
        {
            string input;
            int checkInput;
            Doors carDoors;
            bool invalidInput = true;
            do
            {
                Console.WriteLine("Select number of doors (2/3/4/5)");
                input = Console.ReadLine();
                if (int.TryParse(input, out checkInput) && Enum.IsDefined(typeof(Doors), checkInput))
                {
                    invalidInput = false;
                }
            } while (invalidInput);

            carDoors = (Doors)Enum.Parse(typeof(Doors), input);
            return carDoors;
        }


        private string SelectType()
        {
            string input;
            do
            {
                Console.WriteLine(@"Write your vehicle type
car / bike / truck");
                input = Console.ReadLine();
            } while (!(input.Equals("car") || input.Equals("bike") || input.Equals("truck")));
            return input;
        }

        private bool IsElectric()
        {
            bool isElectric = false;
            bool correctInput = false;
            string input;
            do
            {
                Console.WriteLine(@"Does the vehicle have electric engine?
Type 'yes' or 'no'");
                input = Console.ReadLine();
                if (input == "yes")
                {
                    isElectric = true;
                    correctInput = true;
                }
                else if (input == "no")
                {
                    correctInput = true;
                }
            } while (!correctInput);
            return isElectric;
        }

        public void OutputByStatusFilter(VehicleStatus i_State)
        {
            foreach (string key in m_Logic.HashTable.Keys)
            {
                if (m_Logic.HashTable[key].CarStatus == i_State)
                {
                    string output = string.Format(@"Licence Plate : {0}     Status: {1}
                    ", m_Logic.HashTable[key].Vehicle.LicencePlate, m_Logic.HashTable[key].CarStatus);
                    Console.WriteLine(output);
                }
            }

        }


        public void PumpUpTyres(string i_Key)
        {
            if (m_Logic.HashTable.ContainsKey(i_Key))
            {
                try
                {
                    foreach (Wheel wheel in m_Logic.HashTable[i_Key].Vehicle.WheelSet)
                    {
                        if (wheel.MaxPressure - wheel.CurrentPressure > 0)
                            wheel.InflateTyre(wheel.MaxPressure - wheel.CurrentPressure);
                    }
                }
                catch (ValueOutOfRangeException outOfRangeEx)
                {
                    Console.WriteLine(outOfRangeEx.Message);
                    return;
                }

                m_Logic.TryToChangeStatus(i_Key, VehicleStatus.repaired);
            }

            else
                Console.WriteLine("The requested vehicle is not found");
        }


        public VehicleStatus GetStatusForChange()
        {
            string input = "";
            int choice;
            do
            {
                Console.WriteLine("Please enter a value for a new status : Repaired - 2, Paid-3");
                input = Console.ReadLine();
            } while (int.TryParse(input, out choice) == false || Enum.IsDefined(typeof(VehicleStatus), choice) == false);

            VehicleStatus carStatus = (VehicleStatus)Enum.Parse(typeof(VehicleStatus), input);

            return carStatus;

        }

        public FuelType ChooseFuel()
        {
            string input = "";
            int choice;
            do
            {
                Console.WriteLine(@"Please choose an appropriate fuel to refill a vehicle : 
                1-Solar 
                2-Octan95
                3-Octan96
                4-Octan98
                5-Electricity");
                input = Console.ReadLine();
            } while (int.TryParse(input, out choice) == false || Enum.IsDefined(typeof(FuelType), choice) == false);

            FuelType type = (FuelType)Enum.Parse(typeof(FuelType), input);

            return type;

        }

        private float GetValueToRefillAVehicle(string i_Key)
        {
            float quantity = 0.0f;
            Console.WriteLine("You need to fill {0} to maximum", m_Logic.NeededToMaxLevelOfEnergy(i_Key));
            do
            {
                Console.WriteLine("Enter a number of minutes/litres to refill the vehicle/charge the battery");
                CallToTryParse<float>(ref quantity, Console.ReadLine());
            } while (CheckIfInDomainSet(quantity, quantity) || m_Flag);
            return quantity;

        }



        public void FillTankOrChargeBattery(string i_Key, FuelType i_KindOfFuel)
        {
            if (m_Logic.HashTable.ContainsKey(i_Key))
            {
                float quantity = GetValueToRefillAVehicle(i_Key);
                try
                {
                    m_Logic.HashTable[i_Key].Vehicle.Engine.RefuelVehicle(quantity, i_KindOfFuel);
                    m_Logic.HashTable[i_Key].Vehicle.UpdateEnergyLvl();
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                    return;
                }
                catch (ValueOutOfRangeException outOfRange)
                {
                    Console.WriteLine(outOfRange.Message);
                    return;
                }
                m_Logic.TryToChangeStatus(i_Key, VehicleStatus.repaired);
            }
            else
                Console.WriteLine("The requested vehicle is not found");
        }

        public void FullVehicleDescription(string i_Plate)
        {
            string message = string.Format(@"
            Owner's name : {0}
            Car status : {1}
            ", m_Logic.HashTable[i_Plate].ContactPerson.Name, m_Logic.HashTable[i_Plate].CarStatus);

            Console.WriteLine(message);
            Console.WriteLine(m_Logic.HashTable[i_Plate].Vehicle.ToString());
        }




    }
}