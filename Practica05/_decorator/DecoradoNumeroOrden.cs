using System;
using MetodologíasDeProgramaciónI;

namespace Practica05._decorator
{
	public class DecoradoNumeroOrden : DecoradorAlumno
	{
		private static int numero = 0;

		public DecoradoNumeroOrden(Student a) : base(a)
		{
		}

		public override string showResult()
		{
			numero++;
			return numero + ") " + alumno.showResult();
		}
	}
}
