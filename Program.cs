/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: Oct. 12, 2022
* Assignment CIS214 Performance Assessment - Loops & Calculations
*
* Main application (program) class.
* The main application class must meet the following requirements
* Print a line that states "Your Name - Week 2 PA Loops & Calculations"
*
* Demonstrate a counter-controlled loop
*   Calculate the sum of the integers from 1 to 10
*   Print the running total
*   Print the final total
*
* Demonstrate a condition-based loop
*   Ask the user to enter an integer value (-1 to quit)
*   Keep a running sum of the values
*   Keep a count of how many values the user has entered
*   Print the running total after each entry
*   Print the final sum of all values entered
*   Print a count of the values entered
*
\******************************************************************************/
public class LoopCalculation
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("\nJason D'Oyley - Week 2 PA Loops Calculations\n");

        // Demonstrate a counter-controlled loop
        // - Calculate the sum of the integers from 1 to 10
        // - Print the running total
        // - Print the final total
        Console.WriteLine("Calculate the sum of integers 1 - 10:");
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Console.WriteLine("Total so far: {0}", sum);

            if (i == 10)
            {
                Console.WriteLine("Final total: {0}", sum);
            }

        }
    }
}