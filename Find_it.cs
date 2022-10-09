using System;
namespace C__CodeWars
{
    public class Find_it
    {
        public int Find(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                if (count % 2 != 0)
                    return arr[i];
            }
            return -1;
        }

    }
}
 
