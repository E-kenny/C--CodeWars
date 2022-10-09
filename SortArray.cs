using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.
//Examples
//[7, 1]  =>  [1, 7]
//[5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
//[9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]

namespace C__CodeWars
{
    public partial class Kata
    {
        public static int[] SortArray(int[] array)
        {
            List<int> value =new List<int>();
            List<int> index = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 1)
                {
                    value.Add(array[i]);
                    index.Add(i);
                }
            }
            value.Sort();
            index.Sort();

            for (int i = 0; i < index.Count; i++)
            {
                array[index[i]] = value[i];
            }

            return array;
        }
    }
}
