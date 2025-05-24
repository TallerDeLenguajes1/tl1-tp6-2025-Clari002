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