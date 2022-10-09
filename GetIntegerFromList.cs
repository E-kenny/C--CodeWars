using System.Collections;
using System.Collections.Generic;

namespace C__CodeWars
{
    public partial class Kata
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> Num = new List<int>();
            foreach (var item in listOfItems)
            {
                if (item.GetType().Equals(typeof(int)))
                {
                    Num.Add((int)item);
                }
            }
            return Num;
        }
    }
}