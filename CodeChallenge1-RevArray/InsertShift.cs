namespace CodeChallenge
{
    internal class InsertShift
    {
        public void ShiftIn(int[] ray, int num)
        {
            int i;
            int half = ray.Length / 2;
            int counter = 0;
            int[] Shifted = new int[ray.Length + 1];
            for (i = 0; i < half + 1; i++)
            {
                Shifted[i] = ray[i];
                counter++;
            }
            if (counter >= half)
            {
                Shifted[counter] = num;
                i++;
                //for (i < ray.Length;) { }
            }

        }
    }
}