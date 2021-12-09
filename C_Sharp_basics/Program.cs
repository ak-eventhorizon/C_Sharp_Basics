Person vasya = new();

string myName = vasya.Name;
Console.WriteLine(myName);

vasya.Name = "Vasya!";
myName = vasya.Name;
Console.WriteLine(myName);

class Person
{
    private string name = "Undefined";
    public string Name 
    { 
        get { return name; } 
        set { name = value; } 
    }
}