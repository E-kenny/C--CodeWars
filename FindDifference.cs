namespace C__CodeWars
{
    public partial class Kata
    {
        public static int FindDifference(int[] a, int[] b)
        {
            int aDim = 1;
            int bDim = 1;

            for (int i = 0; i < 3; i++)
            {
                aDim *= a[i];
                bDim *= b[i];
            }
            return aDim > bDim ? aDim - bDim : bDim - aDim;
        }
    }
}