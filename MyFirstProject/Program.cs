// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // HELLO WORLD
            Console.WriteLine("Hello, World!");

            // NUMBERS
            int age = 23;
            Console.WriteLine(age);

            long bigNumber = 9000000000L; // defaults to int32, but for longs we want int64, so L has to be appended at the end
            // by default, C# treats all numbers as ints unless you specify otherwise
            Console.WriteLine(bigNumber);

            double negative = -55.2D; // Same as above, D may have to be appended for Doubles
            float precision = 5.000001F; // defaults to Double, but we want a Float, so append F
            decimal money = 14.99M; // defaults to Double, use M for decial (M for Money, D was already used for Double)

            // multi init/declare/assign (for same data type)
            int x, y, z;
            int a = 1, b = 2, c = 3;

            // TEXT
            string name = "Aba";
            char letter = 'a';
            // double quotes for string, single quotes for char
            // strings can be empty, chars cannot
            // default char is \0

            // CONVERT STRINGS TO NUMBERS
            string textAge = "-23";
            int numAge = Convert.ToInt32(textAge);

            string textBigNumber = "900000000"; // L not needed becasuse we're specifically calling ToInt64 below
            long bigNumberDouble = Convert.ToInt64(textBigNumber);

            string textNegative = "-55.2";
            double negativeDouble = Convert.ToDouble(textNegative);

            string textPrecision = "5.000001";
            float floatPrecision = Convert.ToSingle(textPrecision); // Single = Float, for some reason

            string textMoney = "14.99";
            decimal moneyMoney = Convert.ToDecimal(moneyMoney);

            // BOOLEANS
            bool value = false;
            bool isMale = true;

            // OPERATORS
            // (+ - * / %)
            int years = 23;
            years++;
            years--;
            // when dividing, best to make the variables doubles for the decimals/remainders
       
            // VARS AND CONSTS



            Console.ReadLine(); // prevents program from terminating until user hits Enter
        }
    }
}
