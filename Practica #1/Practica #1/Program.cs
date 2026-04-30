/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 25/04/2026
 * Time: 0:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;



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

	}
}
