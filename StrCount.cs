
namespace C__CodeWars
{
    public partial class Kata
    {
        public static int StrCount(string str, string letter)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }
}