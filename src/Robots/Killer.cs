namespace C_Sharp_Basics {


    // перечисление - по сути это тип данных, содержащий список допустимых вариантов
    enum LaserColor {Blue, Red, Green, Yellow}


    class Killer : Robot {
        
        // поля класса
        private int health;
        private LaserColor laserCol;
        
        // аксессоры (Свойства)
        public int Health { get => health; set => health = value; }
        public LaserColor LaserCol { get => laserCol; set => laserCol = value; }

        // конструктор без параметров
        public Killer() {

        }

        // конструктор с пробрасыванием трех параметров в свойства родительского класса
        public Killer(string name, int weight, int[] coords, int health, LaserColor color) : base(name, weight, coords) {
            
            this.Health = health;
            this.LaserCol = color;
        }

        // переопределение виртуального метода родительского класса
        public override void LaserFire()
        {

            // установка цвета текста вывода в зависимости от параметра laserCol
            switch (this.LaserCol)
            {
                case LaserColor.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case LaserColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LaserColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LaserColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine($"KILLER {Name} OPEN FIRE WITH {LaserCol.ToString().ToUpper()} LASER!");
            Console.ResetColor();
        }

        // реализация абстрактного метода из родительского класса
        public override void Destroyed() {
            Console.WriteLine($"{this.Name} WAS DESTROYED! BOOM!!");
        }
    }
}