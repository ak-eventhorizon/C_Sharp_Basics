// Данный файл содержит различные тестовые примеры (реализованы в виде статических методов класса Example)
namespace C_Sharp_Basics
{
    class Example {


        // public - метод доступен по всему проекту
        // static - не требуется создавать экземпляр класса для вызова метода, метод принадлежит самому классу
        // статические методы не могут обращаться к своему окружению (только к статическим членам своего класса), все данные должны быть переданы им в параметрах
        // void - возвращаемое значение отсутствует


        /// <summary>
        /// Печатает в консоль строку, полученную в качестве параметра.
        /// </summary>
        public static void Print(string msg) {
            System.Console.WriteLine(msg);

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
        }


        /// <summary>
        /// Создает массив из 10 случайных чисел. Печатает мимнимальное и максимальное число из этого массива.
        /// </summary>
        public static void GetMinMaxFromRandomArray() {

            int[] numbers = new int[10];
            Random rnd = new Random();
            int min, max;
 
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }

            min = numbers[0];
            max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                    min = numbers[i];

                if (max < numbers[i])
                    max = numbers[i];
            }

            System.Console.WriteLine("Random array:");
            System.Console.WriteLine("[{0}]", string.Join(", ", numbers));

            System.Console.WriteLine("The highest number in the array: " + max);
            System.Console.WriteLine("The lowest number in the array: " + min);

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
        }


        /// <summary>
        /// Принимает начало и конец двух интервалов времени. Печатает пересечение двух временных интервалов, либо сообщение о том, что пересечения нет.
        /// </summary>
        public static void GetTimeIntersection(DateTime start1, DateTime end1, DateTime start2, DateTime end2) {
            
            System.Console.WriteLine("Первый интервал: " + start1.ToString("dd.MM.yyyy HH-mm") + " - " + end1.ToString("dd.MM.yyyy HH-mm"));
            System.Console.WriteLine("Второй интервал: " + start2.ToString("dd.MM.yyyy HH-mm") + " - " + end2.ToString("dd.MM.yyyy HH-mm"));

            if (end1 <= start2 || start1 >= end2) // условие отсутствия пересечений интервалов
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Пересечения интервалов нет.");
                System.Console.ResetColor();
            } 
            else
            {
                // начало пересечения - бОльший из start1 и start2; конец пересечения - мЕньший из end1 и end2
                DateTime overlapStart = start1 > start2 ? start1 : start2;
                DateTime overlapEnd = end1 < end2 ? end1 : end2;

                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Пересечение интервалов: " + overlapStart.ToString("dd.MM.yyyy HH-mm") + " - " + overlapEnd.ToString("dd.MM.yyyy HH-mm"));
                System.Console.ResetColor();
            }

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
        }
    }
}