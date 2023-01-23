namespace C_Sharp_Basics
{
    /// <summary>
    /// Данный класс содержит различные тестовые примеры (реализованы в виде статических методов класса Example)
    /// </summary>
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


        /// <summary>
        /// Демонстрирует различные кейсы использования ООП концепций проекта.
        /// </summary>
        public static void OOP() {

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
            bot1.LaserFire();  // исходный метод из класса Robot

            System.Console.WriteLine($"Was created {Robot.Counter} units"); // создание класса-наследника так-же увеличивает counter родительского класса Robot
        }


        /// <summary>
        /// Проверка гипотезы, что лучше при игре в лоттерею? Каждый тираж угадывать заново или придерживаться одного мнения на все тиражи до выигрыша.
        /// </summary>
        public static void LotteryStat(int rounds) {
            int permanent_desicion = 8;
            int changeable_desicion;

            int perm_wins = 0;
            int chng_wins = 0;

            Random rnd = new Random();

            for (int i = 0; i < rounds; i++)
            {
                int current_win_combination = rnd.Next(1, 21);
                changeable_desicion = rnd.Next(1, 21);

                if (current_win_combination == permanent_desicion)
                {
                    perm_wins++;
                } 
                
                if (current_win_combination == changeable_desicion)
                {
                    chng_wins++;
                }
            }

            System.Console.WriteLine("Раундов лотереи:" + rounds);
            System.Console.WriteLine("Постоянное мнение выиграло " + perm_wins + "раз.");
            System.Console.WriteLine("Изменчивое мнение выиграло " + chng_wins + "раз.");
        }
    }
}