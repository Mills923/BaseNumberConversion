using System;
namespace NumberConversion
{
    public static class Util
    {
        public static string dec2bin(int number)
        {
           // int placeholder = 0;
           // 
           // int[] array = new int[10];

            string result = string.Empty;
            for ( int i = 0; 0 < number; i++)
            {
                result = number % 2 + result;
                number = number / 2;

            }
            return result;

            //return int.Parse(result);

            //for (i = i - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i]);
               
            //}
            //number = Int32.Parse(Console.ReadLine());
            //return number;

        }

        public static string dec2oct(int number)
        {
            string result = string.Empty;
           // int[] array = new int[15];
           // int i = 0;
            int remainder;

            while (number != 0)
            {
                remainder = number % 8;
                number = number / 8;
                result = remainder.ToString() + result;
            }

            return result;


            
        }
       
        public static string bin2dec(int number)
        {
            string input = number.ToString();
            string result = string.Empty;
            char[] array = input.ToCharArray();
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    if (i == 0)
                    {
                        sum += 1;

                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);

                    }
                }
            }



            return sum.ToString();
        }
       
        public static string bin2oct (int number)
        {
            int newNum;
            int j = 1;
            int num = 1;
            int holder = 0;
            int octal = 0;

            int result = number;

            for (int i = number; i > 0; i=i/10)
            {
                newNum = i % 10;
                if (j == 1)
                {
                    num = num * 1;
                }
                else
                {
                    num = num * 2;

                }
                holder = holder + (newNum * num);
                j++;

            }
            j = 1;
            for (int i = holder; i > 0; i=i/8)
            {
                octal = octal + (i % 8) * j;
                j = j * 10;
                result = result / 8;
            }

            return octal.ToString();


        }
       
        public static string oct2bin (int number)
        {
            int tempNum;
            int num = 0;
            int j = 1;
            int holder = 1;
            int binary = 0;

            string result = number.ToString();

            for (int i = number; i > 0; i=i/10)
            {
                tempNum = i % 10;
                if (j==1)
                {
                    holder = holder * 1;
                }
                else
                {
                    holder = holder * 8;
                }

                num = num + (tempNum * holder);
                j++;
            }

            j = 1;
            for (int i = num; i > 0; i = i / 2)
            {
                binary = binary + (num % 2) * j;
                j = j * 10;
                num = num / 2;
            }
            
            

            return binary.ToString();

        }
       
        public static string oct2dec (int number)
        {
            string result = string.Empty;
            int newNumber = 0;
            int holder = 0;

            while (number != 0)
            {
                newNumber += (number % 10) * (int)Math.Pow(8, holder);
                ++holder;
                number /= 10;
            }
            holder = 1;

            return newNumber.ToString();
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Please enter the integer to convert: ");
            string n1 = Console.ReadLine();
            int number = int.Parse(n1);

            Console.Write("Please enter the base to convert from [2 | 8 | 10] :");
            string n2 = Console.ReadLine();
            int from = int.Parse(n2);

            Console.WriteLine($"Number: {number}, base : {from}");
            int result = 0;

            if (from == 10)
            {
                result = Int32.Parse(Util.dec2bin(number));
                Console.WriteLine($"binary conversion is {result}");
                result = Int32.Parse(Util.dec2oct(number));
                Console.WriteLine($"octal conversion is {result}");
            }
            else if (from == 2)
            {
                result = Int32.Parse(Util.bin2dec(number));
                Console.WriteLine($"decimal conversion is {result}");
                result = Int32.Parse(Util.bin2oct(number));
                Console.WriteLine($"octal conversion is {result}");
            }
            else if (from == 8)
            {
                result = Int32.Parse(Util.oct2bin(number));
                Console.WriteLine($"binary conversion is {result}");
                result = Int32.Parse(Util.oct2dec(number));
                Console.WriteLine($"decimal conversion is{result}");
            }
            else
                Console.WriteLine("Error in base to convert from");
        }
    }
}
