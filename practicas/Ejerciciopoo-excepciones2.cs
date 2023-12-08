
namespace Principal
{ // creo una clase sumaexception que deriva de la clase padre
//exception que es la clase que tiene todas las excepciones del sistema
    public class SumaException : Exception
    {
        public SumaException(string mensaje) : base(mensaje)
        {// en el constructor va a tomar como variable un mensaje que viene de la clase padre exception
        }// o bien si creo el objeto el que ingrese por parametro
    }

    class Miexcepcion // creo mi clase
    {
        int d = 10;
        int c = 20;
        int resultado2 = 0;
        int resultado3 = 0;
        public void ControlError() //el bloque try y catch deben estar dentro de una funcion si o si
        {
            try
            {
                resultado2 = d + c;

                if (resultado2 > 29)
                { //lanzo mi excepcion personalizada si no funciona, es una excepcion de tipo sumaexception y le mando el mensaje que va a crear el objeto
                    throw new SumaException("La suma no puede ser mayor a 29");
                }
                else
                {// sino que muestre el resultado
                    Console.WriteLine("La suma da " + resultado2);
                }
            }
    catch (Exception e)
            {
Console.WriteLine(e.Message);

            }


try {                 resultado3=45/resultado3;


}


            catch (Exception e)
            {
Console.WriteLine(e.Message);

            }
        }
    }
}
