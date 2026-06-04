/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 25/05/2026
 * 
 * Adaptador (Adapter): Alumno -> Student (MDPI)
 */
using System;
using MetodologíasDeProgramaciónI;
using Practica05._proxy;

namespace Practica05._adapter
{
	public interface AlumnoAdaptado
	{
		Alumno getAlumno();
	}

	public class AdaptadorDeAlumno : Student, AlumnoAdaptado
	{
		private Alumno alumno;
		private ProxyDeAlumno proxyAlumno;

		public AdaptadorDeAlumno(Alumno a)
		{
			alumno = a;
		}

		public AdaptadorDeAlumno(ProxyDeAlumno p)
		{
			proxyAlumno = p;
		}

		public string getName()
		{
			if (alumno != null)
				return alumno.getNombre();
			else
				return proxyAlumno.getNombre();
		}

		public int yourAnswerIs(int question)
		{
			if (alumno != null)
				return alumno.responderPregunta(question);
			else
				return proxyAlumno.responderPregunta(question);
		}

		public void setScore(int score)
		{
			if (alumno != null)
				alumno.setCalificacion(score);
			else
				proxyAlumno.setCalificacion(score);
		}

		public string showResult()
		{
			if (alumno != null)
				return alumno.mostrarCalificacion();
			else
				return proxyAlumno.mostrarCalificacion();
		}

		public Alumno getAlumno()
		{
			return alumno;
		}

		public bool equals(Student student)
		{
			AlumnoAdaptado otro = (AlumnoAdaptado)student;
			if (alumno != null)
				return alumno.sosIgual(otro.getAlumno());
			else
				return proxyAlumno.getNombre().Equals(student.getName());
		}

		public bool lessThan(Student student)
		{
			AlumnoAdaptado otro = (AlumnoAdaptado)student;
			if (alumno != null)
				return alumno.sosMenor(otro.getAlumno());
			else
				return proxyAlumno.getNombre().CompareTo(student.getName()) < 0;
		}

		public bool greaterThan(Student student)
		{
			AlumnoAdaptado otro = (AlumnoAdaptado)student;
			if (alumno != null)
				return alumno.sosMayor(otro.getAlumno());
			else
				return proxyAlumno.getNombre().CompareTo(student.getName()) > 0;
		}
	}
}
