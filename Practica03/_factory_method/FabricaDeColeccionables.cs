/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 11/05/2026
 * Hora: 2:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica03._factory_method
{
	/// <summary>
	/// Description of FabricaDeColeccionables.
	/// </summary>
	public class FabricaDeColeccionables
	{
		public FabricaDeColeccionables()
		{
		}
		public static IColeccionable crearColeccion(int opcion){
			switch (opcion) {
					case 1: return new Cola();
					case 2: return new Pila();
					case 3: return new Conjunto();
					case 4: return new ColeccionMultiple(new Pila(),new Cola());
			}
			//entonces no va retornad nada 
			return null;
		}
	}
}