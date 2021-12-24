using System;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {


        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {
            
            Robot bot1 = new Robot("Siri", 450, new int[] {1, 7, 4});
            Console.WriteLine($"Name: {bot1.Name}, Weight: {bot1.Weight}, Coords: {bot1.Coords[0]}x {bot1.Coords[1]}y {bot1.Coords[2]}z");

            Robot bot2 = new Robot();
            bot2.Name = "Manya";
            bot2.Weight = 550;
            bot2.Coords = new int[] {1, 2, 3};
            Console.WriteLine($"Name: {bot2.Name}, Weight: {bot2.Weight}, Coords: {bot2.Coords[0]}x {bot2.Coords[1]}y {bot2.Coords[2]}z");

            System.Console.WriteLine($"Was created {Robot.Counter} units");
        }


        // public - метод доступен по всему проекту
        // static - не требуется создавать экземпляр класса для вызова метода, метод принадлежит самому классу
        // void - возвращаемое значение отсутствует
        public static void Print(string msg = "") {
            System.Console.WriteLine(msg);
        }


        public static double Summ(double a, double b) {
            double result = a + b;
            return result;
        }
    }    
} 