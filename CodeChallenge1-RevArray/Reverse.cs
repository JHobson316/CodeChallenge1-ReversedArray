namespace CodeChallenge
{
    public class Reverse
    {
        public static void Rev(int[] ray)
        {
            int[] revRay = new int[ray.Length];
            int counter = 0;

            for (int i = ray.Length - 1; i == 0 ; i--)
            {
                revRay[counter++] = ray[i];
                Console.WriteLine(revRay[counter]);
            }
        }
    }
}