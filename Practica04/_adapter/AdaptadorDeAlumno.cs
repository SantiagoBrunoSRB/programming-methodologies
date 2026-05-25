/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 25/05/2026
 * 
 * Adaptador (Adapter): Alumno -> Student (MDPI)
 */
using System;
using MetodologíasDeProgramaciónI;

namespace Practica04._adapter
{
	public class AdaptadorDeAlumno : Student
	{
		private Alumno alumno;

		public AdaptadorDeAlumno(Alumno a)
		{
			alumno = a;
		}

		public string getName()
		{
			return alumno.getNombre();
		}

		public int yourAnswerIs(int question)
		{
			return alumno.responderPregunta(question);
		}

		public void setScore(int score)
		{
			alumno.setCalificacion(score);
		}

		public string showResult()
		{
			return alumno.mostrarCalificacion();
		}

		public bool equals(Student student)
		{
			AdaptadorDeAlumno otro = (AdaptadorDeAlumno)student;
			return alumno.getCalificacion() == otro.alumno.getCalificacion();
		}

		public bool lessThan(Student student)
		{
			AdaptadorDeAlumno otro = (AdaptadorDeAlumno)student;
			return alumno.getCalificacion() < otro.alumno.getCalificacion();
		}

		public bool greaterThan(Student student)
		{
			AdaptadorDeAlumno otro = (AdaptadorDeAlumno)student;
			return alumno.getCalificacion() > otro.alumno.getCalificacion();
		}
	}
}
