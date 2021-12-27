namespace C_Sharp_Basics {

    class Killer : Robot {
        
        // поля класса
        private int health;
        
        // аксессоры (Свойства)
        public int Health { get => health; set => health = value; }

        // конструктор без параметров
        public Killer() {

        }

        // конструктор с пробрасыванием трех параметров в свойства родительского класса
        public Killer(string name, int weight, int[] coords, int health) : base(name, weight, coords) {
            
            this.Health = health;
        }

        // переопределение виртуального метода родительского класса
        public override void LaserFire()
        {
            Console.WriteLine($"KILLER {Name} OPEN LASER FIRE!");
        }

        // реализация абстрактного метода из родительского класса
        public override void Destroyed() {
            Console.WriteLine($"{this.Name} WAS DESTROYED! BOOM!!");
        }
    }
}