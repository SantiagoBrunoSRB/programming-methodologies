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
using Practica05._iterator;
using Practica05._strategy;
using Practica05._factory_method;
using Practica05._observer;
using Practica05._adapter;
using Practica05._decorator;
using MetodologíasDeProgramaciónI;


namespace Practica05
{
	class Program
	{
		//atributo de la clase 
		static Random azar = new Random();

		public static void Main(string[] args)
		{
			//================ MAIN Consola===============================================

			//Ejercicio 8 : Ejecucion y comprobacion de que todo funciona correctamente
			Teacher teacher = new Teacher();
			
			for (int i = 0; i < 10; i++) {
				Alumno alumno = new Alumno("Alumno " + (i + 1), 1000 + i, i + 1, 7);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(decorarAlumno(new AdaptadorDeAlumno(alumno)));
			}
			
			for (int i = 0; i < 10; i++) {
				AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso("Alumno muy estudioso " + (i + 1), 2000 + i, i + 11, 10);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(decorarAlumno(new AdaptadorDeAlumno(alumno)));
			}
			
			teacher.teachingAClass();
			
			Console.WriteLine("Todo Funciona Correctamente");
			Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
		}

		public static Student decorarAlumno(Student alumno){
			Student alumnoDecorado = alumno;
			alumnoDecorado = new DecoradoNotaEnLetras(alumnoDecorado);
			alumnoDecorado = new DecoradoCondicion(alumnoDecorado);
			alumnoDecorado = new DecoradoLegajo(alumnoDecorado);
			alumnoDecorado = new DecoradoNumeroOrden(alumnoDecorado);
			alumnoDecorado = new DecoradoRecuadro(alumnoDecorado);
			return alumnoDecorado;
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