using System;

namespace VariadicFunctionsExample
{
    class Program
    {
        public static void VariadicExample(params int[] list)
        {
            int total = 0;
            for (int i = 0; i < list.Length; i++)
            {
                total += list[i];
            }

            Console.WriteLine("The total is " + total.ToString());
        }

        static void Main(string[] args)
        {
            // You can send a comma-separated list of arguments of the
            // specified type.  There is no limit to the number other than practical
            // considerations for memory and processor speed.

            VariadicExample(1, 2, 3, 4);
            VariadicExample(100, 213, 432, 123, 234, 123, 643, 785, 934);

            // A params parameter accepts zero or more arguments.
            // If you call without args you'll get zero.

            VariadicExample();

            // An array argument can be passed, as long as the array
            // type matches the parameter type of the method being called.

            int[] myIntArray = { 5, 6, 7, 8, 9 };
            VariadicExample(myIntArray);
        }
    }
}
