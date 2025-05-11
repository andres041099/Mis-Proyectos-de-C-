/*Andres Rodriguez Liberato, Matricula 100520391*/
int celcius;
double farenheit;
double kelvin;
double reeconvercion;
Console.WriteLine("Ingresa tu Grado Celciu:");
celcius = (int)double.Parse(Console.ReadLine());
farenheit = (celcius * 1.8) + 32;
reeconvercion = (farenheit - 32)/ 1.8;
kelvin = (reeconvercion + 273.15) * 1.8;
Console.WriteLine("El Grado que Ingresaste fue: "+ celcius);
Console.WriteLine("Tu Grados Convertidos son");
Console.WriteLine(farenheit+"F");
Console.WriteLine(reeconvercion+"C");
Console.WriteLine(kelvin+"K");
Console.WriteLine("La solucion Desarrollada es:");
Console.WriteLine("F=("+celcius+" * 1.8) + 32=" +farenheit+ "F");
Console.WriteLine("C= ("+reeconvercion+" + 32) / 5/9= " +celcius+ "C");
Console.WriteLine("K= ("+reeconvercion+" + 273.15) * 5/9= " +kelvin+ "K");
Console.WriteLine("Programa Hecho por Andres Rodriguez Liberato, Matricula 100520391");
Console.WriteLine("Gracias por Usar Mi Programa. Usalo Pronto.....");

