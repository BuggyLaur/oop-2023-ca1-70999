using Bogus;
using ca1_oop_70999;


class Program
{
    static void Main(string[] args)
    {
        List<CarPark> carParks = new List<CarPark>
        {
            new Garage1("Garage 1", 0.50, 10.00),
            new Garage2("Garage 2", 0.60, 10.00),
            new Garage3("Garage 3", 0.75, 10.00)
        };

        Random random = new Random();

        // Faker setup
        var faker = new Faker();
        var registrations = new List<string>();
        for (int i = 0; i < 24; i++)
        {
            registrations.Add(faker.Random.AlphaNumeric(6));
        }

        // Sample Data
        int[] carsInOneDay = { 10, 6, 8 }; // Number of cars parked in each car park

        // Simulate one day
        for (int i = 0; i < carParks.Count; i++)
        {
            Console.WriteLine($"Car Park {i + 1} has {carsInOneDay[i]} cars in one day");

            for (int j = 0; j < carsInOneDay[i]; j++)
            {
                double hoursParked = random.Next(1, 25); // Randomly generate hours parked
                carParks[i].DisplayCharges(hoursParked);
            }

            Console.WriteLine($"Total receipts for {carParks[i].Name}: €{carParks[i].GetTotalReceipts():F2}\n");
        }

        double totalReceiptsAllGarages = 0;
        foreach (var park in carParks)
        {
            totalReceiptsAllGarages += park.GetTotalReceipts();
        }
        Console.WriteLine($"Total receipts for all garages: €{totalReceiptsAllGarages:F2}");
    }
}