using System;
using System.Collections.Generic;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {


        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {
            
            Robot bot = new Robot("Siri", 450, new int[] {1, 7, 4});
            Console.WriteLine($"Name: {bot.Name}, Weight: {bot.Weight}, Coords: x{bot.Coords[0]} y{bot.Coords[1]} z{bot.Coords[2]}");

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