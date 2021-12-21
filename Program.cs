using System;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {

        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {
            

            int[] myArr = new int[10];
            Random rnd = new Random();
            int summ =0;

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rnd.Next(-10,11);
                System.Console.WriteLine(myArr[i]);
                
                summ += myArr[i];
            }

            System.Console.WriteLine("SUMM = " + summ);
        
        
        }
    }    
} 