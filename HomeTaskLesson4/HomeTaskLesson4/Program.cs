using System.Text;

namespace HomeTaskLesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            //hometask1 Циклы

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 != 0) 
            //    {
            //        Console.WriteLine($"{i}\n");
            //    }

            //}


            //hometask2 циклы

            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine($"{i}");
            //}


            //hometask3 циклы

            //Console.WriteLine("Введите число: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int res = 0;
            //do
            //{
            //    res = res + i;
            //    i++;
            //}
            //while (i <= c);
            //Console.WriteLine($"Сумма чисел от 1 до {c} равна: {res}");


            //hometask4 циклы

            //int i = 0;
            //while (i < 98)
            //{
            //    i += 7;
            //    Console.WriteLine($"{i}");
            //}


            //hometask5 циклы
            //int i = 0;
            //int numbers = 5;
            //do
            //{
            //    numbers -= 5;
            //    i++;
            //    Console.WriteLine($"{numbers}");
            //}
            //while (i < 10);


            //hometask6 циклы

            //for (int i = 10; i <= 20; i++)  
            //{
            //    Console.WriteLine(Math.Pow(i,2));
            //}



            //hometask0 Массивы

            //int[] Array1 = new int[] { 1, 3, 4, 4, 7, 8, 11, 23 };
            //Console.WriteLine("Введите число:");
            //int searchnumber = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < Array1.Length; i++) 
            //{
            //    if (Array1[i] == searchnumber)
            //    {
            //        Console.WriteLine($"Заданное число {searchnumber} входит в массив");
            //        break;
            //    }
            //    else if (i == Array1.Length-1)
            //    {
            //        Console.WriteLine($"Заданное число {searchnumber} НЕ входит в массив");
            //    }

            //}


            //hometask1 массивы Не понимаю как закончить логику:( !!!!

            //int[] Array1 = new int[] { 1, 3, 4, 5, 7, 8, 11, 23 };
            //Console.WriteLine("Введите число:");
            //var searchnumber = Convert.ToInt32(Console.ReadLine());
            //int[] Array2 = new int[Array1.Length - 1];

            //for (int i = 0; i < Array1.Length; i++)
            //{
            //    Array2[i] = Array1[i];
            //    Console.WriteLine(Array2[i]);
            //    if (Array1[i] == searchnumber) //как дальше ?
            //    {
            //        for (int j = 0; j < Array1.Length; j++)
            //        {
            //            Array2[j - 1] = Array1[j];
            //            Console.WriteLine(Array2[j]);
            //        }
            //    }
            //}


            //hometask2 массивы
            //Console.WriteLine("Введите размер массива:");
            //int k = Convert.ToInt32(Console.ReadLine());    
            //int[] Array3 = new int[k];
            //int maxElement = int.MinValue;
            //int minElement = int.MaxValue;
            //double avgElement = 0;
            //double sum = 0;
            //Random rand = new Random();

            //for (int i = 0; i < Array3.Length; i++)
            //{
            //    Array3[i] = rand.Next(1, 99);
            //    sum += Array3[i];
            //    Console.WriteLine(Array3[i]);
            //    if (maxElement < Array3[i])
            //    {
            //        maxElement = Array3[i];
            //    }
            //    if (minElement > Array3[i])
            //    {
            //        minElement = Array3[i];
            //    }
            //    avgElement = sum / k;
            //}
            //Console.WriteLine($"Максимальное значение массива равно: {maxElement}");
            //Console.WriteLine($"Минимальное значение массива равно: {minElement}");
            //Console.WriteLine($"Среднее значение массива равно: {avgElement}");


            //hometask3 массивы

            //int[] Array1 = { 3, 13, 25, 33, 43 };
            //int[] Array2 = { 2, 10, 26, 32, 57 };
            //double sum1 = 0;
            //double avgArray1 = 0;   
            //double sum2 = 0;
            //double avgArray2 = 0;
            //foreach (int nums1 in Array1) 
            //{
            //    Console.Write(nums1 + " ");
            //    sum1 += nums1;
            //}
            //Console.WriteLine("\n");
            //foreach(int nums2 in Array2) 
            //{ 
            //    Console.Write(nums2 + " ");
            //    sum2 += nums2;
            //}
            //Console.WriteLine("\n");
            //avgArray1 = sum1 / 5;
            //avgArray2 = sum2 / 5;
            //if (avgArray1 > avgArray2)
            //{
            //    Console.WriteLine($"Среднее значение массива1 {avgArray1} больше массива2 {avgArray2}");
            //}
            //else if (avgArray1 < avgArray2)
            //{
            //    Console.WriteLine($"Среднее значение массива2 {avgArray2} больше массива3 {avgArray1}");
            //}
            //else
            //{
            //    Console.WriteLine($"Среднее значение массива1 {avgArray1} равно среднему значению массива2 {avgArray2}");
            //}



            //hometask1 числа Fibbonachi Доп задания

            //int[] Fib = new int[11];
            //int num1 = 1;
            //int res = 0;
            //for (int i = 0; i < Fib.Length; i++)
            //{
            //    Fib[i] = res;
            //    Console.WriteLine(Fib[i]);
            //    res = num1;
            //    num1 += Fib[i];
            //}


            //hometask2 Доп задания

            //Console.WriteLine("Введите первоначальную сумму вклада: ");
            //float sum = float.Parse(Console.ReadLine());
            //Console.WriteLine("Введите период вклада в месяцах: ");
            //int period = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= period; i++)
            //{
            //    sum += sum * 0.07f;
            //}
            //Console.WriteLine($"После {period} месяцев сумма вклада составит {sum}");
            //Console.ReadKey();


            //hometask3 Доп задания

            //https://github.com/nikmorror37/CalculatorHT3 ссылка на калькулятор в репозитории


            //hometask4 Доп задания

            //Link1:
            //Console.WriteLine("Введите размер массива:");
            //int arrSize = Convert.ToInt32(Console.ReadLine());
            //if(arrSize <= 5 || arrSize > 10 )
            //    goto Link1;
            //Console.WriteLine("\nПервый массив");

            //int[] Array1 = new int[arrSize];
            //int[] Array2 = new int[arrSize];
            //Random rand = new Random();

            //for (int i = 0; i < Array1.Length; i++)
            //{
            //    Array1[i] = rand.Next(1, 999);
            //    Console.WriteLine(Array1[i]);

            //}
            //Console.WriteLine("\nВторой массив с элементами только четных чисел из 1го массива");
            //for (int i = 0; i < Array1.Length; i++)
            //{
            //    if (Array1[i] % 2 == 0)
            //    {
            //        Array2[i] = Array1[i];
            //        Console.WriteLine(Array2[i]);
            //    }
            //}


            //hometask5 Доп задания

            //int[] Array1 = { 3, 10, 25, 18, 4, 7, 17, 101 };
            //foreach (int nums1 in Array1)
            //{
            //    Console.Write(nums1 + " ");
            //}
            //Console.WriteLine("\n");
            //for (int i = 0; i < Array1.Length; i++) 
            //{
            //    if (i % 2 != 0) 
            //    {
            //        Array1[i] = 0;
            //    }
            //    Console.Write(Array1[i] + " ");
            //}


            //hometask6 Доп задания Отсортировать массив строк




            //hometask7 Доп задания Алгоритм сортировки пузырьком 





        }
    }
}