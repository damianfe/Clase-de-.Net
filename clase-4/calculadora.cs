/* Ejemplo del switch*/

Console.Writeline("Ingrese el primer numero: ");

Console.Writeline("1 - Suma");
Console.Writeline("2 - Resta");
Console.Writeline("3 - Multiplicacion");
Console.Writeline("4 - Division");

Console.Writeline("Ingrese la operacion a realizar");
string operacion = Console.Readline();

switch (operacion)
{
    case"1":
    Console.Writeline("Sumando...");
    break;
    case"2":
    Console.Writeline("Restando...");
    break;
    case"3":
    Console.Writeline("Multiplicando...");
    break;
    case"4":
    Console.Writeline("Diviendo...");
    break;
    default:
    Console.Writeline("Ingreso una opcion invalida");
}