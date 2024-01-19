//8.    Leer un número entero de cinco dígitos y determinar si es un número Capicúa. 

class Program
{
    static void Main()
    {
        Print_("Ingrese un número entero de cinco digitos : ");
        string num = Console.ReadLine();
        char[] numArray = num.ToCharArray();
        Array.Reverse(numArray);
        string reverseString = new string(numArray);

        if (reverseString == num)
        {
            Print_("Es capicua.");
        }
        else
        {
            Print_("No es capicua.");

        }
    }
    static void Print_(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}
