//Operadores relacionales
/*
== igual a
!= diferente a
> mayor que
< menor que
>= mayo o igual que
<= menor o igual
 */

using System;
using System.Diagnostics;

int valor1 = 5;
int valor2 = 6;

bool resultado = (valor1 == valor2);
Console.WriteLine(resultado);

//Condicional IF
/*
 * IF (CONDICION si es verdadera) { cuerpo }
 * ELSE { cuerpo }
 */

string jugador;
int miSuma = 15;
int dealer = 15;

//Blackjack, juntar 21 pidiendo cartas o en caso de tener menos
// de 21 igual tener mayor puntuacion del dealer
// ((miSuma <=21) && (miSuma > dealer))

if ((miSuma > dealer) && (miSuma <= 21))
{
    Console.WriteLine("Ganaste");
}
else 
{
    Console.WriteLine("Perdiste");
}

//hacer un cajero

//Console.WriteLine("Ingrese la tarjeta");
//Console.ReadLine();
//Console.WriteLine("Ingrese la clave");
//Console.ReadLine();
//Console.WriteLine("[1] retirar 1000 \n[2] Retirar 2000 \n[3] Salir");
//int opcion = int.Parse(Console.ReadLine());
//char opcionChar = char.Parse(Console.ReadLine());

/*if (opcion == 1)
{
    Console.WriteLine("retiraste 1000");
}
if (opcion == 2)
{
    Console.WriteLine("retiraste 2000");
}
if (opcion == 3)
{
    Console.WriteLine("Estas saliendo");
}
else {
    Console.WriteLine("Usted puso un disparate");
}*/

/*
switch (opcionChar)
{
    case '1':
        Console.WriteLine("retiraste 1000");
        break;
    case '2':
        Console.WriteLine("retiraste 2000");
        break;
    case '3':
        Console.WriteLine("Estas saliendo");
        break;
    default:
        Console.WriteLine("Usted puso un disparate");
        break;
}*/
/*
switch (opcion)
{
    case 1:
        Console.WriteLine("retiraste 1000");
        break;
    case 2:
        Console.WriteLine("retiraste 2000");
        break;
    case 3:
        Console.WriteLine("Estas saliendo");
        break;
    default:
        Console.WriteLine("Usted puso un disparate");
        break;
}
*/

//BUCLES

//while - mientras
//while(condicion){cuerpo}
//do{cuerpo} while(condicion)

/*
int iterador = 0;

while (iterador<11) 
{
    Console.WriteLine(iterador + 1);
    iterador++;
}
*/

//cajero nivel 2
/*bool inicio = true;
do
{
    Console.Clear();
    Console.WriteLine("*************************************");
    Console.WriteLine("BIENVENIDO A CAJER C# 2");
    Console.WriteLine("Ingrese la tarjeta");
    Console.ReadLine();
    Console.WriteLine("Ingrese la clave");
    Console.ReadLine();
    Console.WriteLine("[1] retirar 1000 \n[2] Retirar 2000 \n[3] Salir");
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("retiraste 1000");
            break;
        case 2:
            Console.WriteLine("retiraste 2000");
            break;
        case 3:
            Console.WriteLine("Estas saliendo");
            inicio = false;
            break;
        default:
            Console.WriteLine("Usted puso un disparate");
            break;
    }
    Console.Write("Enter para continnuar...");
    Console.ReadKey();
}while (inicio == true);*/

//FOR
// FOR (ITERADOR ; CONDICION ; ACCION)
// { cuerpo }

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + 1);
}*/

//arreglo. Estructra de datos que permite almacenar multiples elementos
//DEL MISMO TIPO en una secuencia ordenada.
//TIPO DE DATO [] identificador = new TIPO DE DATO [cantidad];
//
/*Carateristicas
 * Tamanio fijo
 * tipo de datos homogeneo (igual)
 * acceso por indice
 */

int[] cacilleros = new int[4];

cacilleros[0] = 28;
cacilleros[1] = 30;
cacilleros[2] = 40;
cacilleros[3] = 75;

/*int[] cacillerosSegundo = new int[] { 20, 15, 35, 100, 105, 108, 214 };

cacillerosSegundo[0] = 20;
cacillerosSegundo[1] = 15;
cacillerosSegundo[2] = 35;
cacillerosSegundo[3] = 100;
int dimesion = cacillerosSegundo.Length;
....*/
//ANTES
Console.WriteLine("ANTES");
for (int i = 0; i < cacilleros.Length; i++)
{
    Console.WriteLine(cacilleros[i]);
}

for (int i = 0; i < cacilleros.Length; i++)
{
    Console.Write("Casillero " + i + " :");
    cacilleros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("DESPUES");
for (int i = 0; i < cacilleros.Length ; i++) 
{
    Console.WriteLine(cacilleros[i]);
}

