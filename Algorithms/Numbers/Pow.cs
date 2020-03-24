namespace Algorithms
{
    partial class Program
    {
        //Recursive function that returns Power Xn
        public static double Pow(double x, int num)
        {
            if (num == 0) return 1.0;
            return x * Pow(x, num - 1);
        }
    }
}