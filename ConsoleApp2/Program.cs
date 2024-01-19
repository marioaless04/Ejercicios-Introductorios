//3.Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.

using System;
using System.ComponentModel.Design;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe un numero entero de dos digitos");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num.ToString().Length == 2);
        try
        {
            int digito_1 = (num / 10);
            int digito_2 = (num % 10);
            if (primo(digito_1) && primo(digito_2))
            {
                Console.WriteLine("Ambos digitos son primos");
            }
            else
            {
               if (primo(digito_1))
                {
                    Console.WriteLine($"Solo {digito_1} es primo");
                }
                else
                {
                    if (primo(digito_2)) 
                    {
                        Console.WriteLine($"Solo {digito_2} es primo");
                    }
                    else
                    {
                        Console.WriteLine($"No todos los digitos de {num} son primos");
                    }
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine ("No es un numero");
        }
           bool primo(int num)
        {
            if (num < 2)
            return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0) 
                        return false;
                }
            }
            return true;
            
        }
    }

   
}
   


