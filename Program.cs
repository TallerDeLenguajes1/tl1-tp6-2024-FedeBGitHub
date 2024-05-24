// See https://aka.ms/new-console-template for more information
using System.Net.Mail;
using System.Reflection.Metadata;

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
        Console.WriteLine("1) Sumar");
        Console.WriteLine("2) Restar");
        Console.WriteLine("3) Multiplicar");
        Console.WriteLine("4) Dividir");
        Console.WriteLine("5) Valor absoluto");
        Console.WriteLine("6) Cuadrado");
        Console.WriteLine("7) Raiz cuadrada");
        Console.WriteLine("8) Seno");
        Console.WriteLine("9) Coseno");
        Console.WriteLine("10) Parte entera de un numero real");
        Console.WriteLine("11) Maximo entre dos numeros");
        Console.WriteLine("12) Minimo entre dos numeros");
        do
            {
                esValido = int.TryParse(Console.ReadLine(), out operacion);
                if (esValido==false)
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
            } while (esValido == false);
    } while (operacion<1 || operacion>12);


        switch (operacion)
        {
             case 1:
                Console.WriteLine("Ingrese num1: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Ingrese num2: ");
                int.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("La suma resultante es: "+(num1+num2));
                //muestro en texto el resultado
                int res=num1 +num2;
                Console.WriteLine($"La suma de {num1} y de {num2} es igual a: "+res.ToString());

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
                real = (float)num1/num2;
                Console.WriteLine("La division resultante es: "+real);
            break;
            case 5:
                Console.WriteLine("Ingrese el numero: ");
                int.TryParse(Console.ReadLine(), out num1);
                if (num1<0)
                {
                    num1 = num1 * (-1);
                }
                Console.WriteLine("El valor absoluto es: "+(num1));
            break;
            case 6:
                Console.WriteLine("Ingrese el numero: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine($"El cuadrado de {num1} es: "+(num1*num1));
            break;
            case 7:
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
            case 8:
                Console.WriteLine("Ingrese el numero: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine($"El Sen({num1}) es: "+(Math.Sin(num1)));
            break;
            case 9:
                Console.WriteLine("Ingrese el numero: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine($"El Cos({num1}) es: "+(Math.Cos(num1)));
            break;
            case 10:
                Console.WriteLine("Ingrese el numero (Decimal con (,)): ");
                float.TryParse(Console.ReadLine(), out real);
                Console.WriteLine($"La parte entera de {real} es: "+(Math.Truncate(real)));
            break;
            case 11:
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
             case 12:
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
    

//------EJERCICIO 4----------------
string cadena1,cadena2;

// longitud de una cadena
Console.WriteLine("Ingrese una cadena de texto: ");
cadena1 = Console.ReadLine();
Console.WriteLine(cadena1 + " | Longitud : "+cadena1.Length);

// a partir de una segunda cadena concatenar las dos cadenas
Console.WriteLine("Ingrese otra cadena de texto: ");
cadena2 = Console.ReadLine();
Console.WriteLine(cadena1+cadena2);
//Console.WriteLine(string.Concat(cadena1,cadena2)); otra forma de concatenar

// obtener subcadena de cadena ingresada
int indiceInicial1 = 2; // Índice donde comienza la subcadena
int longitud1 = 4; // Longitud de la subcadena a extraer
Console.WriteLine("Subcadena de cadena1: "+cadena1.Substring(indiceInicial1, longitud1));
// recorrer la cadena de texto con foreach y mostrar elemento por elemento en pantalla
Console.WriteLine("Recorriendo cadena1: ");
foreach (char caracter in cadena1)
{
    Console.WriteLine(caracter);
}

//buscar una ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("Ingrese una palabra a buscar en la primera cadena ingresada: ");
string palabraBuscada = Console.ReadLine();
//int indice = frase.IndexOf(palabraBuscada, StringComparison.OrdinalIgnoreCase);
//StringComparison.OrdinalIgnoreCase se utiliza para realizar la búsqueda de manera insensible a mayúsculas y minúsculas.
int indice = cadena1.IndexOf(palabraBuscada);
if (indice != -1)
{
    Console.WriteLine($"La palabra {palabraBuscada} empieza en la posicion: "+indice);
}else{
    Console.WriteLine($"La palabra {palabraBuscada} No se encuentra");
}

// Convierta la cadena a mayusculas y luego a minusculas
Console.WriteLine($"La cadena1 en mayusculas: "+cadena1.ToUpper());
Console.WriteLine($"La cadena1 en minusculas: "+cadena1.ToLower());

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados
Console.WriteLine("Ingrese un cadena separada por \";\" :");
string frase = Console.ReadLine();
string[] palabras = frase.Split(';');
foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}

//Ingrese un ecuacin simple como cadena de caracteres y que el sistema lo resuelva
Console.WriteLine("Ingrese una ecucacion simple (de sumas y restas): ");
string ecuacion = Console.ReadLine();
int longitudEcuacion = ecuacion.Length;
int n2;
int n3=0;
int indiceInicial = 0; 
int longitud = 0;
char signo='+';
for (int i = 0; i < longitudEcuacion; i++)
{

    if (ecuacion[i] == '+')
    {
        int.TryParse(ecuacion.Substring(indiceInicial, longitud),out n2);
        if (signo=='+')
        {
             n3+=n2;
        }else{
             n3-=n2;
        }
        signo = ecuacion[i];
        indiceInicial = i+1; 
        longitud= 0;
        i++;
    }
    if (ecuacion[i] == '-')
    {
        int.TryParse(ecuacion.Substring(indiceInicial, longitud),out n2);
        if (signo=='+')
        {
             n3+=n2;
        }else{
             n3-=n2;
        }
        signo = ecuacion[i];
        indiceInicial = i+1; 
        longitud= 0;
        i++;
    }
    if (i==longitudEcuacion-1)
    {
        longitud = longitudEcuacion-indiceInicial;
        int.TryParse(ecuacion.Substring(indiceInicial, longitud),out n2);
        switch (signo)
        {
            case '+':
                n3 += n2;
            break;
            case '-':
                n3 -= n2;
            break;

            default:
                n3 += n2;
            break;
           
        }
        
    }
    longitud++;
}
Console.WriteLine($"La ecuacion: {ecuacion} = "+n3);

/*
string[] operar = ecuacion.Split('+');
int suma = 0;
int n;
foreach (string operando in operar)
{
    int.TryParse(operando, out n);
    suma = suma + n;
};
Console.WriteLine($"La ecuacion: {ecuacion} = "+suma);
*/
