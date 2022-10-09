namespace C__CodeWars
{
    public partial class Kata
    {
        public static bool Check(object[] a, object x)
        {
            return Array.IndexOf(a, x) != -1 ? true : false;
        }
    }
}