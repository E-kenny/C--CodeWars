namespace C__CodeWars
{
    public partial class Kata
    {
        public static bool SetAlarm(bool employed, bool vacation)
        {
            return employed && !vacation ? true : false;
        }
    }
}