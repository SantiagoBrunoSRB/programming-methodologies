using System;
using MetodologíasDeProgramaciónI;

namespace Practica04._decorator
{
	public class DecoradoLegajo : DecoradorAlumno
	{
		public DecoradoLegajo(Student a) : base(a)
		{
		}

		public override string showResult()
		{
			return getAlumno().getNombre() + " (" + getAlumno().getLegajo() + ")\n" + alumno.showResult().Replace(getAlumno().getNombre() + " ", "");
		}
	}
}
