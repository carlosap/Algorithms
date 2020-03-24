namespace Algorithms
{
    partial class Program
    {
        //Recursive function that returns the sum of the first 'n'
        //elements of an array (Horner's Metho 1+b*(1+b*(1+b*)))
        public static double SumArray(double[] a, int num)
        {
            if (num == 0) return 0.0;
            return SumArray(a, num - 1) + a[num - 1];
        }
    }
}