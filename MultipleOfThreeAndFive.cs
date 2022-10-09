using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__CodeWars
{
    public partial class Kata
    {
        public static int Solution(int value)
        {
            int count = 0;
            // Magic Happens
            for (int i = 0; i < value; i++)
            {
                if (value <= 0)
                {
                    return 0;
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    count += i;
                }
            }
            return count;
        }
    }
}

