using System;
using MetodologíasDeProgramaciónI;

namespace Practica05
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{
		private Teacher teacher;
		
		public Aula()
		{
		}
		
		public void comenzar()
		{
			Console.WriteLine("Comenzando la clase...");
			teacher = new Teacher();
		}
		
		public void nuevoAlumno(Student alumno)
		{
			teacher.goToClass(alumno);
		}
		
		public void claseLista()
		{
			teacher.teachingAClass();
		}
	}
}
