using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 3:
        // Using the Sample Output as info:
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");
    }
}