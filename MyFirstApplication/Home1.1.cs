//1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) * используя вывод со знаком $.

// Выполнил : Ивницкий Дмитрий Николаевич


using System;



class Program 
{
    static void Main()
{
    Console.WriteLine(value: "Введите Ваше имя :");
    string name = Console.ReadLine();

    Console.WriteLine(value: "Введите Вашу фамилию :");
    string surname = Console.ReadLine();

    Console.WriteLine(value: "Введите Ваш рост в сантиметрах :");
    double high = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(value: "Введите Ваш вес в киллограммах :");
    double weight = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine(value: "Введите Ваш возраст :");
    int age = Convert.ToInt32(Console.ReadLine());
         
    Console.WriteLine(value: "Привет " + name +" "+ surname + " я знаю что тебе " + age + "  лет! Плюс я знаю что твой рост составляет " + high + " см, а вес "+ weight + " кг!)" );// склеевание 
    Console.WriteLine(value: String.Format("Привет {0} {1} я знаю что тебе {2}  лет! Плюс я знаю что твой рост составляет {3} см, а вес {4} кг :)", name,surname, age,high,weight));// форматированный вывод ;
    Console.WriteLine(value: $"Привет {name} {surname} я знаю тебе {age}  лет! Плюс я знаю что твой рост составляет {high} см, а вес {weight} кг !:0");// интерполяция строк через $
    Console.ReadKey();
}
}



