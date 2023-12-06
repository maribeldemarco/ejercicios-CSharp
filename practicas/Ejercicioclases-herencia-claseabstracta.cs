namespace Principal{


 abstract class Transporte {

public double valorpasaje;
public string origen;
public string destino;

public int minutosdeviaje;

public Transporte (double valorpasaje, string origen, string destino, int minutosdeviaje)
{
this.valorpasaje= valorpasaje;
this.origen=origen;
this.destino=destino;
this.minutosdeviaje=minutosdeviaje;


}

 public abstract void Datosviaje (); 

}

class Colectivo : Transporte
{ string patente;
  int linea;

public Colectivo (string patente, int linea, double valorpasaje, string origen, string destino, int minutosdeviaje): base(valorpasaje,origen,destino,minutosdeviaje)

{
this.patente=patente;
this.linea=linea;

}
        public override void Datosviaje()
        {Console.WriteLine("Usted ha viajado en colectivo. El valor del pasaje en pesos es "+ this.valorpasaje+ ".  El origen es "+ this.origen + " el destino es " +this.destino+ ". \n El viaje en minutos demora: "+this.minutosdeviaje+" minutos, la linea es "+this.linea +" , \n  la patente es "+this.patente);
         }

    }

class Tren: Transporte{
 

string estacion;
string horario;

public Tren (string estacion, string horario, double valorpasaje, string origen, string destino, int minutosdeviaje): base (valorpasaje,origen,destino,minutosdeviaje)
{
this.estacion=estacion;
this.horario=horario;

}

        public override void Datosviaje()
        { Console.WriteLine("Usted ha viajado en Tren. El valor del pasaje en pesos es "+ this.valorpasaje+ " \n  El origen es "+ this.origen + " el destino es " +this.destino+ ". \n El viaje en minutos demora: "+this.minutosdeviaje+ " \n  La estacion de salida es "+ this.estacion + " el horario es " +this.horario + " hs.");
        }

    }


}

