using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "hello world!";
            Console.WriteLine(ReverseString(inputString));
            Console.WriteLine(UppercaseWords(inputString));

            Console.ReadKey();
        }
        #region First charactor upper case of sentence
        static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();
            if(array.Length>=1)
            {
                if(char.IsLower(array[0]))
                {
                    array[1] = char.ToUpper(array[1]);
                }
            }
            for(int i=1; i<array.Length; i++)
            {
                if(array[i-1]==' ')
                {
                    if(char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i+1]);
                    }
                }
            }
            return new string(array);
        }
        #endregion
        #region Reverse string

        static string ReverseString(string value)
        {
            Stack stk1 = new Stack(value.Length);
            foreach (char c in value)
                stk1.Push(c);
            string revString = null;
            foreach (char c in value)
                revString += stk1.Pop();
            return revString;
        }
        #endregion

    }
}
