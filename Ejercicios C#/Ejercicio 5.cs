using System;

class diagramaACodigo {
    static void Main(string[] args) {
        string dia;
		Console.WriteLine("Ingrese el día de la semana de lunes a viernes");
		Console.WriteLine("Seleccione un numero de acuerdo al dia");
        Console.WriteLine("1)Lunes");
		Console.WriteLine("2)Martes");
		Console.WriteLine("3)Miercoles");
		Console.WriteLine("4)Jueves");
		Console.WriteLine("5)Viernes");
		dia=Console.ReadLine();

	switch(dia) 
	{
	    case "1":
	         Console.WriteLine("FRUTA");
	         break;
	    case "2":
	         Console.WriteLine("CALENTADO");
	         break;
	    case "3":
	         Console.WriteLine("AVENA");
	         break;
		case "4":
	         Console.WriteLine("CALDO");
	         break;
		case "5":
	         Console.WriteLine("HUEVOS");
	         break;
	  	default:
	          Console.WriteLine("ERR");
	          break;
	}
    	
    }
}