namespace C__CodeWars
{
    public partial class Kata
    {
        public static int Divisors(int n)
        {
            int count = 1;
            // todo
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}