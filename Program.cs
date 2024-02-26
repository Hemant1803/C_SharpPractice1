using System.Diagnostics;

namespace Interview_test
{
    internal class Program
    {
        static void Main(string[] args)
        {     bool Exit = false;
            
            while (!Exit)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("**********************************************************************************************************");
                Console.WriteLine("1.Count Digits in an Integer Number\n2.Reverse an Integer Number\n3.Palindrome Number\n4.Armstrong Number\n5.Reverse of Array\n6.Find Even and Odd Numbers in Array & Count the Even Numbers in Array" +
                    "\n7.Print Intreger Numbers Present at Even Location s in Array &  the Average of Numbers Present at Even Locations\n8.Sort the Array\n9.Exit");
                Console.WriteLine("Selet a Programe");
                int option = Convert.ToInt32(Console.ReadLine());
               
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter a Digit ");
                            string num = Console.ReadLine();
                            int length = 0;
                            for (int i = 0; i < num.Length; i++)
                            {
                                length++;
                            }
                            Console.WriteLine(length);
                           
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a Nmber");
                            int num = Convert.ToInt32(Console.ReadLine());
                            int remainder = 0;
                            int reverse = 0;

                            while (num != 0)
                            {
                                remainder = num % 10;
                                num /= 10;
                                reverse = reverse * 10 + remainder;
                            }
                            Console.WriteLine(reverse);
                            
                        }
                        break;
                    case 3:
                        {

                            Console.WriteLine("Enter a number to check it is palindrone or not");
                            int num = Convert.ToInt32(Console.ReadLine());
                            int temp = num;
                            int remainder = 0;
                            int reverse = 0;
                            while (num != 0)
                            {
                                remainder = num % 10;
                                num /= 10;
                                reverse = reverse * 10 + remainder;

                            }
                            if (reverse == temp)
                            {
                                Console.WriteLine("It's a Palindrone");
                            }
                            else
                                Console.WriteLine("Not a Palindrone");

                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter a Number to Check Number is Armstrong");
                            int num = Convert.ToInt32(Console.ReadLine());
                            int temp = num;
                            int squar_Sum = 0;
                            while (num != 0)
                            {
                                int r = num % 10;
                                num /= 10;
                                squar_Sum = r * r * r + squar_Sum;
                            }
                            Console.WriteLine(squar_Sum);
                            if (squar_Sum == temp)
                            {
                                Console.WriteLine("Armstrong ");
                            }
                            else
                            {
                                Console.WriteLine("Not Armstrong ");
                            }

                        }
                        break;
                    case 5:
                        {
                            int[] num = { 1, 2, 3, 4, 5 };
                            Array.Reverse(num);
                            foreach (int i in num)
                            {
                                Console.WriteLine(i + " ");

                            }

                        }
                        break;
                    case 6:
                        {
                            int[] num = { 1, 2, 3, 4, 5 };
                            int evencount = 0;
                            int oddcount = 0;
                            foreach (int i in num)
                            {
                                if (i % 2 == 0)
                                {
                                    Console.WriteLine("Even" + i);
                                    evencount++;
                                }
                                else
                                {
                                    Console.WriteLine("odd" + i);
                                    oddcount++;
                                }
                            }
                            Console.WriteLine("even num are " + evencount);
                            Console.WriteLine("odd num are " + oddcount);

                        }
                        break;
                    case 7:
                        {
                            int[] num = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 5 };
                            int average = 0;
                            int sum = 0;
                            int count = 0;
                            for (int i = 0; i < num.Length; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    Console.WriteLine("evan location integer index {0} = {1}", i, num[i]);
                                    count++;
                                    sum += num[i];

                                }
                            }

                            average = sum / count;
                            Console.WriteLine("Average" + average);
                        }
                        break;
                    case 8:
                        {
                            int[] num = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 5 };
                            Array.Sort(num);
                            foreach (int i in num)
                            {
                                Console.Write("After sorting" + i + " ");
                            }
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("THANK YOU!");
                            Exit = true;
                        }
                        break;

                }
            }




           
           

            
           
            
           
        }
    }
}