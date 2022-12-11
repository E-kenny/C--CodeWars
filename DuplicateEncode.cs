using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars
{
    public partial class Kata
    {
        public static string DuplicateEncode(string input)
        {
            input= input.ToLower();
            Dictionary<char,int> result = new Dictionary<char,int>();
            var newString = "";

            foreach (var key in input.ToLower())
            {
                if (result.ContainsKey(key))
                {
                    result[key] += 1;
                }
                else
                {
                    result[key] = 1;
                }
            }

            for(int i = 0; i < input.Length; i++)
            {
                if (result[input[i]] > 1)
                {
                    newString += ")";
                }
                else
                {
                    newString += "(";
                }
            }
            return newString;
        }
    }
}

//https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp
//The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

//Examples
//"din"      =>  "((("
//"recede"   =>  "()()()"
//"Success"  =>  ")())())"
//"(( @"     =>  "))((" 
