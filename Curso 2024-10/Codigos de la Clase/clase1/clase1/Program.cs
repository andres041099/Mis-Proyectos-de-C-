//Impresion
Console.WriteLine("Hello world");

/*
 * int - entero
 * bool - True False
 * double - numero grande con decimales
 * float - numero con decimales pocos
 * char - un caracter
 * string - una cadena de texto
 * long - numero gigante
 * short - numero pequeno
 */
// = operador de asignacion

//TIPO_DATO IDENTIFICADOR = DATO;
string numero_cuenta = "100431577"; //todo string (cadena de caracteres) va entre comillas ""
double balance = 0;
bool activa = true;
float chelitos = 2000;
double chiripa = 1500;
float prestamo = 520.50f;

balance = chelitos;
balance = balance + prestamo;
//balance = balance + chiripa; 

Console.WriteLine("Cuenta");
Console.WriteLine("nro cuenta: " + numero_cuenta);
Console.WriteLine("Balance: RD$" + balance);
Console.WriteLine("Activa: " + activa);
Console.WriteLine("----------------------------");

//Operadores Logicos

bool valor1 = true;
bool valor2 = true;
bool valor3 = false;

// && (Y) sera verdadero solo cuando todos los enunciados sean verdaderos
bool resultadoAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultadoAnd);

// || (O) sera falso solo cuando todos los enunciados sean falsos
bool resultadoOr = valor1 || valor2 || valor3;
Console.WriteLine(resultadoOr);

// Fusion
bool resultadoAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultadoAndOr);

/*
int num1;
var num2 = "hola";

num1 = 2000 + num2;
Console.WriteLine(num1 + num2);    
*/
string nombre;
short edad;

Console.WriteLine("inserte su nombre");
nombre = Console.ReadLine();
Console.WriteLine("inserte su edad ");
edad = short.Parse(Console.ReadLine());

Console.WriteLine("----------------------");
Console.WriteLine("Su nombre es " + nombre);
//Console.WriteLine("Su nombre es ",nombre);

//Console.WriteLine("Su edad es " + edad);
Console.WriteLine($"Su nombre es {nombre} y mi edad es {edad+5}");

