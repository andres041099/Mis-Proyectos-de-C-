//Tipos de asociaciones

//Composicion
//Herencia




//Agregacion. Asociacion debil que cuando se borra el padre, queda el hijo
using clase61erejemplo;

Profesor prof1 = new Profesor("Juan", 43);
Profesor prof2 = new Profesor("María", 52);

Departamento dpto1 = new Departamento("Ciencias");
Departamento dpto2 = new Departamento("Humanidades");

dpto1.AgregarProfesor(prof1);
dpto2.AgregarProfesor(prof2);
dpto1.AgregarProfesor(prof2);

dpto2 = null;
dpto1 = null;

/*Console.WriteLine(dpto1);
Console.WriteLine(dpto2);*/

Console.WriteLine(prof1);