// 10.Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.
class Program
{
    static void Main()
    {
        Print_("Ingrese el primer número entero:");
        int num1 = int.Parse(Console.ReadLine());

        Print_("Ingrese el segundo número entero:");
        int num2 = int.Parse(Console.ReadLine());

        int diferencia = Math.Abs(num1 - num2);

        if (diferencia <= 10)
        {
            int menor = Math.Min(num1, num2);
            int mayor = Math.Max(num1, num2);

            Print_($"Los enteros comprendidos entre {menor} y {mayor} son:");

            for (int i = menor; i <= mayor; i++)
            {
                Console.Write($"{i} ");
            }
        }
        else
        {
            Print_("La diferencia entre los dos números es mayor a 10, no se mostrarán los números enteros comprendidos.");
        }
    }
    static void Print_(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

}

