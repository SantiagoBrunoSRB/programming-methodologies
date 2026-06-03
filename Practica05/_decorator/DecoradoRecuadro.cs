using System;
using MetodologíasDeProgramaciónI;

namespace Practica05._decorator
{
	public class DecoradoRecuadro : DecoradorAlumno
	{
		public DecoradoRecuadro(Student a) : base(a)
		{
		}

		public override string showResult()
		{
			return "****************************************************\n*\n" + alumno.showResult() + "  *\n****************************************************";
		}
	}
}
