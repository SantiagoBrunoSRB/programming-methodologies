/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 25/04/2026
 * Time: 0:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;



namespace Practica__1
{
	/// <summary>
	/// Description of Program.
	/// </summary>
	class Program
	{
        public static void Main(string[] args)
        {
        	
 /**
  * Ejercicio 7
  
        	Pila pila = new Pila();
			Cola cola = new Cola();
			llenar(pila);
			llenar(cola);
			informar(pila);
			informar(cola);
			Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
		
**/
      //ejercicio 9

			Pila p = new Pila();
			Cola c = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			llenar(p);
			llenar(c);
			informar(p);
			informar(c);
			informar(multiple);

			Console.WriteLine("Las interfaces estan vivas!!");
        	Console.ReadKey(true);
        	

		}
		//atributo de la clase 
		static Random azar = new Random();
        	
        	
        	
        

		// metodos de la clase
		public static void llenar(Icoleccionable c)
		{
			Random azar = new Random();
			for (int i = 0; i < 20; i++)
			{
				int valor = azar.Next(1, 100);
				Comparable com = new Numero(valor);
				c.agregar(com);
			}
		}

		public static void informar(Icoleccionable c)
		{
			//cuantos
			Console.WriteLine("tamaño del Coleccionable: " + c.cuantos());
			//minimo
			Console.WriteLine("minimo: " + c.minimo());
			//maximo
			Console.WriteLine("maximo: " + c.maximo());
			//contiene
			Console.WriteLine("Ingrese un valor para buscar en la Coleccion: ");
			int read = int.Parse(Console.ReadLine());
			Comparable com = new Numero(read);
			if (c.contiene(com))
			{
				Console.WriteLine("el elemento se encuentra en la lista");
			}
			else
			{
				Console.WriteLine("el elemento no se encuentra en la lista");
			}
		}
		
		
		//Ejercicio 13
		
		public static void llenarAlumnos(Icoleccionable c){
			List<string> alumnos =new List<string>(){
    	"Ximena", "Iara", "Mica", "Lucia", "Maria","Mia", "Angela", "Sasha","Abella", "Adriana", "Riley", "Mia", "Brandi","Lana", "Eva", "Emily", "Elsa", "Alexis","Kendra", "Nicole", "Asa", "Anissa", "Lisa","Gianna", "Carter", "Dani", "Remy", "Tori","Jenna", "Ava", "August", "Valentina", "Cleo","Skylar", "Alina", "Gina", "Lena", "Kagney","Abigail", "Cherie", "Monica", "Rae", "Violet",
		"Jordi", "Nacho", "Rocco", "Manuel", "Johnny","James", "Mick", "Erik", "Prince", "Lex"};
			
			for (int i = 0; i < 20; i++) {
				//azar
				int legajo = azar.Next(10000,100000);
				int documento = azar.Next(10000000,100000000);
				int valor = azar.Next(10,101);
				int indice = azar.Next(0,50);
				string alumno = alumnos[indice];
				double promedio = valor/10.0;
				c.agregar(new Alumno(alumno,documento,legajo,promedio));
			}
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		

	}
}









/** EJERCICIO 10: Para reflexionar. Además de la creación de la nueva clase ColeccionMultiple y la adaptación del módulo main, responda ¿qué tuvo que modificar de lo realizado en los primeros seis ejercicios?
 * Se modificaron las colecciones (como Pila y Cola) para que implementen la interfaz Icoleccionable, de modo que todas compartan el mismo contrato (cuantos, minimo, maximo, agregar, contiene).
Además, se unificaron los métodos genéricos como llenar e informar para que trabajen con Icoleccionable en lugar de tipos específicos.
También se tuvo que adaptar el diseño al polimorfismo, asegurando que todas las colecciones (incluida ColeccionMultiple) puedan tratarse de la misma forma.


Idea clave en una frase:
Se pasó de implementaciones separadas a un enfoque basado en interfaces y polimorfismo, donde todas las colecciones cumplen el mismo contrato (Icoleccionable).
 **/