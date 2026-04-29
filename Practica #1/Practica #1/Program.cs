/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 25/04/2026
 * Time: 0:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;


namespace Practica__1
{
	/// <summary>
	/// Description of Program.
	/// </summary>
	class Program{
        static void Main(string[] args)
        {
        	
        	
			
        		Pila p= new Pila();
			Numero num1 = new Numero(29);
			Numero num2 = new Numero(22);
			Numero num3 = new Numero(23);
			Numero num4 = new Numero(242);
			p.apilar(num1);
			p.apilar(num2);
			p.apilar(num3);
			p.apilar(num4);
			Console.WriteLine(p.getPila());
			Console.WriteLine(p.desapilar());
			Console.WriteLine(p.maximo());
			Console.WriteLine(p.minimo());
        	Console.WriteLine(p.contiene(new Numero(24)));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		// metodos de la clase 
		public static void llenar(Icoleccionable c){
			Random azar = new Random();
			for (int i = 0; i < 20; i++) {
				int valor = azar.Next(1,100);
				Comparable com = new Numero(valor);
				c.agregar(com);
			}
		}
        	
        	
        	
        	
        	
        	
           
    
}
}
