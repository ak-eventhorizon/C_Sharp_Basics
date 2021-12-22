using System;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {


    interface IHuman {
        void Jump();
        void Speak(string message);
    }


    class User : IHuman {

        string Name;
        
        // Конструктор
        public User(string name) {
            Name = name;
        }

        public void Jump() {
            Console.WriteLine(this.Name + " подпрыгнул!");
        }

        public void Speak(string msg) {
            Console.WriteLine($"{this.Name} говорит: \"{msg}\"");
        }
    }
}