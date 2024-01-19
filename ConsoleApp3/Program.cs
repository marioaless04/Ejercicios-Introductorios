//2.Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.

using System.Linq.Expressions;

Console.WriteLine("Ingrese un numero entero de dos digitos");

try
{
    int num = Convert.ToInt32(Console.ReadLine());
    
        bool esPrimo = true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                esPrimo = false;
                break;
            }
        }
        if (num <= -1)
    {
        esPrimo = false;
    }
        if (num == 0)
    {
        esPrimo = false;
    }
        if (esPrimo)
        {
            Console.WriteLine("Es primo");
        }
        else
        {
            Console.WriteLine("No es primo");
        }

        if (num < 0)
        {
            Console.WriteLine("Es negativo");
        }
        else
        {
            Console.WriteLine("No es negativo");
        }
    
}
catch (Exception e)
{
    Console.WriteLine("No es un numero");
}
