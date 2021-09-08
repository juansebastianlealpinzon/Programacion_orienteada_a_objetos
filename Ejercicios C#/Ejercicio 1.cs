using System;

	public class Auto {
		static void Main(string[] args) {
		//Atributos
			float altura;
			float ancho;
			int numeroVentanas;
			int numeroPuertas;
			int numeroLlantas;
			string placa;
			string color;
			string marca;
			string modelo;
			float masaToneladas;
			int numeroAsientos;
			float velocidad;
		}
		public Auto(string color, string marca, float velocidad, string modelo){
			this.color = color;
			this.marca = marca;
			this.velocidad = velocidad;
			this.modelo = modelo;
		}
			//Metodos
		public void acelerar()
		{
			Console.WriteLine("Estoy acelerando");
		}
		public void frenar()
		{
			Console.WriteLine("Estoy frenando");
		}
		public void girar(int grados)
		{
			if(grados>0){
				Console.WriteLine("Giro "+grados+" derecha");
			}else{
				Console.WriteLine("Giro "+grados+" izquierda");
			}
		}
	
	}