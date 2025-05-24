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


//Ejercicio 3
Console.WriteLine("-----------CALCULADORA AVANZADA--------------");
Console.WriteLine("Ingrese un numero para realizar operaciones: ");
if (!double.TryParse(Console.ReadLine(), out double numero))
{
    Console.WriteLine("El valor que ha ingresado no es un numero valido");
    return;
}

Console.WriteLine("Valor absoluto de " + numero + " es: " + Math.Abs(numero));
Console.WriteLine("Cuadrado de " + numero + ": " + Math.Pow(numero, 2));
if (numero >= 0)
{
    Console.WriteLine("Raiz cuadrada de " + numero + ": " + Math.Sqrt(numero));
}
else
{
    Console.WriteLine("La raiz cuadrada no esta definida para numeros negativos");
}

double radianes = numero * (Math.PI / 180);
Console.WriteLine("Seno de " + numero + " en grados: " + Math.Sin(radianes));
Console.WriteLine("Coseno de " + numero + " en grados: " + Math.Cos(radianes));
Console.WriteLine("Parte entera de " + numero + ": " + Math.Truncate(numero));

Console.WriteLine("\n-----------COMPARACION DE DOS NUMEROS-----------");
Console.WriteLine("Ingrese el primer numero: ");
if (!double.TryParse(Console.ReadLine(), out double numero1))
{
    Console.WriteLine("El valor que ha ingresado no es un numero valido");
    return;
}
else
{
    Console.WriteLine("Ingrese el segundo numero: ");
    if (!double.TryParse(Console.ReadLine(), out double numero2))
    {
        Console.WriteLine("El valor que ha ingresado no es un numero valido");
        return;
    }
    else
    {
        Console.WriteLine("Maximo entre " + numero1 + " y " + numero2 + ": " + Math.Max(numero1, numero2));
        Console.WriteLine("Minimo entre " + numero1 + " y " + numero2 + ": " + Math.Min(numero1, numero2));
    }
}

//Ejercicio 4
Console.WriteLine("--------Trabajando con String-------------");
Console.WriteLine("Ingresar un texto: ");
string texto = Console.ReadLine();

int longitud = texto.Length;
Console.WriteLine("La longitud de la cadena de texto es: " + longitud);

Console.WriteLine("Ingresar otro texto");
string texto2 = Console.ReadLine();
string textoConcatenado = texto + texto2;
Console.WriteLine("Cadenas concatenadas: " + textoConcatenado);

Console.WriteLine("Ingresar el indice de inicio para la subcadena (primer texto): ");
int indiceInicio = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar la longitud de la subcadena:");
int longitudSubcadena = int.Parse(Console.ReadLine());
string subcadena = texto.Substring(indiceInicio, longitudSubcadena);
Console.WriteLine("La subcadena extraída es: " + subcadena);

Console.WriteLine("Recorrer la cadena con foreach");
foreach (char caracter in texto)
{
    Console.WriteLine(caracter);
}
Console.WriteLine("Ingresar la palabra a buscar en la cadena:");
string palabraBuscada = Console.ReadLine();
if (texto.Contains(palabraBuscada))
{
    Console.WriteLine("La palabra "+palabraBuscada+" se encuentra en el texto");
}else{
    Console.WriteLine("No se encuentra la palabra "+palabraBuscada+" en el texto");

}

string textoMay = texto.ToUpper();
string textoMin = texto.ToLower();
Console.WriteLine("El texto en mayusculas: "+ textoMay);
Console.WriteLine("El texto en minusculas: "+ textoMin);


Console.WriteLine("Ingrese una cadena separada por caracteres:");
string cadenaSeparada = Console.ReadLine();
string[] partes = cadenaSeparada.Split(',');
Console.WriteLine("Resultados:");
foreach (string parte in partes)
{
Console.WriteLine(parte);
}

Console.WriteLine("Ingresar una ecuacion que incluya(+,-,*,/) por ejemplo: 582+2 o 4/2 ");
string ecuacion = Console.ReadLine();
if (ecuacion.Contains("+"))
{
    string [] numeros = ecuacion.Split('+');
    double resultado = double.Parse(numeros[0])+double.Parse(numeros[1]);
    Console.WriteLine(ecuacion + "=" + resultado);
}
if (ecuacion.Contains("-"))
{
    string [] numeros = ecuacion.Split('-');
    double resultado = double.Parse(numeros[0])-double.Parse(numeros[1]);
    Console.WriteLine(ecuacion+"="+ resultado);
}
if (ecuacion.Contains("*"))
{
    string [] numeros = ecuacion.Split('*');
    double resultado = double.Parse(numeros[0])*double.Parse(numeros[1]);
    Console.WriteLine(ecuacion + "=" + resultado);
}
if (ecuacion.Contains("/"))
{
    string [] numeros = ecuacion.Split('/');
    double resultado = double.Parse(numeros[0])/double.Parse(numeros[1]);
    Console.WriteLine(ecuacion+"="+ resultado);
}