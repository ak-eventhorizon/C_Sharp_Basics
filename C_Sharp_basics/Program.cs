// See https://aka.ms/new-console-template for more information

try
{
    int a = 33;
    int b = 600;
    byte c = checked((byte)(a + b)); // checked - выбрасывает исключение в случае переполнения указанного типа
    Console.WriteLine(c);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}