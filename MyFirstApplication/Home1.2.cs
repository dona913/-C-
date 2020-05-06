//2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах

//Выполнил : Ивницкий Дмитрий Николаевич 





using System;


namespace HomeWork2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(value: "Для рассчёта индекса массы тела следуйте дальнейшим инструкциям!");

            Console.WriteLine(value: "Введите показатель массы тела в киллограммах :");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(value: "Введите показатель роста  в метрах :");
            double h = Convert.ToDouble(Console.ReadLine());

            double IMT = m / (h * h);

            Console.WriteLine(value: $"Показатель индекса массы телла (ИМТ) при массе {m} кг и росте {h} метров равен {IMT} !");
            Console.ReadKey();
        }
    }
}
