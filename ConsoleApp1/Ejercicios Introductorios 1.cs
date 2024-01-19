//1.Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.

Console.WriteLine("Digite el numero de 2 digitos");
try
{

    int num = Convert.ToInt32(Console.ReadLine());
    if (num.ToString().Length == 2)
    {
        int sum = (num / 10) + (num % 10);
        Console.WriteLine("La suma de los digitos es: " + sum);
    }
    else
    {
        Console.WriteLine("El numero debe ser de 2 digitos");
    }

}
catch (Exception e)
{
    Console.WriteLine("No es un numero");
}
