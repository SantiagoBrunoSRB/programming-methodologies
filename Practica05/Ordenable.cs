using System;

namespace Practica05
{
	/// <summary>
	/// Description of Ordenable.
	/// </summary>
	public interface Ordenable
	{
		void setOrdenInicio(OrdenEnAula1 orden);
		void setOrdenLlegaAlumno(OrdenEnAula2 orden);
		void setOrdenAulaLlena(OrdenEnAula1 orden);
	}
}
