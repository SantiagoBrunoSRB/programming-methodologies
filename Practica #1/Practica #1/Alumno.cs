/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 30/04/2026
 * Hora: 2:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica__1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
	{
		//Propiedades
		private int legajo;
		private double promedio;
		
		//Constructor
		public Alumno(string nom, int doc, int l, double p) 
			:base(nom,doc)
		{
			legajo= l;
			promedio= p;
			
		}
		//getters
		public int getLegajo(){
			return this.legajo;
		}
		
		public double getPromedio(){
			return this.promedio;
		}
		
	}
}
