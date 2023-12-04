
using System;


namespace Principal

{

    class Programa1
    {

        public static void Main(string[] args) //funcion principal
        {
            string resultadoestudiante, datosmimascota, datosparticipante;
            datosmimascota = "";
            resultadoestudiante = "";
            Estudiantes estudiante1;
            estudiante1 = new Estudiantes();
            estudiante1.edad = 23;
            estudiante1.nombre = "Ana";
            estudiante1.apellido = "Gomez";
            estudiante1.legajo = 1234;
            estudiante1.carrera = "Desarrollo de Software";
            Console.WriteLine(estudiante1.edad);
            Profesores profesor1;
            profesor1 = new Profesores();
            profesor1.materia = "Matematica";
            profesor1.nombre = "viviana";
            profesor1.apellido = " Perez";
            profesor1.telefono = "119999999";
            Console.WriteLine(profesor1.apellido);
            estudiante1.devuelveDatosEstudiantes();// llamo a la funcion sin writeline ya que tiene una writeline dentro
                                                   // ademas la funcion es de tipo void porque no tiene un return dentro
            resultadoestudiante = estudiante1.retornaDatosEstudiantes();
            Console.WriteLine(resultadoestudiante);//uso el writeline ya que guarde el resultado en una variable (la funcion tenia un return, sino no hubiera podido)
            Mascotas mimascota1;
            mimascota1 = new Mascotas("abath", "gato", 8, "amigable");
            datosmimascota = mimascota1.muestraDatosDeMascota();
            Console.WriteLine(datosmimascota);
            Mascotas mimascota2;
            mimascota2 = new Mascotas("kunio", "gato", 4, "jugueton");
            Console.WriteLine(mimascota2.muestraDatosDeMascota());
            Empleados[] misempleados; // le indico que va a ser de tipo array
            misempleados = new Empleados[2];// le digo el tamano
            misempleados[0] = new Empleados("Brian", "Alvarez", 8, 270000.9);
            misempleados[1] = new Empleados("Linda", "Alvarez", 2, 160000.8);
            misempleados[0].muestraDatosEmpleados();
            misempleados[0].sueldo = 310000.7;
            misempleados[0].muestraDatosEmpleados();
            misempleados[0].SetAntiguedad(1);
            misempleados[0].muestraDatosEmpleados();
            Participantes miparticipante;
            Fecha datospersona;
            datospersona = new Fecha(19, 8, 1991);
            miparticipante = new Participantes("Mercedes", "Perez", 12, datospersona);
            datosparticipante = miparticipante.devuelveParticipantes();
            Console.WriteLine(datosparticipante);
            miparticipante.apellido = "Gomez";
            datosparticipante = miparticipante.devuelveParticipantes();
            Console.WriteLine(datosparticipante);
            string muestra;
            Gatos [] gatosatendidos;
            gatosatendidos=new Gatos[3];
            gatosatendidos[0]= new Gatos (true, 8, 1, "Gipsi",  "12344456",  "Alicia",  "Bonelli",  "1555554879" );
            gatosatendidos[1]= new Gatos (false,1, 2, "Any",  "1234577",  "Amanda",  "Rodriguez",  "1555554870");
            gatosatendidos[2]= new Gatos (false,3, 3, "Bigotes",  "10234567",  "Dario",  "Zapata",  "1556554870");
            muestra=gatosatendidos[0].MuestraDatos();
            Console.WriteLine(muestra);
            gatosatendidos[0].SetDatosGato(2);
            muestra=gatosatendidos[0].MuestraDatos();
            Console.WriteLine(muestra);
            gatosatendidos[0].SetDatosGato(false);
            muestra=gatosatendidos[0].MuestraDatos();
            Console.WriteLine(muestra);
            gatosatendidos[0].SetDatosGato (true,8 );
            muestra=gatosatendidos[0].MuestraDatos();
            Console.WriteLine(muestra);
       }
    }
}
