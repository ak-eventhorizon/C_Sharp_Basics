// пространство имен - по имени проекта
namespace C_Sharp_Basics {


    class Robot {

        // поля класса - должны быть private или protected, доступ к полям через аксессоры или конструктор - это реализация инкапсуляции
        // private - доступен только из самого класса, protected - доступен из класса и из его наследников
        private string name = "DefaultName";
        private int weight;
        private int[] coords = new int[] {0, 0, 0};
        private static int counter; // статическое поле, принадлежащее самому классу Robot - счетчик количества созданных экземпляров

        // аксессоры для полей класса (Свойства)
        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public int[] Coords { get => coords; set => coords = value; }
        public static int Counter { get => counter; } // только геттер, сеттера у этого свойства нет чтобы извне его можно было только запросить но не изменить


        // конструктор (всегда public, тип возвращаемого значения не указывается) - без параметров
        public Robot() {
            counter++;
        }

        // конструктор (всегда public, тип возвращаемого значения не указывается) - с тремя параметрами
        public Robot(string name, int weight, int[] coords) {
            Name = name;
            Weight = weight;
            Coords = coords;

            counter++;
        }

        // метод
        public void StatusReport() {
                Console.WriteLine($"Name: {this.Name}, Weight: {this.Weight}, Coords: {this.Coords[0]}x {this.Coords[1]}y {this.Coords[2]}z");
        }
    }
}