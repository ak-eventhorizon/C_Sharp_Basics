// пространство имен - по имени проекта
namespace C_Sharp_Basics {


    // внутри интерфейса не описывается реализация, описывается только перечень необходимых к реализации
    // полей, свойств и методов
    interface IHuman {
        void Jump();
        void Speak(string message);
    }


    // в классе, наследуемом от интерфейса, необходимо реализовать все поля, свойства и методы интерфейса
    class User : IHuman {

        private string name = "DefaultName";

        // Аксессоры (Свойства)
        public string Name { 
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        
        // Конструктор
        public User(string name) {
            Name = name;
        }

        
        // реализация метода из интерфейса
        public void Jump() {
            Console.WriteLine(Name + " подпрыгнул!");
        }


        // реализация метода из интерфейса
        public void Speak(string msg) {
            Console.WriteLine($"{this.Name} говорит: \"{msg}\"");
        }
    }
}