namespace C__CodeWars
{
    public partial class Kata
    {
        public static int FindShort(string s)
        {
            string lowest = "";
            int length = 0;
            string[] strArr = s.Split(' ');

            int count = 0;
            do
            {
                if (count == 0)
                {
                    lowest = strArr[0];
                    length = strArr[0].Length;
                }
                else if (lowest.Length > strArr[count].Length)
                {
                    lowest = strArr[count];
                    length = strArr[count].Length;
                }
                count++;
            } while (count < strArr.Length);

            return length;
        }
    }
}