
namespace C__CodeWars
{
    public partial class Kata
    {
        //pass a string and an array
        public static string[] StringToArray(string str)
        {
            string[] arr = str.Split(" ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }
    }

}