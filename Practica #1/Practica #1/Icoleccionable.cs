/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 25/04/2026
 * Hora: 1:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica__1
{
	/// <summary>
	/// Ejercicio 3 Implemente la siguiente interface que representa objetos que almacenan comparables:
	/// </summary>
	public interface Icoleccionable
	{
		int cuantos();
		Comparable maximo();
		Comparable minimo();
		void agregar (Comparable c);
		bool contiene (Comparable c);
	}
}
