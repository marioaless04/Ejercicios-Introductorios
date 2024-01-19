//8.    Leer un número entero de cinco dígitos y determinar si es un número Capicúa. 

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un entero de cinco digitos : ");
        string num = Console.ReadLine();
        char[] numArray = num.ToCharArray();
        Array.Reverse(numArray);
        string reverseString = new string(numArray);

        if (reverseString == num)
        {
            Console.WriteLine("Es un capicua");
        }
        else
        {
            Console.WriteLine("No es capicua");
        }
    }
    static void print(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}
