using System;

class areaFigura {
    static void Main(string[] args) {
       //Area de una figura
       double radio;
       double hipotenusa;
	   double altura;
       double semiCirculo;
       double triangulo;
       double areaFigura;
       Console.WriteLine("Por favor ingrese en valor del radio en centimetros: ");
        radio = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Por favor ingrese en valor de la hipotenusa en centimetros: ");
        hipotenusa = Convert.ToDouble(Console.ReadLine());

        altura = Math.Sqrt((hipotenusa*hipotenusa)-(radio*radio));

    semiCirculo= (3.1416*(radio*radio))/2;
    triangulo= ((radio*2)*altura)/2;
    areaFigura= semiCirculo+triangulo;
    Console.WriteLine("El area de la figura es de: "+areaFigura+" centimetros");
    }
}