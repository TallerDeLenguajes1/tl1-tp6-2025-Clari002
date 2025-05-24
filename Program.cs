// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a:" +a);
Console.WriteLine("Valor de b:" + b);

//Ejercicio 1
int n;
Console.WriteLine("--------------INVERTIR UN NUMERO----------------");
Console.WriteLine("Ingrese un numero: ");
if (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("El valor que ha ingresado no es un numero");
}
else
{
    int nInvertido = 0;
    Console.WriteLine("Valor de ingresado: " + n);
    while (n > 0)
    {
        nInvertido = nInvertido * 10 + n % 10;
        n = n / 10;
    }
    Console.WriteLine("Valor invertido: " + nInvertido);
}

//Ejercicio 2
Console.WriteLine("--------------------CALCULADORA------------------");
int n1, n2;
Console.WriteLine("Ingrese primer numero: ");
if (!int.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("El valor que ha ingresado no es un numero");
    return;
}
else
{
    Console.WriteLine("Ingrese segundo numero: ");
    if (!int.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("El valor que ha ingresado no es un numero");
        return;
    }
    else
    {
        int valor;
        do
        {
            Console.WriteLine("-------¿Que deseas realizar?------");
            Console.WriteLine("(1)Sumar");
            Console.WriteLine("(2)Restar");
            Console.WriteLine("(3)Multiplicar");
            Console.WriteLine("(4)Dividir");
            Console.WriteLine("(0)Salir");
            Console.WriteLine("Ingresar opcion: ");
            if (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("El valor que ha ingresado no es un numero");
                return;
            }
            else
            {
                switch (valor)
                {
                    case 1:
                        int suma = n1 + n2;
                        string cadenaSuma = suma.ToString();
                        Console.WriteLine("La suma de " + n1 + " y de " + n2 + " es igual a: " + cadenaSuma);
                        break;
                    case 2:
                        int resta;
                        resta = n1 - n2;
                        string cadenaResta = resta.ToString();
                        Console.WriteLine("La resta de " + n1 + " y de " + n2 + " es igual a: " + cadenaResta);
                        break;
                    case 3:
                        int producto;
                        producto = n1 * n2;
                        string cadenaProd = producto.ToString();
                        Console.WriteLine("El producto de " + n1 + " y de " + n2 + " es igual a: " + cadenaProd);
                        break;
                    case 4:
                        float division, aux1, aux2;
                        aux1 = n1;
                        aux2 = n2;
                        if (n2 != 0)
                        {
                            division = aux1 / aux2;
                            string cadenaDiv = division.ToString();
                            Console.WriteLine("La division de " + n1 + " y de " + n2 + " es igual a: " + cadenaDiv);
                        }
                        break;
                    default:
                        break;
                }
            }
        } while (valor != 0);
    }
}