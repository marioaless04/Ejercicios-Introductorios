//5. Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.

using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        print("Escribe un numero entero de 3 digitos");
        int num = Convert.ToInt32(Console.ReadLine());

        if (Math.Abs(num) >= 100 && Math.Abs(num) <= 999)
        {
            int num_abs = Math.Abs(num);
            int digito_1 = (num_abs / 100);
            int digito_2 = ((num_abs % 100)/10);
            int digito_3 = (num_abs % 10);

            if (digito_1 > digito_2 && digito_1 > digito_3)
            {
                print("El mayor digito esta en primera posicion");
            }
            else
            {
                if (digito_2 > digito_1 && digito_2 > digito_3)
                {
                    print("El mayor digito esta en la segunda posicion");
                }
                else
                {
                    if (digito_3 > digito_1 && digito_3 > digito_2)
                    {
                        print("El mayor digito esta en tercera posicion");
                    }

                    else
                    {
                        if (digito_1 == digito_2 && digito_1 > digito_3)
                        {
                            print("El mayor digito esta en primera y segunda posicion");
                        }
                        else
                        {
                            if (digito_2 == digito_3 && digito_2 > digito_1)
                            {
                                print("El mayor digito esta en segunda y tercera posicion");
                            }
                            else
                            {
                                if (digito_1 == digito_3 && digito_1 > digito_2)
                                {
                                    print("El mayor digito esta en primera y tercera posicion");
                                }
                                else
                                {
                                    print("Los 3 digitos son iguales");
                                }

                            }
                        }
                    }

                }
            }
            
        }
    }
    static void print(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}

