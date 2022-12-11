using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars
{
    public partial class Kata
    {
        public static char FindMissingLetter(char[] array)
        {
            
            string totalCharLower = "abcdefghijklmnopqrstuvwxyz";
            string totalSubstringLower = totalCharLower.Substring(totalCharLower.IndexOf(array[0]), array.Length);
            string totalCharUpper = totalCharLower.Substring(totalCharLower.IndexOf(array[0]), array.Length);
            
            for (int i = 0; i < array.Length; i++)
            {
                if (!array.Contains(totalSubstringLower[i]) || !array.Contains(totalCharUpper[i])) 
                {
                    return totalSubstringLower[i];
                }
             
            }
            return ' ';
        }
    }
}
