using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "hello world!";
            Console.WriteLine(UppercaseWords(inputString));
            Console.ReadKey();
        }
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
    }
}
