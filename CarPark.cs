namespace ca1_oop_70999
{
    public abstract class CarPark
    {
        public string Name { get; }
        protected readonly double hourlyRate;
        protected readonly double maxCharge;
        protected double totalReceipts;

        public CarPark(string name, double hourlyRate, double maxCharge)
        {
            Name = name;
            this.hourlyRate = hourlyRate;
            this.maxCharge = maxCharge;
            totalReceipts = 0;
        }

        public abstract double CalculateCharges(double hoursParked);

        public void DisplayCharges(double hoursParked)
        {
            double charge = CalculateCharges(hoursParked);
            totalReceipts += charge;
            Console.WriteLine($"Car parked at {Name}: {hoursParked} hours, Charge: €{charge:F2}");
        }

        public double GetTotalReceipts()
        {
            return totalReceipts;
        }
    }
}
