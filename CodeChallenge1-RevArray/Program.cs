using System;
namespace CodeChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start");
            int[] ray = {9,8,7,6,5,4,3,2,1,0};
            Rev(ray);
            //Shift(ray, 100);
            Console.WriteLine();
            Console.WriteLine("Close");
        }

        public static int[] Rev(int[] array)
        {
            int n = array.Length;
            int[] revRay = new int[n];
            int counter = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                revRay[counter] = array[i];
                counter++;
            }
            foreach(int i in revRay)
            {
                Console.WriteLine(i);
            }
            return revRay;
        }
        
    }
}