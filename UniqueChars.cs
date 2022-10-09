namespace C__CodeWars
{
    public class Challenge
    {
        public static bool HasUniqueChars(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}



