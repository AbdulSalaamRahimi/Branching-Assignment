using System;

class ShippingCalculator
{
    static void Main(string[] args)
    {
        // Welcome the user and provide instructions on how to proceed
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Requesting the user to enter the package's weight and converting the input to a double
        Console.Write("Enter the weight of your package: ");
        double pkgWeight = Convert.ToDouble(Console.ReadLine());

        // Check if the package weight exceeds the transportable limit
        if (pkgWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Terminate the program if the weight is too high
        }

        // Requesting the user to input the package's width and converting it to double
        Console.Write("Enter the width of your package: ");
        double pkgWidth = Convert.ToDouble(Console.ReadLine());

        // Requesting the user to input the package's height and converting it to double
        Console.Write("Enter the height of your package: ");
        double pkgHeight = Convert.ToDouble(Console.ReadLine());

        // Requesting the user to input the package's length and converting it to double
        Console.Write("Enter the length of your package: ");
        double pkgLength = Convert.ToDouble(Console.ReadLine());

        // Summing up the total dimensions of the package
        double dimensionSum = pkgWidth + pkgHeight + pkgLength;

        // Validate if the summed dimensions exceed the permissible limit
        if (dimensionSum > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Terminate the program if dimensions are too large
        }

        // Calculate the cost to ship the package
        double shippingCost = (pkgHeight * pkgWidth * pkgLength * pkgWeight) / 100;

        // Displaying the calculated shipping cost to the user
        Console.WriteLine($"The estimated shipping cost for your package is: ${shippingCost:F2}");

        // Final message to thank the user
        Console.WriteLine("Thank you for using Package Express!");
    }
}
