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
        }


        /// <summary>
        /// Получает начало и конец двух интервалов времени. Печатает пересечение двух временных интервалов, либо сообщение о том, что пересечения нет.
        /// </summary>
        public static void GetTimeIntersection(DateTime s1, DateTime e1, DateTime s2, DateTime e2) {
            

        }
    }
}