using System;
using MetodologíasDeProgramaciónI;

namespace Practica05._decorator
{
	public class DecoradoCondicion : DecoradorAlumno
	{
		public DecoradoCondicion(Student a) : base(a)
		{
		}

		public override string showResult()
		{
			if (getAlumno() != null)
				return alumno.showResult() + " (" + condicion(getAlumno().getCalificacion()) + ")";
			else
				return alumno.showResult();
		}

		private string condicion(int nota)
		{
			if (nota >= 7) {
				return "PROMOCION";
			}
			if (nota >= 4) {
				return "APROBADO";
			}
			return "DESAPROBADO";
		}
	}
}
