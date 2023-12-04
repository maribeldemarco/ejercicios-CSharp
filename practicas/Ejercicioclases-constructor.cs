//todos tienen el mismo namespace

namespace Principal
{


    class Mascotas
    {

        public string nombre;
        public string animal;
        public int edad;
        public string caracter;

        public Mascotas(string nombre, string animal, int edad, string caracter)
        {
            this.nombre = nombre;
            this.animal = animal;
            this.edad = edad;
            this.caracter = caracter;

        }

        public string muestraDatosDeMascota()
        {

            return "el nombre de la mascota es " + this.nombre + " la edad de la mascota es " + this.edad +
            " el caracter de la mascota es " + this.caracter + " y el animal es un " + this.animal;
        }


    }





}