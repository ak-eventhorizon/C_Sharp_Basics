// пространство имен - по имени проекта
namespace C_Sharp_Basics {


    interface IHuman {
        void Jump();
        void Speak(string message);
    }


    class User : IHuman {

        private string name = "DefaultName";

        // Аксессоры
        public string Name { get => name; set => name = value; }
        
        // Конструктор
        public User(string name) {
            Name = name;
        }

        
        public void Jump() {
            Console.WriteLine(Name + " подпрыгнул!");
        }

        public void Speak(string msg) {
            Console.WriteLine($"{this.Name} говорит: \"{msg}\"");
        }
    }
}