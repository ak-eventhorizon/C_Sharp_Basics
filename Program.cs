using System;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {

        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {
            

            int[,] arr2d = {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}
            };
        
            for (int i = 0; i <= arr2d.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr2d.GetUpperBound(1); j++)
                {
                    System.Console.WriteLine(arr2d[i,j]);
                }
            }
        

        }
    }    
} 