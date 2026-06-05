using System;
using MetodologíasDeProgramaciónI;
using Practica05._adapter;
using Practica05._proxy;

namespace Practica05
{
	/// <summary>
	/// Orden que envía el mensaje nuevoAlumno al aula.
	/// </summary>
	public class OrdenLlegaAlumno : OrdenEnAula2
	{
		private Aula aula;
		
		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula = aula;
		}
		
		public void ejecutar(Comparable c)
		{
			Student alumnoAdaptado = null;
			
			if (c is Alumno)
			{
				alumnoAdaptado = new AdaptadorDeAlumno((Alumno)c);
			}
			else if (c is ProxyDeAlumno)
			{
				alumnoAdaptado = new AdaptadorDeAlumno((ProxyDeAlumno)c);
			}
			
			if (alumnoAdaptado != null)
			{
				aula.nuevoAlumno(alumnoAdaptado);
			}
		}
	}
}
