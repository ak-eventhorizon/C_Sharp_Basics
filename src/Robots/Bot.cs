namespace C_Sharp_Basics {

    class Bot : Robot {
        
        // конструктор без параметров
        public Bot() {

        }

        // конструктор с пробрасыванием трех параметров в свойства родительского класса
        public Bot(string name, int weight, int[] coords) : base(name, weight, coords) {

        }

        // реализация абстрактного метода из родительского класса
        public override void Destroyed() {
            Console.WriteLine($"{this.Name} was destroyed... Beep!");
        }
    }
}