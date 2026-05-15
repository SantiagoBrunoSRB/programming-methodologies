/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 15/05/2026
 * Hora: 2:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica03._strategy
{
	/// <summary>
	/// Description of EstrategiaPorAntiguedad.
	/// </summary>
	public class EstrategiaPorAntiguedad : IEstrategiaDeComparacion
	{
		public EstrategiaPorAntiguedad()
		{
		}
		//Inicio IEstrategiaDeComparacion implementation
		public bool sosIgual(Comparable a, Comparable b)
		{
			return ((Profesor)a).getAntiguedad() == ((Profesor)b).getAntiguedad();
		}
		public bool sosMenor(Comparable a, Comparable b)
		{
			return ((Profesor)a).getAntiguedad() < ((Profesor)b).getAntiguedad();
		}
		public bool sosMayor(Comparable a, Comparable b)
		{
			return ((Profesor)a).getAntiguedad() > ((Profesor)b).getAntiguedad();
		}
		//Fin
	}
}
