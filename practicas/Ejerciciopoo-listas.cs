// las listas tienen un tama;o dinamico a diferencia de los arrays
// se pueden agregar elementros sin preocuparse por el tama;o de la lista
//los arrays se determina su tama;o cuando se crean
using System.Collections.Generic;
//le tenemos que decir que tipos de datos son, string numeros, etc
namespace Principal{

class MiLista{
List<string> palabras;
public MiLista(){
palabras= new List<string>();
}

public void AgregaraLista(string palabra){
palabras.Add(palabra);

}

public void eliminarEnLista(string palabra){
palabras.Remove(palabra);

}

public void mostrarLista(){
Console.WriteLine(" los datos de la lista son ");
    for (int i=0; i<palabras.Count; i++){
Console.WriteLine(palabras[i]+ "\n");
    }
}

public void OrdenoAlfabeticamente(){
    palabras.Sort();
}


public void borroElementoNumero(int numero)
{
    palabras.RemoveAt(numero);
}
}
}