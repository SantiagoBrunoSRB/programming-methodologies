/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 18/04/2026
 * Time: 2:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Practica__1
{
	/// <summary>
	/// Ej1: Implemente la siguiente interface que representa cualquier objeto que sabe compararse con otro objeto de su “mismo tipo”:
	/// </summary>
	public interface Comparable
	{
		//es bool porque necesitamos que devuelva True o False, "Comparable" es el tipo de dato del parametro "c" nombre de la variable
		bool sosMayor(Comparable c);
			
		bool sosMenor(Comparable c);
		
		bool sosIgual(Comparable c);
	}
}