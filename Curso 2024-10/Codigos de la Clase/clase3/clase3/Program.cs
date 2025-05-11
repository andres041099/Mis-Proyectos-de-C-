// See https://aka.ms/new-console-template for more information
using clase3;

Console.WriteLine("FOREACH");

//FOREACH ( TIPODATO item IN LISTA )
//{ Cuerpo }

int[] numeros = {1,2,3,4,5};
//int[] numeros = new int[5]{1,2,3,4,5}; 
//int[] numeros = new int[5];
//numeros[0] = 1; etc

foreach (int numero in numeros) 
{
    Console.WriteLine(numero);
}



//////////////////////////////////////////////
Console.WriteLine("--------COLECCION GENERICA-------");
//List<OBJETO> identificador = new List<TIPODATO>;

List<string> listaNombres = new List<string>() 
{
    "Esdras",
    "Julia",
    "Agustina"
};

listaNombres.Add("Esdras");
listaNombres.Add("Nehemias");
listaNombres.Add("Erwin");
listaNombres.Add("Naruto");

Console.WriteLine(listaNombres[0]);    

Console.WriteLine("Todos los nombres en la lista:");
for (int i = 0; i < listaNombres.Count; i++)
{
    Console.WriteLine(listaNombres[i]);
}

foreach (var nombre in listaNombres)
{
    Console.WriteLine(nombre);
}

//ver en que casillero se encuentra
int data = listaNombres.IndexOf("Esdras");

Console.WriteLine(data);

//creacion de otra lista
List<string> nombres = new List<string> { "Alice", "Bob", "Charlie" };

// Acceder al primer elemento
string primerNombre = nombres[0];
Console.WriteLine($"El primer nombre es: {primerNombre}");

// Acceder al segundo elemento
string segundoNombre = nombres[1];
Console.WriteLine($"El segundo nombre es: {segundoNombre}");

// Verificar si un elemento está en la lista
bool contieneBob = nombres.Contains("Bob");
Console.WriteLine($"¿La lista contiene a Bob? {contieneBob}");

// Encontrar el índice de un elemento
int indiceDeCharlie = nombres.IndexOf("Charlie");
Console.WriteLine($"El índice de Charlie es: {indiceDeCharlie}");

// Obtener un subconjunto de la lista
List<string> subLista = listaNombres.GetRange(1, 3); // Obtiene 3 elementos comenzando desde el índice 1

Console.WriteLine("Subconjunto de la 1ra lista:");
foreach (string nombre in subLista)
{
    Console.WriteLine(nombre);
}



///////////////////////////////////////////////////
//DICCIONARIOS
//DICTIONARY<KEY, VALUE>videntificador = new Dictionary,KEY, VALUE>;

Console.WriteLine("------------DICTIONARIOS---------------");
/*
Dictionary<string,Dictionary<string, string> > inventario = new Dictionary<string,Dictionary<string, string>>();

Dictionary<string, string> descripcionArticuloCocacola = new Dictionary<string, string>() 
{
    {"descripcion","cocacola ligth"},
    {"precio","25"}
};

Dictionary<string, string> descripcionArticuloAgua = new Dictionary<string, string>()
{
    {"descripcion","agua pura mineral"},
    {"precio","10.00"}
};

inventario.Add("cocaCola", descripcionArticuloCocacola);
inventario.Add("agua", descripcionArticuloAgua);
Console.WriteLine("----------------------------");
Console.WriteLine(inventario["cocaCola"]["precio"]);
Console.WriteLine(inventario["agua"]["precio"]);
*/

Dictionary<string, int> notas = new Dictionary<string, int>
{
    { "Esdras", 88 },
    { "Nehemias", 80 },
    { "Julian", 95 }
};

Dictionary<int, int> invento = new Dictionary<int, int>
{
    { 1, 88 },
    { 0, 80 },
    { 3, 95 }
};
Console.WriteLine("EL GANADOR ESSSSSSSS");
int premisa = invento[0];
Console.WriteLine(premisa);

notas.Add("Alberto", 95);

// Acceder a datos específicos en el diccionario
int notaDeEsdras = notas["Esdras"]+12;
Console.WriteLine($"La nota de Esdras es: {notaDeEsdras}");

//Verificar si clave existe
if (notas.ContainsKey("Esdras"))
{
    notaDeEsdras = notas["Esdras"];
    Console.WriteLine($"La nota de Esdras es: {notaDeEsdras}");
}
else
{
    Console.WriteLine("Esdras no se encuentra en el diccionario.");
}

//Usando el tryGetValue
int notaDeNehemias;
if (notas.TryGetValue("Luisa", out notaDeNehemias))
{
    Console.WriteLine($"La nota de Luisa es: {notaDeNehemias}");
}
else
{
    Console.WriteLine("Luisa no se encuentra en el diccionario.");
}

Console.Write("Escribe el nombre que deseas buscar en la lista: ");
string nombreBuscado = Console.ReadLine();
if (notas.TryGetValue(nombreBuscado, out notaDeNehemias))
{
    Console.WriteLine($"La nota de {nombreBuscado} es: {notaDeNehemias}");
}
else
{
    Console.WriteLine($"{nombreBuscado} no se encuentra en el diccionario.");
}

///EJEMPLO DE LOGIN SIMULADO CON DICCIONARIO
// Diccionario que almacena los nombres de usuario y contraseñas
Dictionary<string, string> usuarios = new Dictionary<string, string>
{
    { "esdras", "password123" },
    { "Julissa", "mypassword" },
    { "Ailin", "pass123" }
};

int intentosPermitidos = 3;
int intento = 0;

//Console.WriteLine(usuarios["esdras"]); //= password123
// Solicitar al usuario que ingrese su nombre de usuario
Console.WriteLine("BIENVENDIO AL INICIO DE USUARIO");
do
{
    Console.Write("Ingrese su nombre de usuario: ");
    string nombreUsuario = Console.ReadLine();

    if (usuarios.ContainsKey(nombreUsuario))
    {
        Console.Write("Ingrese su contraseña: ");
        string contrasena = Console.ReadLine();

        // Verificar si la contraseña es correcta
        if (usuarios[nombreUsuario] == contrasena)
        {
            Console.WriteLine("Inicio de sesión exitoso. ¡Bienvenido!");
            Console.ReadKey();
            break;
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta.");
            Console.ReadKey();
            intento++;
        }
    }
    else 
    {
        Console.WriteLine("Nombre de usuario no encontrado.");
        Console.ReadKey();
        intento++;
    }

} while (intento < intentosPermitidos);

if (intento == intentosPermitidos) Console.WriteLine("NO SE PERMITIRAN MAS INTENTOS");


///////////////////////////////////////////////////////////////
///


//POO
Console.WriteLine("---------------POO------------");
//public class NombreClase

Persona p1 = new Persona(); //instanciar un objeto
Persona p2 = new Persona();

p1.nombre = "Esdras";
p1.edad = 23;
p1.estatura = 5.11;
p1.color = "mestizo";

p1.presentate();

p2.nombre = "Jubal";
p2.edad = 19;
p2.estatura = 7.00;
p2.color = "verde";

p2 = p1;

p2.presentate();
p1.presentate();

p1.respirar();
p2.respirar();

List<Persona> listaPersonas = new List<Persona>();

listaPersonas.Add(p1);
listaPersonas.Add(p2);

//Ejemplo con objetos no creados

/*foreach (var persona in listaPersonas)
{
    persona.presentate();
}*/
