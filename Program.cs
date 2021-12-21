using System;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {

        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {
            // User vasya = new User("Vasya");
            // vasya.Speak("Hello everyone!");
            // vasya.Jump();

            System.Console.Write("Введите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            System.Console.WriteLine($"Круг с радиусом {radius} имеет площадь {Math.Round(area, 2)}");
        }
    }    
} 