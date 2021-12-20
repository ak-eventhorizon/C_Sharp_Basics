using System;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {

        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {
            User vasya = new User("Vasya");
            vasya.Speak("Hello everyone!");
            vasya.Jump();
        }
    }    


    interface IHuman {
        void Jump();
        void Speak(string message);
    }


    class User : IHuman {

        string Name;
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