namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string vehicleType = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                decimal horsePower = decimal.Parse(tokens[3]);

                Vehicle vehicle = new Vehicle(vehicleType, model, color, horsePower);
                vehicles.Add(vehicle);
            }

            while((input = Console.ReadLine())!= "Close the Catalogue")
            {
                Vehicle foundVehicle = vehicles.Find(x => x.Model == input);
                if (foundVehicle != null)
                {
                    Console.WriteLine(foundVehicle);
                }
            }

            decimal averageHorsePower = vehicles.Where(x => x.VehicleType == "Car")
                .Select(x => x.HorsePower)
                .DefaultIfEmpty()
                .Average();

            Console.WriteLine($"Cars have average horsepower of: {averageHorsePower:F2}.");

            averageHorsePower = vehicles.Where(x => x.VehicleType == "Truck")
                .Select(x => x.HorsePower)
                .DefaultIfEmpty()
                .Average();

            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePower:F2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string vehicleType, string model, string color, decimal horsePower)
        {
            VehicleType = vehicleType;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        private string vehicleType;
        public string VehicleType
        {
            get
            {
                return vehicleType;
            }
            set
            {
                vehicleType = FirstLetterToUpper(value);
            }
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public decimal HorsePower { get; set; }

        public override string ToString()
        {
            string result = "";
            result += $"Type: {VehicleType}\n";
            result += $"Model: {Model}\n";
            result += $"Color: {Color}\n";
            result += $"Horsepower: {HorsePower}";
            return result;
        }

        public string FirstLetterToUpper(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }
    }
}