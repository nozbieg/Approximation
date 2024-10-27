// See https://aka.ms/new-console-template for more information

using Approximation;

PritnStudentInfo();

var arrayX =new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var arrayY = new int[] {10,18,22,27,36,49,56,64,70,78 };

var approx = Approx.CalculateLineApproximationOneVariable(arrayX, arrayY);
Approx.PrintResult(approx, arrayX, arrayY);


FinishProgram();

static void FinishProgram()
{
    Console.WriteLine();
    Console.WriteLine("===");
    Console.WriteLine("Program completed.");
    Console.WriteLine("Press Enter to close.");
    Console.WriteLine("===");
    Console.ReadLine();
    Environment.Exit(0);
}

static void PritnStudentInfo()
{
    Console.WriteLine("=== ===");
    Console.WriteLine("=== Approximation ===");
    Console.WriteLine("=== Norbert Olesiak-Zbieg ===");
    Console.WriteLine("=== Informatyka II Stopnia ===");
    Console.WriteLine("=== nr albumu 41237 ===");
    Console.WriteLine("=== ===");
    Console.WriteLine();
}