using System;
using System.Collections.Generic;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {


        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {

            // Example.Print("Hello!!!");
            // Example.GetMinMaxFromRandomArray();
            // Example.OOP();
            // Example.LotteryStat(1000);


            DateTime start1 = new DateTime(2022,12,28,9,30,0); // 28.12.2022 9:30
            DateTime end1 = new DateTime(2022,12,28,12,30,0); // 28.12.2022 12:30

            DateTime start2 = new DateTime(2022,12,28,13,0,0); // 28.12.2022 13:00
            DateTime end2 = new DateTime(2022,12,28,15,0,0); // 28.12.2022 15:00

            Example.GetTimeIntersection(start1, end1, start2, end2);

        }
    }
}