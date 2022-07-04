

using Alumnitos;

var alumno1 = new Alumno();

alumno1.Apellido = "Zalazar";
alumno1.Nombre = "Rocio";
alumno1.Legajo = 1;
alumno1.DNI = "12.345.678";
alumno1.FechaNacimiento = new DateTime(1986, 11, 4);
alumno1.Calificaciones = new List<int>();



var alumno2 = new Alumno()
{
    Apellido = "Fernandez",
    Nombre = "Damian",
    Legajo = 2,
    DNI = "98.765.432",
    FechaNacimiento = new DateTime(2000,6,2)
};


alumno1.CargarCalificacion(5, new DateTime(2022,6,1));
alumno1.CargarCalificacion(9, new DateTime(2022,4,10));
alumno1.CargarCalificacion(8);

Console.WriteLine(alumno1.ObtenerPromedio());