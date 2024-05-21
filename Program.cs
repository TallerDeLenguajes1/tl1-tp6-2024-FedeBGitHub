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

//------------EJERCICIO 2------------
int operacion=0,seguir=1,num1,num2;
bool esValido = false;
Console.WriteLine("-------CALCULADORAV1------");

    do
    {
        do
        {
            Console.WriteLine("1) Sumar");
            Console.WriteLine("2) Restar");
            Console.WriteLine("3) Multiplicar");
            Console.WriteLine("4) Dividir");
             do
            {
                esValido = int.TryParse(Console.ReadLine(), out operacion);
                if (esValido==false)
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
            } while (esValido == false);
        } while (operacion<1 || operacion>4);
       
       
       

        switch (operacion)
        {
            case 1:
                Console.WriteLine("Ingrese num1: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Ingrese num2: ");
                int.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("La suma resultante es: "+(num1+num2));
            break;
            case 2:
                Console.WriteLine("Ingrese num1: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Ingrese num2: ");
                int.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("La resta resultante es: "+(num1-num2));
            break;
            
             case 3:
                Console.WriteLine("Ingrese num1: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Ingrese num2: ");
                int.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("La multiplicacion resultante es: "+(num1*num2));
            break;
            case 4:
                Console.WriteLine("Ingrese num1: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Ingrese num2(No puede ser 0): ");
                do{
                    int.TryParse(Console.ReadLine(), out num2);;
                    if(num2==0){
                        Console.WriteLine("No puede ingresar 0");
                    }
                } while (num2==0);
                float real = (float)num1/num2;
                Console.WriteLine("La division resultante es: "+real);
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

//------------EJERCICIO 3------------