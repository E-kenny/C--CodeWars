using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Your task is to make a function that can take any non-negative
//integer as an argument and return it with its digits in descending order. Essentially,
//rearrange the digits to create the highest possible number.
//Examples:
//Input: 42145 Output: 54421
//Input: 145263 Output: 654321
//Input: 123456789 Output: 987654321

namespace C__CodeWars
{
    public partial class Kata
    {
        public static int DescendingOrder(int num)
        {
            string numString = num.ToString();
            char[] numArray = numString.ToCharArray();
            Array.Sort(numArray);
            Array.Reverse(numArray);
            string x = (string.Join("", numArray));
            return int.Parse(x);
        }
    }
}
