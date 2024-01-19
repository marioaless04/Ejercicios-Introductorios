

class Program
{
    static void Main(string[] args)
    {
        imprimir_console("Escriba el primer valor");
        decimal valor1 = Convert.ToDecimal(Console.ReadLine());
        imprimir_console("Escriba el segundo valor");
        decimal valor2 = Convert.ToDecimal(Console.ReadLine());

        bool salir = false;
        while (!salir)
        {
            try
            {
                imprimir_console("1. Sumar");
                imprimir_console("2. Restar");
                imprimir_console("3. Multiplicar");
                imprimir_console("4. Dividir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        decimal total = suma_de_valores(valor1, valor2);
                        imprimir_console($"La suma es {total}");
                        break;

                    case 2:
                        decimal resta = resta_de_valores(valor1, valor2);
                        imprimir_console($"La resta es {resta}");
                        break;

                    case 3:
                        decimal producto = prod_de_valores(valor1, valor2);
                        imprimir_console($"El producto es {producto}");
                        break;

                    case 4:
                        decimal cociente = div_de_valores(valor1, valor2);
                        imprimir_console($"El cociente es {cociente}");
                        break;

                    default:
                        imprimir_console("Elige una opcion entre 1 y 4");
                        break;


                }
            }
            catch (FormatException e)
            {
                imprimir_console("Error");
            }

        }
        Console.ReadLine();
        
    }
    static decimal suma_de_valores(decimal valor1, decimal valor2)
    {
        return valor1 + valor2;
    }
    static decimal resta_de_valores(decimal valor1, decimal valor2)
    {
        return valor1 - valor2;
    }
    static decimal prod_de_valores(decimal valor1, decimal valor2)
    {
        return valor1 * valor2;
    }
    static decimal div_de_valores(decimal valor1, decimal valor2)
    {
        return valor1 / valor2;
    }
    static void imprimir_console(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

}


