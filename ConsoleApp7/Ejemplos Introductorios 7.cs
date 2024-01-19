// 7.Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.

using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            print("Escribe un numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            print("Escribe otro numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                print("Escribe otro numero");
                num2 = Convert.ToInt32((Console.ReadLine()));

                if (num1 > num2)
                {
                    print($"{num1} es el mayor");
                }
                else
                {
                    print($"{num2} es el mayor");
                }
            }
            else
            {
                if (num2 > num1)
                {
                    print("Escribe otro numero");
                    num1 = int.Parse(Console.ReadLine());

                    if (num2 > num1)
                    {
                        print($"{num2} es el mayor");
                    }
                    else
                    {
                        print($"{num1} es el mayor");
                    }

                }

            }

        }
        catch (Exception e)
        {
            print("Los numeros son iguales");
        }
        
    }
    static void print(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}

