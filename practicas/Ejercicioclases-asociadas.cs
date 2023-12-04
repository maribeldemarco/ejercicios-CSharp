namespace Principal
{


    class Participantes
    {

        public string nombre;
        public string apellido;
        public int id;
        public Fecha fechadenacimiento;

        public Participantes(string nombre, string apellido, int id, Fecha fechanac)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
            this.fechadenacimiento = fechanac;


        }
        public string devuelveParticipantes()
        {
            return this.nombre + " " + this.apellido + " " + this.id + " " + this.fechadenacimiento.dia + " " + this.fechadenacimiento.mes + " " + this.fechadenacimiento.anio;
        }


    }

    class Fecha
    {
        public int dia;
        public int mes;
        public int anio;

        public Fecha(int dia, int mes, int anio)
        {

            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

    }



}