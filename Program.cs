// See https://aka.ms/new-console-template for more information
using System.Net.Mail;

Console.WriteLine("Hello, World!");

int a;

int b;

a=10;

b=a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);


//-------EJERCICIO 1-----------

int invertir,aux,resultado=0;
Console.WriteLine("Ingrese el num a invertir: ");
//bool resultado = int.TryParse(Console.ReadLine(), out invertir);
if (int.TryParse(Console.ReadLine(), out invertir))
{
    if (invertir >0)
    {
        aux = invertir;
        while (aux>0)
        {
            resultado = resultado * 10 + (aux % 10);
            aux = aux/10;
        }
        Console.WriteLine("El numero a Invertir es: "+invertir);
        Console.WriteLine("El numero Invertido: "+resultado);
    }else{
        Console.WriteLine("El numero es NEGATIVO");
    }
}else{
    Console.WriteLine("Lo ingresado no es un numero: ");
}

/*
public static int Sumar(int a, int b)
    {
        return a + b;
    }
*/
