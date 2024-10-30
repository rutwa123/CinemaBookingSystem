namespace CinemaBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ticketPrice = 50;
            Console.WriteLine("Welcome to the Ticket Booking System");
            Console.WriteLine($"Today's Ticket Price: Rs {ticketPrice}");

            Console.WriteLine("Enter the number of tickets you want to book:");
            int ticketCount = Convert.ToInt32(Console.ReadLine());

            int totalPrice = ticketCount * ticketPrice;
            Console.WriteLine($"Your total booking price for {ticketCount} tickets is Rs {totalPrice}");

            Console.WriteLine("Press 1 to confirm your ticket booking, or any other key to cancel:");
            int confirmation = Convert.ToInt32(Console.ReadLine());

            if (confirmation == 1)
            {
                Console.WriteLine("Tickets Confirmed!");

                
                if (totalPrice >= 150)
                {
                    Console.WriteLine("Congratulations! You qualify for an offer on food and cold drinks.");
                }
                else
                {
                    Console.WriteLine("No offer available for bookings under Rs 150.");
                }

                
                Console.WriteLine("Please select your seat type:");
                Console.WriteLine("1. Front Seat\n2. Middle Seat\n3. Back Seat");
                int seatChoice = Convert.ToInt32(Console.ReadLine());

                switch (seatChoice)
                {
                    
                }
            }
            else
            {
                Console.WriteLine("Ticket Booking Cancelled.");
            }
            Console.WriteLine("Select your Meal:");
            Console.WriteLine("1.Cold Drink\n2.2.Frnch Fries\n3.3.Popcorn");
            int mealChoice= Convert.ToInt32(Console.ReadLine());

            switch (mealChoice)
            {




        }   }
    }
}






