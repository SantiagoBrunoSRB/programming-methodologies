using System;
using MetodologíasDeProgramaciónI;

namespace Practica05._decorator
{
	public class DecoradoLegajo : DecoradorAlumno
	{
		public DecoradoLegajo(Student a) : base(a)
		{
		}

		public override string showResult()
		{
			if (getAlumno() != null)
				return getAlumno().getNombre() + " (" + getAlumno().getLegajo() + ")\n" + alumno.showResult().Replace(getAlumno().getNombre() + " ", "");
			else
				return alumno.showResult();
		}
	}
}
