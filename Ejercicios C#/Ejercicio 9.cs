using System;

class TablasMultiplicar {
    static void Main(string[] args) {
        int numero=1;
        int resultadoTabla;
        int multiplicador=1;
	    for(int i=0; i<10;i++){
            Console.WriteLine("Tabla del "+numero);
	        for(int j=0; j<10;j++){
	            resultadoTabla= numero*multiplicador;
	            Console.WriteLine(numero+" * "+multiplicador+" = "+resultadoTabla);
                multiplicador++;
	        }
	        numero++;
            multiplicador=1;
	    }
	}
}