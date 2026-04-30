/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 18/04/2026
 * Time: 3:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica__1
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero: Comparable
	{
		//Propiedad
		private int valor;
		
		//Constructor
		public Numero(int valor){
		 this.valor = valor;
		 }
		
		//Getter
		public int getValor(){
			return this.valor ;
		}
						
		//Metodos de la interface Comparable
		public bool sosMayor(Comparable c){
			return this.valor > ((Numero)c).getValor();
		}
		public bool sosMenor(Comparable c){
			return this.valor < ((Numero)c).getValor();
		}
		public bool sosIgual(Comparable c){
			return this.valor == ((Numero)c).getValor();
		}

		public override string ToString()
		{
			return this.valor.ToString();
		}
	}
}
