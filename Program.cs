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
/*
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
*/
/*
public static int Sumar(int a, int b)
    {
        return a + b;
    }
*/
//-----------EJERCICIO 3--------------
int operacion, seguir,num1,num2;
float real;
bool esValido;
do
{
    do
    {
        Console.WriteLine("1) Valor absoluto");
        Console.WriteLine("2) Cuadrado");
        Console.WriteLine("3) Raiz cuadrada");
        Console.WriteLine("4) Seno");
        Console.WriteLine("5) Coseno");
        Console.WriteLine("6) Parte entera de un numero real");
        Console.WriteLine("7) Maximo entre dos numeros");
        Console.WriteLine("8) Minimo entre dos numeros");
        do
            {
                esValido = int.TryParse(Console.ReadLine(), out operacion);
                if (esValido==false)
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
            } while (esValido == false);
    } while (operacion<1 || operacion>8);


        switch (operacion)
        {
            case 1:
                Console.WriteLine("Ingrese el numero: ");
                int.TryParse(Console.ReadLine(), out num1);
                if (num1<0)
                {
                    num1 = num1 * (-1);
                }
                Console.WriteLine("El valor absoluto es: "+(num1));
            break;
            case 2:
                Console.WriteLine("Ingrese el numero: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine($"El cuadrado de {num1} es: "+(num1*num1));
            break;
            case 3:
                Console.WriteLine("Ingrese el numero: ");
                do
                {
                    int.TryParse(Console.ReadLine(), out num1);
                    if (num1<0)
                    {
                         Console.WriteLine("Ingrese un numero >= 0: ");
                    }
                } while (num1<0);
                Console.WriteLine($"La raiz cuadrada de {num1} es: "+(Math.Sqrt(num1)));
            break;
            case 4:
                Console.WriteLine("Ingrese el numero: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine($"El Sen({num1}) es: "+(Math.Sin(num1)));
            break;
            case 5:
                Console.WriteLine("Ingrese el numero: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine($"El Cos({num1}) es: "+(Math.Cos(num1)));
            break;
            case 6:
                Console.WriteLine("Ingrese el numero (Decimal con (,)): ");
                float.TryParse(Console.ReadLine(), out real);
                Console.WriteLine($"La parte entera de {real} es: "+(Math.Truncate(real)));
            break;
            case 7:
                Console.WriteLine("Ingrese num1: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Ingrese num2: ");
                int.TryParse(Console.ReadLine(), out num2);
                if (num1>=num2)
                {
                    Console.WriteLine($"El numero mayor entre {num1} y {num2} es: "+num1);
                }else{
                    Console.WriteLine($"El numero mayor entre {num1} y {num2} es: "+num2);
                }     
            break;
             case 8:
                Console.WriteLine("Ingrese num1: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Ingrese num2: ");
                int.TryParse(Console.ReadLine(), out num2);
                if (num1>=num2)
                {
                    Console.WriteLine($"El numero menor entre {num1} y {num2} es: "+num2);
                }else{
                    Console.WriteLine($"El numero menor entre {num1} y {num2} es: "+num1);
                }     
            break;

          
        }
        Console.WriteLine("Desea seguir operando (1-Si 0-NO) ");
        do
            {
                esValido = int.TryParse(Console.ReadLine(), out seguir);
                if (esValido==false)
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
            } while (esValido == false || seguir>1 || seguir<0);
} while (seguir!=0);
    