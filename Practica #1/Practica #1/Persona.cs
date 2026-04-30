/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 30/04/2026
 * Hora: 1:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica__1
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona: Comparable
	{
		//propiedades
		private string nombre;
		private int dni;
		
		
		//Constructor
		public Persona(string n, int d)
		{
			this.nombre= n;
			this.dni= d;
		}
		
		//getters
		public string getNombre(){
			return this.nombre;
		}
		
		public int getDni(){
			return this.dni;
		}
		
		
		//Implementacion Comparable 
		
	/**
		 DNI --> int Por si quisiera comparar por DNI
		
		public bool sosIgual(Comparable c)
		{
			return this.dni == ((Persona)c).getDni();
		}

		public bool sosMenor(Comparable c)
		{
			return this.dni < ((Persona)c).getDni();
		}

		public bool sosMayor(Comparable c)
		{
			return this.dni > ((Persona)c).getDni();
		}
		**/
		
		// Nombre --> String 
		
		public bool sosIgual(Comparable c)
		{
			return this.nombre == ((Persona)c).getNombre();
		}

		public bool sosMenor(Comparable c)
		{
			return this.nombre.CompareTo(((Persona)c).getNombre()) < 0;
		}

		public bool sosMayor(Comparable c)
		{
			return this.nombre.CompareTo(((Persona)c).getNombre()) > 0;
		}
		

		//this.obj.CompareTo(obj) > 0 ; --> true  ejemplo JUAN > Ana (true)
		
		
		
		
	}
}
