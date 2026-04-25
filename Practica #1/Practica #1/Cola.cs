/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 25/04/2026
 * Hora: 1:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;


namespace Practica__1
{

	
	//Propiedades
	public class Cola: Icoleccionable
	{
		private List<Comparable> elementos;
		public Cola()
		{
			elementos = new List<Comparable>();
		}
		// metodos de Cola
		public void encolar(Comparable c){
			elementos.Add(c);
		}
		public Comparable desencolar(){
			if(elementos.Count > 0){
				Comparable e = elementos[0];
				elementos.RemoveAt(0);
				return e;
			}else
				throw new Exception("La Cola esta Vacia");
		}
		

		// Implementacion IColeccionable 

		public int cuantos()
		{
			return this.elementos.Count;
		}

		public Comparable maximo()
		{
			if(elementos.Count > 0){
				Comparable e = this.elementos[0];
				foreach (Comparable c in this.elementos) {
					if(e.sosMayor(c) == false){
						e = c;
					}
				}
				return e;
			}else
				throw new Exception("La Cola esta vacia no se puede encontrar Maximo");
		}

		public Comparable minimo()
		{
			if(elementos.Count > 0){
				Comparable e = this.elementos[0];
				foreach (Comparable c in this.elementos) {
					if (e.sosMenor(c) == false) {
						e=c;
					}
				}
				return e;
			}else
				throw new Exception("La Cola esta vacia no se puede encontrar Minimo");
		}

		public void agregar(Comparable c)
		{
			this.elementos.Add(c);
		}

		public bool contiene(Comparable c)
		{
			foreach (Comparable e in this.elementos) {
				if(c.sosIgual(e)){
					return true;
				}
			}
			return false;
		}

	
		
		
		
		
		
	}
}
