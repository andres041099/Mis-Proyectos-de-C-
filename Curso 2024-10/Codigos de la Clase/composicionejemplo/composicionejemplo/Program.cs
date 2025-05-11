// COMPOSICION


using composicionejemplo;

Carro elCarro = new Carro("Toyota", "V5", 4);

elCarro = null;
string nombreMotor = elCarro.motor.ToString();

Console.WriteLine(nombreMotor);
//Console.WriteLine(elCarro);