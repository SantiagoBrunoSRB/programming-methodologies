using System;
using MetodologíasDeProgramaciónI;

namespace Practica04._decorator
{
	public class DecoradoNotaEnLetras : DecoradorAlumno
	{
		public DecoradoNotaEnLetras(Student a) : base(a)
		{
		}

		public override string showResult()
		{
			return alumno.showResult() + " (" + notaEnLetras(getAlumno().getCalificacion()) + ")";
		}

		private string notaEnLetras(int nota)
		{
			switch (nota) {
				case 0:
					return "CERO";
				case 1:
					return "UNO";
				case 2:
					return "DOS";
				case 3:
					return "TRES";
				case 4:
					return "CUATRO";
				case 5:
					return "CINCO";
				case 6:
					return "SEIS";
				case 7:
					return "SIETE";
				case 8:
					return "OCHO";
				case 9:
					return "NUEVE";
				case 10:
					return "DIEZ";
			}
			return nota.ToString();
		}
	}
}
