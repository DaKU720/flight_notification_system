using System;

namespace Easy_Flight_Notify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilFlight = random.Next(14); // generates a random day till the flight (max info display 14 days till the flight)
            int businessClassDisccount = random.Next(2, 7);
            int discountFoodAdvert = 0;

            Console.WriteLine($"OOC: [Days till flight: {daysUntilFlight}]");
            Console.WriteLine("");

            if (daysUntilFlight == 0) 
            {
                Console.WriteLine("Your Flight is TODAY!");
            }
            else if (daysUntilFlight == 1) 
            {
                discountFoodAdvert += 15;
                Console.WriteLine("TOMORROW is the day of your flight");
                Console.WriteLine($"Order an extra flight meal now and get {discountFoodAdvert}% discount!");
            }
            else if (daysUntilFlight <= 6) 
            {
                discountFoodAdvert += 5; 
                Console.WriteLine($"Please be aware that your fight is in {daysUntilFlight} days.");
                Console.WriteLine($"Order an extra flight meal now and get {discountFoodAdvert}% discount!");
            }
            else if (daysUntilFlight == 7) 
            {
                Console.WriteLine("Please be advised that your flight is in A WEEK.");
                Console.WriteLine($"Book an UPGRADE to the business class and get {businessClassDisccount}% discount now!");
            }
            else if (daysUntilFlight <= 14) 
            {
                Console.WriteLine("Please be aware that your flight date is APPROACHING.");
            }
        }
    }
}
