//9.    Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.

class Program
{
    static void Main()
    {
        Print_("Ingrese un número entero de cuatro dígitos: ");
        int num = int.Parse(Console.ReadLine());

        int dig_1 = num / 1000;
        int dig_2 = (num / 100) % 10;
        int dig_3 = (num / 10) % 10;
        int dig_4 = num % 10;

        if (dig_2 == dig_3)
        {
            Print_("El segundo dígito es igual al penúltimo.");
        }
        else
        {
            Print_("El segundo dígito no es igual al penúltimo.");
        }
    }
    static void Print_(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}
