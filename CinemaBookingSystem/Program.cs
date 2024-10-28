namespace CinemaBookingSystem;

internal class Program
{
    static void Main(string[] args)
    {
        int ticketPrice = 50;
        Console.WriteLine("Welcome To Ticket Booking");
        Console.WriteLine("Ticket Price for today is {0}", ticketPrice);
        Console.WriteLine("Enter No. of tickets do you want to book");
        int ticketCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your total booking Price for {0} tickets is {1}", ticketCount, ticketCount * ticketPrice);
        Console.WriteLine("Press 1 for ticket Confirmation ");
        int confirmation = Convert.ToInt32(Console.ReadLine());
        if (confirmation == 1)
        {
            Console.WriteLine("Ticket Confirmed...");
        }
        else
        {
            Console.WriteLine("Ticket Cancelled...");

        }
        Console.WriteLine(" cheack your seat number ");
        int seat = Convert.ToInt32(Console.ReadLine());
        if (confirmation == 1)
        {
            Console.WriteLine("");

        }
        if (ticketCount >= 1000)
        {
            Console.WriteLine("You will get offer on food and cold drinks!!!");
        }
        else
        {
            Console.WriteLine("NO any offer under 1000rs");
        }

        int seat = 3;

        switch (seat);

        


        {

            Console.WriteLine("Front Seat:{FrontSeat},Middle Seat:{MiddleSeat}, Back Seat:{BackSeat}");
        }
        switch (Seats)
        {
            case 1 Frontseat:

                Console.WriteLine(" Front Seat Booked ");
                break;
            case 2  MiddleSeat:

                Console.WriteLine("Middle seat booked.");
                break;
            case 3 BackSeat:

                Console.WriteLine("Back seat booked.");
              break;
        }
    }
}





    
