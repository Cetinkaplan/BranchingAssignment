using System; // Imports the System namespace so we can use Console and other basic C# functionality.

namespace PackageExpress // Defines the namespace for the application.
{
    class Program // Defines the Program class.
    {
        static void Main(string[] args) // The Main method is where the program starts running.
        {
            // Display the required welcome message to the user.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight.
            Console.WriteLine("Please enter the package weight:");

            // Read the user's input and convert it from a string to a decimal number.
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check whether the package weight is greater than 50.
            if (weight > 50)
            {
                // Display the required error message if the package is too heavy.
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

                // End the program because the package cannot be shipped.
                return;
            }

            // Ask the user to enter the package width.
            Console.WriteLine("Please enter the package width:");

            // Read and convert the package width to a decimal number.
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package height.
            Console.WriteLine("Please enter the package height:");

            // Read and convert the package height to a decimal number.
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package length.
            Console.WriteLine("Please enter the package length:");

            // Read and convert the package length to a decimal number.
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Add the width, height, and length together to determine the total dimensions.
            decimal totalDimensions = width + height + length;

            // Check whether the total dimensions are greater than 50.
            if (totalDimensions > 50)
            {
                // Display the required error message if the package is too large.
                Console.WriteLine("Package too big to be shipped via Package Express.");

                // End the program because the package cannot be shipped.
                return;
            }

            // Multiply the height, width, and length together to calculate the package volume.
            decimal volume = height * width * length;

            // Multiply the package volume by the package weight.
            decimal shippingCalculation = volume * weight;

            // Divide the result by 100 to calculate the shipping quote.
            decimal quote = shippingCalculation / 100;

            // Display the final shipping quote formatted as a dollar amount with two decimal places.
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // Display the thank-you message.
            Console.WriteLine("Thank you!");
        }
    }
}