
using System;


namespace Principal

{

class Programa1 {

 public static void Main(string[] args) //funcion principal
    {   string resultadoestudiante, datosmimascota;
        datosmimascota="";
         resultadoestudiante = "";
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
        estudiante1.devuelveDatosEstudiantes();// llamo a la funcion sin writeline ya que tiene una writeline dentro
  // ademas la funcion es de tipo void porque no tiene un return dentro
        resultadoestudiante= estudiante1.retornaDatosEstudiantes();
        Console.WriteLine(resultadoestudiante);//uso el writeline ya que guarde el resultado en una variable (la funcion tenia un return, sino no hubiera podido)
        Mascotas mimascota1;
        mimascota1= new Mascotas( "abath","gato",8,"amigable");
        datosmimascota=mimascota1.muestraDatosDeMascota();
        Console.WriteLine(datosmimascota);
        Mascotas mimascota2;
        mimascota2= new Mascotas("kunio", "gato", 4, "jugueton");
        Console.WriteLine(mimascota2.muestraDatosDeMascota());        
    }
}
}