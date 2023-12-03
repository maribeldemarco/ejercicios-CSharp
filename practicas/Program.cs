
using System;


namespace Principal

{

class Programa1 {

 public static void Main(string[] args) //funcion principal
    {
        Estudiantes estudiante1;
        estudiante1= new Estudiantes ();
        estudiante1.edad= 23;
        estudiante1.nombre="Ana";
        estudiante1.apellido= "Gomez";
        estudiante1.legajo=1234;
        estudiante1.carrera= "Desarrollo de Software";
        Console.WriteLine (estudiante1.edad);
        Profesores profesor1;
        profesor1= new Profesores();
        profesor1.materia= "Matematica";
        profesor1.nombre= "viviana";
        profesor1.apellido=" Perez";
        profesor1.telefono ="119999999";
        Console.WriteLine (profesor1.apellido);
        Console.WriteLine(estudiante1.devuelveDatosEstudiantes());

    }
}
}
