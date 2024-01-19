//4.Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.

class Program
{
    static void Main(String[] args)
    {
        print("Ingrese el primer numero de dos digitos");
        int num1 = Convert.ToInt32(Console.ReadLine());
        print("Ingrese el segundo numero de dos digitos");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (Math.Abs(num1) >= 10 && Math.Abs(num1) <= 99 && Math.Abs(num2) >= 10 && Math.Abs(num2) <= 99)
        {
            try
            {
                int total = suma_nums(num1, num2);
                print($"La suma es {total}");
            }
            catch (Exception e)
            {
                Console.WriteLine("No es un numero");
            }
        }
        else
        {
            print("Alguno de los numeros no tiene 2 digitos");
        }
    }
    static int suma_nums(int num1 , int num2)
    {
        return num1 + num2;
    }
    static void print(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}

