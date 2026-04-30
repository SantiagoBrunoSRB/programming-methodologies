/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 29/04/2026
 * Hora: 23:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica__1
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple
	{
		//Propiedades
		public Pila pila;
		public Cola cola;
		
		
		
		//Constructo
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila= p;
			this.cola= c;
			
		}
		
		//Implementacion Icoleccionable
		
		public int cuantos()
		{
			return pila.cuantos()+cola.cuantos();
		}
		public Comparable minimo()
		{
			Comparable p = pila.minimo();
			Comparable c = cola.minimo();
			if(p.sosMenor(c)){
				return p;
			}else
				return c;
		}
		public Comparable maximo()
		{
			Comparable p = pila.maximo();
			Comparable c = cola.maximo();
			if(p.sosMayor(c)){
				return p;
			}else
				return c;
		}
		public void agregar(Comparable c)
		{
			throw new NotImplementedException("Este metodo no hace nada Ejercicio 8 practica 1");
		}
		public bool contiene(Comparable c)
		{
			return pila.contiene(c)||cola.contiene(c); // true si el alguna se cumple , false en caso de
			// no estar en ninguna y true si esta en ambas
		}
		
		//Fin de la Implementacion
		
		
	}
}
