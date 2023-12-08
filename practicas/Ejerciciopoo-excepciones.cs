namespace Principal{

//lanzar una excepcion

class Division {
public void CalculoDivision (){

int a, b, resultado;
a=10;
b=0;

try{ 


resultado= a/b; 

}

catch(Exception e){ //captura el error
Console.WriteLine(e.Message);


}


finally {
 Console.WriteLine("operacion finalizada, no se puede dividir un numero por cero" );   
}

}
}

}



