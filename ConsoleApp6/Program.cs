// 6.Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.

using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        print("Escribe un numero entero de 3 digitos");
        try
        {
            int num = (Convert.ToInt32(Console.ReadLine()));
            int abs_num = Math.Abs(num);
            if (abs_num >= 100 && abs_num <= 999)
            {
                int digito_1 = (abs_num / 100);
                int digito_2 = ((abs_num % 100) / 10);
                int digito_3 = (abs_num % 10);

                if (digito_1 % digito_2 == 0 && digito_1 % digito_3 == 0)
                {
                    print($"{digito_1} es multiplo de {digito_2} y {digito_3}");
                }
                else
                {
                    if (digito_2 % digito_1 == 0 && digito_2 % digito_3 == 0)
                    {
                        print("{digito_2} es multiplo de {digito_1} y {digito_3}");
                    }
                    else
                    {
                        if (digito_3 % digito_1 == 0 && digito_3 % digito_2 == 0)
                        {
                            print($"{digito_3} es multiplo de {digito_1} y {digito_2}");
                        }
                        else
                        {
                            if (digito_1 % digito_2 == 0)
                            {
                                print($"{digito_1} es multiplo de {digito_2}");
                            }
                            if (digito_1 % digito_3 == 0)
                            {
                                print($"{digito_1} es multiplo de {digito_3}");
                            }
                            if (digito_2 % digito_1 == 0)
                            {
                                print($"{digito_2} es multiplo de {digito_1}");
                            }
                            if (digito_2 % digito_3 == 0)
                            {
                                print($"{digito_2} es multiplo de {digito_3}");
                            }
                            if (digito_3 % digito_1 == 0)
                            {
                                print($"{digito_3} es multiplo de {digito_1}");
                            }

                            if (digito_3 % digito_2 == 0)
                            {
                                print($"{digito_3} es multiplo de {digito_2}");
                            }

                        }
                   
                    }
                }
            }
            else
            {
                print("El numero no tiene 3 digitos");
            }
        }
        catch (Exception e)
        {
            print("No es un numero");
        }

        static void print(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

    }
}
