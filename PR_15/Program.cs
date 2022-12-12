//*************************
// практическая работа №15*
// выполнил: Ханов Артур  *
//*************************
using System;

namespace PR_15
{
    internal class Program
    {
        public struct Period
        {
            public byte den;
            public byte month;
        }
        public struct Astrologia
        {
            public string znak, planeta, kamen;
            public Period period;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество знаков зодиака");
                uint n1 = Convert.ToUInt32(Console.ReadLine());
                Astrologia[] Astr = new Astrologia[n1];//объявление массива типа Astrologia
                int i;
                for (i = 0; i < n1; i++)
                {
                    Astr[i] = new Astrologia();
                    Console.WriteLine("Введите знак зодиака:");
                    Astr[i].znak = Console.ReadLine();
                    Console.WriteLine("Введите число дня рождения:");
                    Astr[i].period.den = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Введите номер месяца рождения:");
                    Astr[i].period.month = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Введите планету соответствующие знаку зодиака:");
                    Astr[i].planeta = Console.ReadLine();
                    Console.WriteLine("Введите камень соответствующие знаку зодиака:");
                    Astr[i].kamen = Console.ReadLine();
                }
                sort(Astr);//сортировка
                vivod(Astr);//вывод
                Console.ReadLine();
            }
            catch (Exception e)//обработка исключения
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
        }
        static void sort(Astrologia[] t1)
        {
            try
            {
                for (int j = 1; j < t1.Length; j++)
                    for (int i = 0; i < t1.Length - j; i++)
                        if (t1[i].period.month > t1[i + 1].period.month)
                        {
                            Astrologia g = t1[i];
                            t1[i] = t1[i + 1];
                            t1[i + 1] = g;
                        }
            }
            catch (Exception e)//обработка исключения
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
        }
        static void vivod(Astrologia[] t1)
        {
            try
            {
                for (int i = 0; i < t1.Length; i++)
                {
                    Console.WriteLine("Данные о {0} записи: ", i + 1);
                    Console.Write("Знак зодиака: {0}\t", t1[i].znak);
                    Console.WriteLine("{0}.{1}\t", t1[i].period.den, t1[i].period.month);
                    Console.WriteLine("Планета :{0}\t\tКамень: {1}", t1[i].planeta, t1[i].kamen);
                }
            }
            catch (Exception e)//обработка исключения
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
        }
    }
}
