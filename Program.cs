using System;
using System.Collections.Generic;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {


        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {

            
            // Test code samples here: =============================================================>

            int[] numbers = new int[10];
            Random rnd = new Random();
            int min, max;
 
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }
            min = numbers[0];
            max = numbers[0];
            System.Console.WriteLine("[{0}]", string.Join(", ", numbers));
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                    min = numbers[i];
                if (max < numbers[i])
                    max = numbers[i];
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("The highest number in the array: > > > " + max);
            Console.WriteLine("The lowest number in the array: > > > " + min);

            Console.Write("PRESS ANY KEY");
            Console.ReadKey();

            // End of code sample <=============================================================


            // использование конструктора с параметрами для создания объектов
            Bot bot1 = new Bot("Siri", 450, new int[] {1, 7, 4});
            bot1.StatusReport();

            // использование конструктора без параметров, с последующей установкой свойств объекта
            Bot bot2 = new Bot();
            bot2.Name = "Manya";
            bot2.Weight = 550;
            bot2.Coords = new int[] {1, 2, 3};
            bot2.StatusReport();

            // создание списка объектов
            List<Bot> robots = new List<Bot>();
            robots.Add(new Bot("2B", 75, new int[] {10, 5, 3}));
            robots.Add(new Bot("R2D2", 77, new int[] {11, 11, 5}));
            robots.Add(new Bot("C3PO", 129, new int[] {10, 10, 6}));
            robots.Add(new Bot("T-1000", 400, new int[] {7, 15, 0}));

            foreach (Bot item in robots)
            {
                item.StatusReport();
            }

            // вывод статического свойства самого класса Robot
            System.Console.WriteLine($"Was created {Robot.Counter} units");


            // создание экземпляра класса Killer (наследника от родительского класса Robot)
            Killer demon = new Killer("DEMON", 45, new int[] {133, 45, 67}, 1000, LaserColor.Red);
            demon.LaserFire();  // переопределенный виртуальный метод из класса Killer
            bot1.LaserFire();  // исходный метод класса Robot

            System.Console.WriteLine($"Was created {Robot.Counter} units"); // создание класса-наследника так-же увеличивает counter родительского класса Robot
        }


        // public - метод доступен по всему проекту
        // static - не требуется создавать экземпляр класса для вызова метода, метод принадлежит самому классу
        // статические методы не могут обращаться к своему окружению (только к статическим членам своего класса), все данные должны быть переданы им в параметрах
        // void - возвращаемое значение отсутствует
        public static void Print(string msg = "") {
            System.Console.WriteLine(msg);
        }
    }
}