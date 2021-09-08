using System;

class nombreReplace {
    static void Main(string[] args) {
        string nombre;
        string nombreRemplazo;
        Console.WriteLine("Por favor ingrese su nombre");
        nombre=Console.ReadLine();
            nombreRemplazo=nombre.Replace("a","4").Replace("e","3").Replace("i","1").Replace("o","0").Replace("u",")");
        Console.WriteLine("El nombre remplazado es: "+nombreRemplazo);
    }
}