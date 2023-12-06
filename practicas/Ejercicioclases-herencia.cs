using System.ComponentModel;

namespace Principal{

class Bebidas {

protected double precio;
protected int stock;

public Bebidas(double precio, int stock)
{
    this.precio=precio;
    this.stock=stock;

}

public virtual void Datosbebida()
{Console.WriteLine ("Has elegido una bebida generica. Su precio es "+ this.precio + ".Su stock es " +this.stock);}

}

class Gaseosa: Bebidas
{
 string marca;
 string tipobebida;

 public Gaseosa(string marca, string tipobebida, double precio, int stock): base (precio, stock)
{
this.marca=marca;
this.tipobebida=tipobebida;

}
public override void Datosbebida(){
Console.WriteLine ("Has elegido una " +this.tipobebida+ " Su precio es "+ this.precio + ".Su stock es " +this.stock
+ " .Su marca es "+ this.marca);}

}


class Agua: Bebidas{

string marca;
string gasificada;

public Agua (string marca, string gasificada, double precio, int stock): base (precio,stock)
{
    this.marca=marca;
    this.gasificada=gasificada;

}

public override void Datosbebida(){
Console.WriteLine ("Has elegido una agua " +this.gasificada+ " Su precio es "+ this.precio + ".Su stock es " +this.stock
+ ". Su marca es "+ this.marca);}

}




}




