using System;

namespace Practica04._strategy
{
	/// <summary>
	/// Description of EstrategiaPorCalificacion.
	/// </summary>
	public class EstrategiaPorCalificacion : IEstrategiaDeComparacion
	{
		public EstrategiaPorCalificacion()
		{
		}

		public bool sosIgual(Comparable a, Comparable b)
		{
			return ((Alumno)a).getCalificacion() == ((Alumno)b).getCalificacion();
		}

		public bool sosMenor(Comparable a, Comparable b)
		{
			return ((Alumno)a).getCalificacion() < ((Alumno)b).getCalificacion();
		}

		public bool sosMayor(Comparable a, Comparable b)
		{
			return ((Alumno)a).getCalificacion() > ((Alumno)b).getCalificacion();
		}
	}
}
