using System;
using System.Collections.Generic;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {

        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {
            Print();
            Print("Hello everybody!");
        }

        // public - метод доступен по всему проекту
        // static - не требуется создавать экземпляр класса для вызова метода, метод принадлежит самому классу
        // void - возвращаемое значение отсутствует
        public static void Print(string msg = "Default"){
            System.Console.WriteLine(msg);
        }
    }    
} 