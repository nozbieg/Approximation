
namespace Approximation
{
    public readonly struct ApproxResult(double P0, double P1)
    {
        public double P0 { get; } = P0;
        public double P1 { get; } = P1;
    }

    public static class Approx
    {

        public static ApproxResult CalculateLineApproximationOneVariable(int[] arrayX, int[] arrayY)
        {
            var sum1 = arrayX.Sum(v=> (long)v); //s1
            var sum2 = arrayY.Sum(v => (long)v); //s2
            var n = arrayX.Length;
            var sum3 = arrayX.Select(xi => xi * xi).Sum(v => (long)v); //s3
            var sum4 = arrayX.Zip(arrayY, (xi, yi) => xi * yi).Sum(v => (long)v); //s4

            var w = n * sum3 - sum1 * sum1;
            var w1 = sum2 * sum3 - sum4 * sum1;
            var w2 = n * sum4 - sum1 * sum2;

            double p0 = (double)w1 / w;
            double p1 = (double)w2 / w;

            return new ApproxResult(p0, p1);
        }







        public static void PrintResult(ApproxResult approxResult, int[] inputArrayX, int[] inputArrayY)
        {

            Console.WriteLine("=== ===");
            Utils.PrintArray(inputArrayX, "X");
            Console.WriteLine("=== ===");
            Utils.PrintArray(inputArrayY, "Y");
            Console.WriteLine("=== ===");
            Console.WriteLine();
            Console.WriteLine("=== ===");
            Console.WriteLine("Approximation result (rounded to 4)");
            Console.WriteLine($"P0: {Math.Round(approxResult.P0,4)} | P1: {Math.Round(approxResult.P1,4)}");
            Console.WriteLine("=== ===");
        }


    }



}
