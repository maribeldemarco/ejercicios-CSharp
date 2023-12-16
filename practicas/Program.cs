
using System;


namespace Principal

{

    class Programa1
    {

        public static void Main(string[] args) //funcion principal
        {

            // para ver el codigo, ir a archivo Ejerciciopoo-clasesyfunciones.cs 
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
            estudiante1.devuelveDatosEstudiantes();// llamo a la funcion sin writeline ya que tiene una writeline dentro
                                                   // ademas la funcion es de tipo void porque no tiene un return dentro
            resultadoestudiante = estudiante1.retornaDatosEstudiantes();
            Console.WriteLine(resultadoestudiante);//uso el writeline ya que guarde el resultado en una variable (la funcion tenia un return, sino no hubiera podido)
            Console.WriteLine("-----");

            // para ver el codigo, ir a archivo Ejerciciopoo-clases.cs 

            Profesores profesor1;
            profesor1 = new Profesores();
            profesor1.materia = "Matematica";
            profesor1.nombre = "viviana";
            profesor1.apellido = " Perez";
            profesor1.telefono = "119999999";
            Console.WriteLine(profesor1.apellido);
            Console.WriteLine("-----");

            // para ver el codigo, ir a archivo Ejerciciopoo-clasesyconstructores.cs 

            Mascotas mimascota1;
            mimascota1 = new Mascotas("abath", "gato", 8, "amigable");
            datosmimascota = mimascota1.muestraDatosDeMascota();
            Console.WriteLine(datosmimascota);
            Mascotas mimascota2;
            mimascota2 = new Mascotas("kunio", "gato", 4, "jugueton");
            Console.WriteLine(mimascota2.muestraDatosDeMascota());
            Console.WriteLine("-----");

            // para ver el codigo, ir a archivo Ejerciciopoo-clasesyarrays.cs 

            Empleados[] misempleados; // le indico que va a ser de tipo array
            misempleados = new Empleados[2];// le digo el tamano
            misempleados[0] = new Empleados("Brian", "Alvarez", 8, 270000.9);
            misempleados[1] = new Empleados("Linda", "Alvarez", 2, 160000.8);
            misempleados[0].muestraDatosEmpleados();
            misempleados[0].sueldo = 310000.7;
            misempleados[0].muestraDatosEmpleados();
            misempleados[0].SetAntiguedad(1);
            misempleados[0].muestraDatosEmpleados();
            Console.WriteLine("-----");

            // para ver el codigo, ir a archivo    Ejerciciopoo-clasesasociadas.cs
            Participantes miparticipante;
            Fecha datospersona;
            datospersona = new Fecha(19, 8, 1991);
            miparticipante = new Participantes("Mercedes", "Perez", 12, datospersona);
            datosparticipante = miparticipante.devuelveParticipantes();
            Console.WriteLine(datosparticipante);
            miparticipante.apellido = "Gomez";
            datosparticipante = miparticipante.devuelveParticipantes();
            Console.WriteLine(datosparticipante);
            Console.WriteLine("-----");


            // para ver el codigo, ir a archivo    Ejerciciopoo-sobrecargametodos.cs
            string muestra;
            Gatos[] gatosatendidos;
            gatosatendidos = new Gatos[3];
            gatosatendidos[0] = new Gatos(true, 8, 1, "Gipsi", "12344456", "Alicia", "Bonelli", "1555554879");
            gatosatendidos[1] = new Gatos(false, 1, 2, "Any", "1234577", "Amanda", "Rodriguez", "1555554870");
            gatosatendidos[2] = new Gatos(false, 3, 3, "Bigotes", "10234567", "Dario", "Zapata", "1556554870");
            muestra = gatosatendidos[0].MuestraDatos();
            Console.WriteLine(muestra);
            gatosatendidos[0].SetDatosGato(2);
            muestra = gatosatendidos[0].MuestraDatos();
            Console.WriteLine(muestra);
            gatosatendidos[0].SetDatosGato(false);
            muestra = gatosatendidos[0].MuestraDatos();
            Console.WriteLine(muestra);
            gatosatendidos[0].SetDatosGato(true, 8);
            muestra = gatosatendidos[0].MuestraDatos();
            Console.WriteLine(muestra);
            Console.WriteLine("-----");

            // para ver el codigo, ir a archivo Ejerciciopoo-herencia-claseabstracta.cs
            Colectivo primercolectivo;
            primercolectivo = new Colectivo("ABC123", 93, 134.2, "Boedo", "Retiro", 34);
            primercolectivo.Datosviaje();
            Tren primertren;
            primertren = new Tren("Avellaneda", "12.45", 130.50, "Zona Sur", "La Plata", 120);
            primertren.Datosviaje();
            Console.WriteLine("-----");

            // para ver el codigo, ir a archivo Ejerciciopoo-herencia.cs

            Bebidas mibebida;
            mibebida = new Bebidas(1200.23, 200);
            mibebida.Datosbebida();
            Gaseosa mibebida2;
            mibebida2 = new Gaseosa("Pepsi", "gaseosa cola", 1500, 1200);
            mibebida2.Datosbebida();
            Agua mibebida3;
            mibebida3 = new Agua("villavicencio", "sin gas", 650, 12000);
            mibebida3.Datosbebida();
            Console.WriteLine("-----");

            // para ver el codigo, ir a archivo Ejerciciopoo-excepciones.cs
            Division midivision;
            midivision = new Division();
            midivision.CalculoDivision();
            Console.WriteLine("-----");

            // para ver el codigo, ir a archivo Ejerciciopoo-excepciones2.cs

            Miexcepcion miExcepcion = new Miexcepcion();
            miExcepcion.ControlError();
            Console.WriteLine("-----");
            // para ver el codigo, ir a archivo Ejerciciopoo-excepciones3.cs

            Miexcepcion2 miexcepcion2;
            miexcepcion2 = new Miexcepcion2();
            miexcepcion2.ControlError();
            Console.WriteLine("-----");

            // para ver el codigo, ir a archivo Ejerciciopoo-interfaces.cs
            Perro miperro;
            miperro = new Perro("Pichu", 13);
            miperro.Comer();
            Gato migato;
            migato = new Gato("Kuni", 5);
            migato.Comer();
            migato.Mostrardatosdelanimal();
            Console.WriteLine("-----");
        //Para ver el codigo ir a archivo Ejerciciopoo-listas.cs
        MiLista milista;
        milista =new MiLista();
        milista.AgregaraLista("abath");
        milista.AgregaraLista("kuni");
        milista.mostrarLista();
        milista.eliminarEnLista("abath");
        milista.mostrarLista();
        milista.AgregaraLista("Abath");
        milista.AgregaraLista("Pichu");
        milista.AgregaraLista("Jazmin");
        milista.OrdenoAlfabeticamente();
        milista.mostrarLista();        
        milista.borroElementoNumero(1);
        milista.mostrarLista();        



        }
    }




}
