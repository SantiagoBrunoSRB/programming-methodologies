/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 25/04/2026
 * Hora: 1:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;


namespace Practica__1
{

	public class Pila : Icoleccionable
	{
		
		private List<Comparable> elementos;
	
	//Constructor de la Pila
		public Pila()
		{
			elementos = new List<Comparable>();
		}
		
		//Metodos
		
		
		//push  : Ingresa un elemento en la parte superior de la Pila
		public void apilar(Comparable e){
			elementos.Add(e);
		}

		public Comparable desapilar(){
			int i = (elementos.Count)-1;
			if (i >= 0){
				Comparable e = elementos[i];
				elementos.RemoveAt(i);
				return e;
			}else
				throw new InvalidOperationException("No hay elementos en la Pila");
		}
		public List<Comparable> getPila(){
			return this.elementos;
		}
		
	
		
		
		/// Implementacion de IColeccionable
		public int cuantos()
		{
			return this.elementos.Count;
		}
		public Comparable maximo()
		{
			if(elementos.Count > 0){
				Comparable e = elementos[0] ;
				foreach (Comparable c in this.elementos) {
					if(e.sosMayor(c)==false){
						e = c;
					}
				}
				return e;
			}else
				throw new Exception("La coleccion esta vacia no se puede encontrar el Maximo");
			
		}
		public Comparable minimo()
		{
			if(elementos.Count > 0){
				Comparable e = elementos[0];
				foreach (Comparable c in this.elementos) {
					if (!e.sosMenor(c)) {
						e = c;
					}
				}
				return e;
			}else
				throw new Exception("La Coleccion esta vacia no se puede encontrar el minimo");
			
		}
		public void agregar(Comparable c)
		{
			elementos.Add(c);
		}
		public bool contiene(Comparable c)
		{
			foreach (Comparable e in this.elementos) {
				if (c.sosIgual(e)) {
					return true;
				}
			}
			return false;
		}
	
		
		
		public override string ToString(){
			return elementos.ToString();
		}
		
		
		
		
		
		
		
		
		
		
		
	}
}
