
namespace Principal{


class Empleados
{public string nombre;
 public string apellido;
 public int antiguedad;
 public double sueldo;
 
public Empleados (string nombre, string apellido, int antiguedad, double sueldo){
this.nombre=nombre;
this.apellido=apellido;
this.antiguedad=antiguedad;
this.sueldo=sueldo;
}

public void muestraDatosEmpleados(){
    Console.WriteLine ("el nombre del empleado es "+ this.nombre + " el apellido es "+this.apellido+ " el sueldo es "+this.sueldo+ " y la antiguedad es "+ this.antiguedad);
}

public void SetAntiguedad(int antiguedad){
this.antiguedad=antiguedad;
}

 }

}
