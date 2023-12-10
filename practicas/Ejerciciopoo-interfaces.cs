
//todos los metodos y atributos que no son privados componen la interfaz
//o sea todo lo publico
//se usa cuando tenemos dos clases que hacen lo mismo pero de distinta
//manera


namespace Principal
{


interface ComportamientoAnimal {
//los metodos y atributos no se declaran como public ya que son publicos 
//por default
//los metodos no se implementan
//no se puede instanciar una interfaz como un objeto
void Comer ();
void Tomaragua();

void Dormir ();

}


interface Datosdelanimal {

void Mostrardatosdelanimal();

}

class Gato : ComportamientoAnimal, Datosdelanimal //le digo a la clase que aplica esa interfaz


{
public string nombre;
public int edad;
    public Gato( string nombre, int edad) {

        this.nombre=nombre;
        this.edad=edad;
    }

public void Comer() {Console.WriteLine("el gato ha comido"); }
public void Dormir() {Console.WriteLine("el gato se fue a dormir");}

public void Tomaragua() {Console.WriteLine("el gato tomo agua");}

public void Mostrardatosdelanimal() {Console.WriteLine("el gato se llama "+this.nombre+ " y tiene "+ this.edad+ " años");

}

}
class Perro : ComportamientoAnimal, Datosdelanimal
{
 public string nombre;
public int edad;


    public Perro (string nombre, int edad){
this.nombre= nombre;
this.edad= edad;


    }

public void Comer (){Console.WriteLine ("el perro se fue a comer");}
public void Dormir (){Console.WriteLine ("el perro se fue a dormir");}
public void Tomaragua (){Console.WriteLine ("el perro se fue a tomar agua");}

public void Mostrardatosdelanimal() {Console.WriteLine("el perro se llama "+this.nombre+ " y tiene "+ this.edad+ " años");

}


}}