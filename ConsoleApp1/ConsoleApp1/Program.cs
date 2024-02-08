using System;

class Program1
{
    static void Main()
    {
        // Question 1
        Console.Write($"Question 1 \n");
        // Print for user to enter age
        Console.WriteLine("Enter age:");

        // Read the user's input and parse it to an integer
        int age = int.Parse(Console.ReadLine());

        // Calculate the year of birth
        int presentYear = DateTime.Now.Year;
        int yOB = presentYear - age;

        // Display the year of birth
        Console.WriteLine($"Your year of birth is {yOB}");

        //Question 2
        Console.Write("Question 2 \n");
        // Print for user to enter a, b, c, and x
        Console.Write("Enter a (int): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b (int): ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c (int): ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Enter x (double): ");
        double x = double.Parse(Console.ReadLine());

        // Calculating polynomial
        double aPlusB = a + b;
        double aPlusBTimesHalf = aPlusB / 2;
        double aPlusBTimes2 = aPlusB * aPlusB;
        double xSquared = x * x;
        double xCubed = x * x * x;

        double polynomialValue = (aPlusBTimesHalf * xCubed) + (aPlusBTimes2 * xSquared) + (a + b + c);

        // Output
        Console.WriteLine($"The value of polynomial is {polynomialValue}");

        //Question 3
        Console.Write("Question 3 \n");
        // Print for user to enter of xx and yy
        Console.Write("Enter xx: ");
        int xx = int.Parse(Console.ReadLine());

        Console.Write("Enter yy: ");
        int yy = int.Parse(Console.ReadLine());

        // Display before swapping
        Console.WriteLine($"Before swapping: xx: {xx}; yy: {yy};");

        // Swaping xx and yy using a temp variable
        int temp = xx;
        xx = yy;
        yy = temp;

        // Output after swaping
        Console.WriteLine($"After swapping: xx: {xx}; yy: {yy};");

        //Questin 4
        // Print to enter the amount received
        Console.Write("Question 4 \n");
        Console.Write("How much amount did you receive ($)? ");
        double amountReceived = double.Parse(Console.ReadLine());

        // Amount  for books and supplies
        double booksAndSupplies = amountReceived * 0.75;

        // Amount after buying books and supplies
        double remainingAmount = amountReceived - booksAndSupplies;
        double divEqual = remainingAmount / 3;
        

        int coffees = (int)Math.Floor(divEqual / 2);
        int flashComputers = (int)Math.Floor(divEqual / 4);
        int subwayTickets = (int)Math.Floor(divEqual / 3);

        // Amount for books and supplies
        Console.WriteLine($"Book and Supplies: {booksAndSupplies} $");

        // Amounts for remaining expense
        Console.WriteLine("You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputers} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");

        // Calculate amount for white roses
        double flowersMoney = amountReceived - booksAndSupplies - (coffees * 2) - (flashComputers * 4) - (subwayTickets * 3);

        // Print amount for white roses
        Console.WriteLine($"and you will have {flowersMoney} dollars for the white roses.");
    }
}

