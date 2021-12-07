class Program
{
    static void Main(string[] args)
    {
        string hello = "Hello METANIT.COM"; // определение переменной - внутри Main

        void Print(string message)          // определение метода - внутри Main
        {
            Console.WriteLine(message);
        }

        Print(hello);                       // вызов метода - внутри Main




        Person tom = new();                 // создание экземпляра класса - внутри Main
        tom.SayHello();                     // вызов метода объекта tom - внутри Main

    }
}

// определение нового класса - вне класса Program
class Person
{
    public void SayHello() => Console.WriteLine("Hello");
}