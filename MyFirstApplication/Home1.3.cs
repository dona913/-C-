
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

//Выполнил : Ивницкий Дмитрий Николаевич


using System;


namespace HomeWork_1._3
{
    class Program
    {

        static double Rast(double x1, double y1, double x2, double y2)
        {
            double R;
            return R = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Pause()
        {
            Console.ReadKey();
        }


        static void Main()
        {
            double x1, y1, x2, y2;

            Console.WriteLine("Добрый день!");

            Console.Write("Введите координаты первой точки X1 :");
            string str1 = Console.ReadLine();
            x1 = Convert.ToDouble(str1);

               

            Console.Write("Введите координаты первой точки Y1 :");
            string str2 = Console.ReadLine();
            y1 = Convert.ToDouble(str2);



            Console.Write("Введите координаты второй точки X2 :");
            string str3 = Console.ReadLine();
            x2 = Convert.ToDouble(str3);

            Console.Write("Введите координаты второй точки Y2 :");
            string str4 = Console.ReadLine();
            y2 = Convert.ToDouble(str4);

            Console.WriteLine("Расстояние между первой точки и второй : {0: 0.00}", Rast(x1, y1, x2, y2));


            Pause();

        }
    }
}

