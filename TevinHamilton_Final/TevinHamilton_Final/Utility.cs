using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_Final
{
    class Utility
    {
        //
        // validation
        //
        //
        //string validation
        //
        public static string StringValidate(string prompt)
        {
            Console.WriteLine(prompt);
            string stringResults = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(stringResults))
            {
                Console.WriteLine($"{prompt}\r\n");
                stringResults = Console.ReadLine();
            }
            return stringResults;

        }
        //
        // int validation
        //
        public static int IntValidate(string prompt)
        {
            Console.WriteLine(prompt);
            string responds = Console.ReadLine();
            int intResult;
            while (!int.TryParse(responds, out intResult))

            {
                Console.WriteLine("please enter a whole number\r\n");
                Console.WriteLine(prompt);
                responds = Console.ReadLine();
            }
            return intResult;
        }
        //
        // decimal validation
        //
        public static decimal DecimalValidate(string prompt)
        {
            Console.WriteLine(prompt);
            string responds = Console.ReadLine();
            decimal decimalResult;
            while (!(decimal.TryParse(responds, out decimalResult)))
            {
                Console.WriteLine("please enter a whole number\r\n");
                Console.WriteLine(prompt);
                responds = Console.ReadLine();
            }
            return decimalResult;
        }
        //
        // double validation
        //
        public static double DoubleValidate(string prompt)
        {
            Console.WriteLine(prompt);
            string responds = Console.ReadLine();
            double doubleResult;
            while (!(double.TryParse(responds, out doubleResult)))
            {
                Console.WriteLine("please enter a whole number\r\n");
                Console.WriteLine(prompt);
                responds = Console.ReadLine();
            }
            return doubleResult;

        }
        //
        // float validation
        //
        public static float FloatValidate(string prompt)
        {
            Console.WriteLine(prompt);
            string responds = Console.ReadLine();
            float floatResult;
            while (!(float.TryParse(responds, out floatResult)))
            {
                Console.WriteLine("please enter a whole number\r\n");
                Console.WriteLine(prompt);
                responds = Console.ReadLine();
            }
            return floatResult;
        }
        //
        // phone number validation
        //
        public static void PhoneValidation()
        {
            Console.WriteLine("please enter a 10 deight phone numeber (xxx)xxx-xxxx.\r\n\r\nPlease enter your phone number like the example above.");
            string numberString = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(numberString) || (numberString.Length != 14))
            {
                Console.WriteLine("\r\nthe phone number you have enter is invalid");
                Console.WriteLine("\r\nplease enter a 10 deight phone numeber (xxx)xxx-xxxx.\r\n\r\nPlease enter your phone number like the example above.");
                numberString = Console.ReadLine();
            }
            if (numberString.IndexOf('(') != 0 || (numberString.IndexOf(')') != 4) || (numberString.IndexOf(' ') != 5) || (numberString.IndexOf('-') != 9))
            {
                while (numberString.IndexOf('(') != 0 || (numberString.IndexOf(')') != 4) || (numberString.IndexOf(' ') != 5) || (numberString.IndexOf('-') != 9))
                {
                    while (true)
                    {
                        Console.WriteLine("phone is not valid");
                    }
                }
            }
            else
            {
                string isValid = ("your phone number is valid");
            }

        }
        //
        //
        // Math problems 
        //
        //Get Average 
        //
        public static float GetAverage(int[] num)
        {
            int addNum = 0;
            for (int i = 0; i < num.Length; i++)
            {

                addNum += num[i];
            }
            //float total = addNum / num.Length;
            //or
            return addNum / num.Length;
        }
        //
        // get Sqrt root 
        //
        public static float GetSqrt()
        {
            float sqrt = FloatValidate("please enter the number you want to be squared");
            sqrt = (float)Math.Sqrt(sqrt);
            return sqrt;
        }
        //
        // add nums
        //
        public static int AddingWholeNumbers(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }
            int[] numToAdd = new int[num];
            int addNum = 0;
            for (int i = 0; i < numToAdd.Length; i++)
            {

                addNum += numToAdd[i];
            }
            return addNum;
        }
        public static double AddingDouble(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }
            double[] numToAdd = new double[num];
            double addNum = 0;
            for (int i = 0; i < numToAdd.Length; i++)
            {

                addNum += numToAdd[i];
            }
            return addNum;
        }
        public static decimal AddingDecimal(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }
            decimal[] numToAdd = new decimal[num];
            decimal addNum = 0;
            for (int i = 0; i < numToAdd.Length; i++)
            {

                addNum += numToAdd[i];
            }
            return addNum;
        }
        //
        //subtraction number 
        //
        public static int SubtractWholeNumbers(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }
            int[] numToAdd = new int[num];
            int addNum = 0;
            for (int i = 0; i < numToAdd.Length; i++)
            {

                addNum -= numToAdd[i];
            }
            return addNum;
        }
        public static double SubtractDouble(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }
            double[] numToAdd = new double[num];
            double addNum = 0;
            for (int i = 0; i < numToAdd.Length; i++)
            {

                addNum -= numToAdd[i];
            }
            return addNum;
        }
        public static decimal SubtractDecimal(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }
            decimal[] numToAdd = new decimal[num];
            decimal addNum = 0;
            for (int i = 0; i < numToAdd.Length; i++)
            {

                addNum -= numToAdd[i];
            }
            return addNum;
        }
        //
        //secirty
        //
        public static string UserName(string prompt)
        {
            Console.WriteLine(prompt);
            string userName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userName))
            { Console.WriteLine(prompt); userName = Console.ReadLine(); }
            return userName;
        }
        public static string Password(string prompt)
        {
            Console.WriteLine(prompt);
            string password = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(password))
            { Console.WriteLine(prompt); password = Console.ReadLine(); }
            return password;
        }
        public static int FourDightPin(string prompt)
        {
            Console.WriteLine(prompt);
            string pinNumString = Console.ReadLine();
            int pinNum;
            while (!int.TryParse(pinNumString, out pinNum)) { Console.WriteLine(prompt); pinNumString = Console.ReadLine(); }
            return pinNum;
        }
        //
        //verficattion
        //
        public static void StringVerify(string one, string two, string prompt)
        {
            Console.WriteLine(prompt);

            if (one == two) { Console.WriteLine("correct you may proceed"); }
            else { while (one != two) { Console.WriteLine("please enter the right password"); } }
        }
        //
        //
        //
        public static int YesOrNoValidation(string prompt) 
        {
           int userChoice = IntValidate(prompt);
            while (userChoice >= 3 || userChoice < 1)
            {
                Console.WriteLine("please only choice 1 or 2 for yes or no");
                userChoice = IntValidate(prompt);
            }
            return userChoice;

        }
        
       

    }
}
