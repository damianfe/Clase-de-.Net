 /* ejemplo de condificional if */

console.writeline("Ingrese su edad:");// le ṕedimos al usuario que ingrese
int edad = int.Parse(console.Readline());
console.Write("Ingrese su equipo de futbol");
string equipo = console.Readline();

// AND -> &&(Y)
//OR -> ||  (O)
//Igual que -> ==
//distinto que -> !=

console.Writeline("La edad ingresada es : "+ edad);
bool condicion = edad < 18 && equipo == "San Lorenzo";

if (condicion) //evaluamos la edad
{
    console.Writeline("Usted es Menor de edad."); //intrucciones si se cumple la condicion evaluada
    console. Writeline("prohibida la entrada");
}else{
    console.Writeline("usted es mayor  de edad. ");// intrucciones si no se cumple condicion evaluada
}