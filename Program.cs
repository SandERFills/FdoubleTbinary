using System;

namespace Lesson1
{
    class Program
    {
        static void Foo(int i)
         {
            Console.Write(i);
            if (i>=10)
                   return;
                        i++;
            Foo(i);
           
        }
        static void ArrPrint(int[] arr,int i=0)
        {

            Console.WriteLine(arr[i]);
            if (i>=arr.Length-1)
            {
                return;
            }
            
            i++;
                ArrPrint(arr,i);
        }
        static void RecursSum(int[] arr,int i=0,int sum=0)
        {
            sum = sum+arr[i];
            if (i>=arr.Length-1)
            {
                Console.WriteLine(sum);
                return;
                
            }
            i++;
            RecursSum(arr, i, sum);
            
        }
        static int SumOfNumbers(int value)
        {
            if (value<10)
            {
                return value;
            }
            int digit = value % 10;
            int nexNum= value / 10;
            return digit + SumOfNumbers(nexNum);
        }
        static void Main(string[] args)
        {
            #region Два Числа
            //int FistDigit, SecondDigit;
            //double MiddleDigit;
            //Console.WriteLine("Введите два числа");
            //FistDigit = int.Parse(Console.ReadLine());
            //SecondDigit = int.Parse(Console.ReadLine());
            //MiddleDigit = (FistDigit + SecondDigit) / 2;
            //Console.WriteLine(MiddleDigit);
            #endregion
            #region Три Числа
            //int FistDigit, SecondDigit,ThirdDigit;
            //int MiddleDigit;
            //Console.WriteLine("Введите три числа");
            //FistDigit = int.Parse(Console.ReadLine());
            //SecondDigit = int.Parse(Console.ReadLine());
            //ThirdDigit = int.Parse(Console.ReadLine());
            //MiddleDigit = FistDigit + SecondDigit + ThirdDigit;
            //Console.WriteLine("Сумма "+ MiddleDigit + "\n");
            //Console.WriteLine("Произведение "+(FistDigit * SecondDigit * ThirdDigit )+ "\n");
            #endregion
            #region Валютный конверт

            //const int DOLLAR = 76, EURO = 90;
            //double res;
            //Console.WriteLine("Введите кол-во рублей");
            //int rub = int.Parse(Console.ReadLine());
            //res = (double)rub / DOLLAR;
            //Console.WriteLine("Доллары: "+ res + " Доллары");
            //res = (double)rub / EURO;
            //Console.WriteLine("Евро: " + res + " Евро");
            #endregion
            //Foo(0);
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //ArrPrint(arr);
            //RecursSum(arr);

            //SumOfNumbers(561);
            //Console.WriteLine("561 ="+SumOfNumbers(561));
            //int summ=0, num=561,buffnum;
            //while (num!=0)
            //{
            //    buffnum = num % 10;
            //    summ += buffnum;
            //    num /= 10;
            //}
            //Console.WriteLine(summ);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[]);
            //}
            //string input ;
            //Console.WriteLine("Fist simbol next number exp -b2: ");
            //Console.WriteLine("a|        |         |       |\n" +
            //                   "--------------------------\n" +
            //                 "b|        |        |       |\n" +
            //                 "----------------------------\n" +
            //                 "c|        |        |       |\n" +
            //                 "     1         2        3");
            //while (true)
            //{


            //    input = Console.ReadLine();
            //    if (input=="a1" )
            //    {
            //        Console.WriteLine("a|    x    |         |   o    |\n" +
            //                   "--------------------------\n" +
            //                 "b|        |        |       |\n" +
            //                 "----------------------------\n" +
            //                 "c|        |        |       |\n" +
            //                 "     1         2        3");

            //    }
            //    if (input=="b2")
            //    {
            //        Console.WriteLine("a|        |         |    o   |\n" +
            //               "--------------------------\n" +
            //             "b|        |     x   |       |\n" +
            //             "----------------------------\n" +
            //             "c|        |        |       |\n" +
            //             "     1         2        3");
            //    }

            //}
            //string person_input;
            //string[] quitwords = {"quit","exit" };
            //bool isStop = false;
            //while (isStop==false)
            //{
            //    person_input = Console.ReadLine();
            //    foreach (string item in quitwords)
            //    {
            //        if (item==person_input)
            //        {
            //            isStop = true;
            //        }
            //    }
            //}
            int num = 103;
            string otvet="\0",buff;
            while (num>0)
            {
                if (num % 2 <= 0)
                {
                    buff = "0";
                    otvet =String.Concat(otvet, buff);
                }
                if (num%2>0)
                {
                    buff = "1";
                    otvet=String.Concat(otvet, buff);
                }
                
                num /= 2;
            }
            for (int i = otvet.Length-1; i > 0; i--)
            {
                Console.Write(otvet[i]); 
            }
        }
    }
}
