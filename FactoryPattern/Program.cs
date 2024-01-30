namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of tires your request vehicle has:");
            int wheelCount = int.Parse(Console.ReadLine());
            if (wheelCount == 2)
            {
                VehicleFactory.GetVehicle(wheelCount);
            }    
            else
            {
                VehicleFactory.GetVehicle(wheelCount);
            }
            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();

        }
    }
}
