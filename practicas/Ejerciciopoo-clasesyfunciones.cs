// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
namespace Principal // declaro el nombre de mi espacio
{

    class Estudiantes
    {
        public int edad = 0; //la inicializo en 0
        public string nombre = "";
        public string apellido = "";
        public int legajo;
        public string carrera = "";

        public void devuelveDatosEstudiantes()  //no devuelve nada la funcion, no tiene return, sino un console.writeline por eso es void

        {
            Console.WriteLine("El nombre es " + nombre + " la edad es " + edad + " el apellido es " + apellido +
                               " el legajo es " + legajo + " la carrera es " + carrera);
        }


        public string retornaDatosEstudiantes() // devuelve un string por eso uso el return

        {
            return "El nombre es " + nombre + " la edad es " + edad + " el apellido es " + apellido +
                               " el legajo es  " + legajo + " la carrera es " + carrera;
        }

    }






}
