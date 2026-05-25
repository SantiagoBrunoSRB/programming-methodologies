/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 28/3/2026
 * Hora: 19:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using Practica04._iterator;
using Practica04._strategy;
using Practica04._factory_method;
using Practica04._observer;


namespace Practica04
{
	class Program
	{
		//atributo de la clase 
		static Random azar = new Random();

		public static void Main(string[] args)
		{
			//================ MAIN Consola===============================================

			
			
				//ejercicio 7 TP3
			/*IColeccionable coleccion = FabricaDeColeccionables.crearColeccion(4);
			llenar(coleccion,3);
			informar(coleccion,3);
			*/
			
			Profesor profe = new Profesor("Mauro",1234567,7);
			Pila p = new Pila();
			llenar(p,2);
			Iterador ite = p.crearIterador(); // Iterador de pila
			//definimos el primer elemento del iterador 
			ite.primero();
			// se ejecuta mientras el iterador no llego al final de la lista
			while (!ite.fin()) {
				profe.agregarObservador((Observador)ite.actual()); //ite.actual() --> me tira  un Comparable
				ite.siguente();
			}
			dictadoDeClases(profe);
			
			
			Console.WriteLine("Hello estan vivas");
			Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
		}
		
		
		
		
		
		

		// Tp3 Modificamos llenar  ejercicio 6
		public static void llenar(IColeccionable cole,int opcion){
			for (int i = 0; i < 20; i++) {

				Comparable com = FabricaDeComparables.crearAleatorio(opcion);
				//seteamos la estrategia si es un Alumno
				
				cole.agregar(com);
			}
		}
		//Tp3 Modificamos  informar  ejercicio 6
		public static void informar(IColeccionable c,int opcion){
			// Imprime cuantos elementos contiene el coleccionable
			Console.WriteLine("tamaño del Coleccionable: "+c.cuantos());
			//Imprime el minimo del coleccionable
			Console.WriteLine("minimo: "+c.minimo());
			//Imprime el maximo del coleccionable
			Console.WriteLine("maximo: "+c.maximo());
			Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
	
			if(c.contiene(comparable)){
					Console.WriteLine("El elemento  esta registrado en la coleccion.");
			}else
				Console.WriteLine("El elemento no se encuentra en la coleccion!!.");






		}

		
		
		
		//usando el Iterador -- > imprmir todos los elementos del coleccionable
		public static void imprimirElementos(Iterable col){
			Iterador iterador = col.crearIterador();
			iterador.primero();
			//mientras que no llegue a su fin el coleccionable va a seguir ejecutando
			Console.WriteLine("====Inicio======");
			while (!iterador.fin()) {
				Comparable elemento = iterador.actual();
				Console.WriteLine(elemento);
				iterador.siguente();
			}
			Console.WriteLine("====Fin======");
		}


		public static void cambiarEstrategia(Iterable col,IEstrategiaDeComparacion estrategia){
			Iterador iterador = col.crearIterador();
			iterador.primero();
			while (!iterador.fin()) {
				((Alumno)iterador.actual()).setEstrategia(estrategia);
				iterador.siguente();
			}
		}

			public static void dictadoDeClases(Profesor profe){
			for (int i = 0; i <= 5; i++) {
				profe.hablarALaClase();
				profe.escribirEnElPizarron();
			}
		}
		
		
	}

}