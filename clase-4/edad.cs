console.Writeline("Ingrese la edad: ");
 int edad = int.Parse(Console.Readline());

 if(edad < 0 || edad > 110)
 {
 Console.Writeline("La edad no es valida.");
 }
 else if (edad < 12)
 {
     Console.Writeline("Va a la primaria");
 }
 else if(edad < 18){
     Console.Writeline("Va a la Secundaria");
 }
 else if(edad < 28)
 {
    Console.Writeline("Va a la Universidad");
 }
 else
 {
Console.Writeline("A trabajar, no queda otra.");
}