using System.Globalization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
            //    res += i;
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

            //int[] array1 = new int[] { 1, 3, 4, 4, 7, 8, 11, 23 };
            //Console.WriteLine("введите число:");
            //int searchnumber = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (array1[i] == searchnumber)
            //    {
            //        Console.WriteLine($"заданное число {searchnumber} входит в массив");
            //        break;
            //    }
            //    else if (i == array1.Length - 1)
            //    {
            //        Console.WriteLine($"заданное число {searchnumber} не входит в массив");
            //    }

            //}


            //hometask1 массивы СДЕЛАЛ c помощью Except !

            //    int[] array1 = new int[] { 1, 3, 5, 7, 9, 14, 14, 23 };


            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        Console.Write(array1[i] + " ");
            //    }
            //    Console.WriteLine("\nВведите число:");
            //Link1:
            //    int searchNumberToExclude = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        if (array1[i] == searchNumberToExclude)
            //            break;
            //        else if (i == array1.Length - 1)
            //        {
            //            Console.WriteLine("\nВведите число заново:");
            //            goto Link1;
            //        }
            //    }
            //    int[] containerArray = new int[] { searchNumberToExclude };

            //    int[] array2 = array1.Except(containerArray).ToArray();

            //    for (int i = 0; i < array2.Length; i++)
            //    {
            //        Console.Write(array2[i] + " ");
            //    }


            //hometask1(второй вариант) массивы *Решение с занятия (для саморазвития)*

            //int[] source = { 5, 4, 7, 2, 9, 7, 10 };
            //int numberReadLine = Convert.ToInt32(Console.ReadLine());
            //int futureArrayLength = 0;

            //foreach (int item in source)
            //{
            //    if (item != numberReadLine)
            //    {
            //        futureArrayLength++;
            //    }
            //}

            //int[] resultArray = new int[futureArrayLength];

            //int iterationForAppend = 0;

            //for (int i = 0; i < source.Length; i++)
            //{
            //    if (source[i] != numberReadLine && iterationForAppend != resultArray.Length)
            //    {
            //        resultArray[iterationForAppend] = source[i];
            //        iterationForAppend++;
            //    }
            //}


            //hometask2 массивы

            //Console.WriteLine("Введите размер массива:");
            //int k = Convert.ToInt32(Console.ReadLine());    
            //int[] array3 = new int[k];
            //int maxElement = int.MinValue;
            //int minElement = int.MaxValue;
            //double avgElement = 0;
            //double sum = 0;
            //Random rand = new Random();

            //for (int i = 0; i < Array3.Length; i++)
            //{
            //    array3[i] = rand.Next(1, 99);
            //    sum += array3[i];
            //    Console.WriteLine(array3[i]);
            //    if (maxElement < array3[i])
            //    {
            //        maxElement = array3[i];
            //    }
            //    if (minElement > array3[i])
            //    {
            //        minElement = array3[i];
            //    }
            //    avgElement = sum / k;
            //}
            //Console.WriteLine($"Максимальное значение массива равно: {maxElement}");
            //Console.WriteLine($"Минимальное значение массива равно: {minElement}");
            //Console.WriteLine($"Среднее значение массива равно: {avgElement}");


            //hometask3 массивы

            //int[] array1 = { 3, 13, 25, 33, 43 };
            //int[] array2 = { 2, 10, 26, 32, 57 };
            //double sum1 = 0;
            //double avgArray1 = 0;
            //double sum2 = 0;
            //double avgArray2 = 0;
            //foreach (int nums1 in array1)
            //{
            //    Console.Write(nums1 + " ");
            //    sum1 += nums1;
            //}
            //Console.WriteLine("\n");
            //foreach (int nums2 in array2)
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

            //int[] fib = new int[11];
            //int num1 = 1;
            //int res = 0;
            //for (int i = 0; i < fib.Length; i++)
            //{
            //    fib[i] = res;
            //    Console.WriteLine(fib[i]);
            //    res = num1;
            //    num1 += fib[i];
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

            //int[] array1 = new int[arrSize];
            //int[] array2 = new int[arrSize];
            //Random rand = new Random();

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = rand.Next(1, 999);
            //    Console.WriteLine(array1[i]);

            //}
            //Console.WriteLine("\nВторой массив с элементами только четных чисел из 1го массива");
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (array1[i] % 2 == 0)
            //    {
            //        array2[i] = array1[i];
            //        Console.WriteLine(array2[i]);
            //    }
            //}


            //hometask5 Доп задания

            //int[] array1 = { 3, 10, 25, 18, 4, 7, 17, 101 };
            //foreach (int nums1 in array1)
            //{
            //    Console.Write(nums1 + " ");
            //}
            //Console.WriteLine("\n");
            //for (int i = 0; i < array1.Length; i++) 
            //{
            //    if (i % 2 != 0) 
            //    {
            //        array1[i] = 0;
            //    }
            //    Console.Write(array1[i] + " ");
            //}


            //hometask6 Доп задания Отсортировать массив строк

            //string text_6 = Console.ReadLine();
            //string[] names = text_6.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //Array.Sort(names);
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //hometask7 Доп задания Алгоритм сортировки пузырьком (Сделал)

            /*
            string[] array7;
            string temp;
            Console.WriteLine("\nВ этом задании будет использоваться алгоритм сортировки ПУЗЫРЬКОМ:");
            Console.WriteLine("------------------------------------------------------------------");
            Console.Write("Введите количество строк (слов), которые вы собираетесь ввести: ");
            int n = Convert.ToInt32(Console.ReadLine());
            array7 = new string[n];
            Console.Write($"Введите через Enter {n} строк (слов(а)):\n\n");
            for (int i = 0; i < n; i++)
            {
                array7[i] = Console.ReadLine();
            }
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Выберите вариант сортировки:");
            Console.WriteLine("1 - вывод в прямом алфавитном порядке");
            Console.WriteLine("2 - вывод в обратном алфавитном порядке");
            
            LinkRepeat:
            int choise = Convert.ToInt32(Console.ReadLine());
            // пример кода алгоритма сортировки пузырьком
            for (int i = 0; i < array7.Length; i++)
            {

                for (int j = 0; j < array7.Length - 1; j++)//чтобы не выйти за пределы массива
                {
                    switch (choise)
                    {
                        case 1:
                            if (array7[j].CompareTo(array7[j + 1]) > 0)
                            {
                                temp = array7[j];
                                array7[j] = array7[j + 1];
                                array7[j + 1] = temp;//меняем местами значения элементов массива string
                            }
                            break;
                        case 2:
                            if (array7[j].CompareTo(array7[j + 1]) < 0)
                            {
                                temp = array7[j];
                                array7[j] = array7[j + 1];
                                array7[j + 1] = temp; //меняем местами значения элементов массива string
                            }
                            break;
                        default:
                            Console.WriteLine("Повторите ввод 1 или 2 ...");
                            goto LinkRepeat;
                    }
                }
            }
            Console.WriteLine("\nРезультат сортировки:\n");
            for (int i = 0; i < array7.Length; i++)
            {
                Console.WriteLine(array7[i] + " ");
            }
            */


            //hometask2 Строки

            //string text_1 = Console.ReadLine();
            //string[] words = text_1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //int maxLength = words[0].Length;
            //int minLength = words[0].Length;
            //var maxIndex = 0;
            //var minIndex = 0;
            //var Length = 0;

            //for (int i = 1; i < words.Length; i++)
            //{
            //    Length = words[i].Length;
            //    if (Length >= maxLength) 
            //    {
            //        maxLength = Length;
            //        maxIndex= i;
            //    }
            //    else if (Length <= minLength) 
            //    {
            //        minLength = Length;
            //        minIndex = i;
            //    }
            //}
            //Console.WriteLine($"Самое короткое слово в строке: {words[minIndex]} ");
            //Console.WriteLine($"Самое длинное слово в строке: {words[maxIndex]} ");


            //hometask3 Строки

            //Console.WriteLine("Введите через пробел или запятую слова:\n");
            //string text_3 = Console.ReadLine();
            //string[] wordsArray = text_3.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            //string searchWord = wordsArray[0];

            //for(int i = 1; i< wordsArray.Length; i++) 
            //{
            //    Console.WriteLine(searchWord.Distinct().Count());
            //    Console.WriteLine(wordsArray[i].Distinct().Count()); 
            //    Console.WriteLine("\n");
            //    if (wordsArray[i].Distinct().Count() < searchWord.Distinct().Count())
            //    {
            //        searchWord = wordsArray[i];       
            //    }
            //}
            //Console.WriteLine($"В слове {searchWord} минимальное количество уникальных символов среди всех введеных слов");


            //hometask4 Строки Сделал!!!

            //string[] palindroms = new string[] {"ПапаП",
            //"Мамам",
            //"поткоп",
            //"потоп",
            //"топот",
            //"мороз",
            //"шалаш"};

            //foreach (var palindrom in palindroms)
            //{

            //    //поиск середины палиндрома

            //    if (palindrom.Length % 2 == 0)
            //    {
            //        Console.WriteLine($"Слово {palindrom} палиндром? : False");
            //        continue;
            //    }
            //    var pivotIndex = (int)Math.Round(palindrom.Length / 2m);


            //    //сравнение букв слова начиная с двух концов: x - начало, y - конец
            //    int y = palindrom.Length - 1;

            //    bool isPalindrom = true;

            //    for (int i = 0; i <= pivotIndex; i++, y--)
            //    {

            //        if (palindrom[i] == palindrom[y])
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            isPalindrom = false;
            //        }
            //    }

            //    Console.WriteLine($"Слово {palindrom} палиндром? : {isPalindrom} ");

            //}

            //Console.ReadKey();


            //hometask5 Строки  

            //string firstWord5 = Console.ReadLine();
            //char[] initWord5 = firstWord5.ToCharArray();
            //int initWord5Length = initWord5.Length;
            //int resultWord5Length = initWord5Length * 2;

            //char[] resultWord5 = new char[resultWord5Length];

            //for (int i = 0; i < initWord5.Length; i++)
            //{
            //    resultWord5[i * 2] = initWord5[i];
            //    resultWord5[i * 2 + 1] = initWord5[i];
            //}
            //string secondWord5 = new string(resultWord5);
            //Console.WriteLine(secondWord5);

        }
    }
}