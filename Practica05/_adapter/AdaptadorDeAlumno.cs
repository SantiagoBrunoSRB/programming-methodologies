/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 25/05/2026
 * 
 * Adaptador (Adapter): Alumno -> Student (MDPI)
 */
using System;
using MetodologíasDeProgramaciónI;

namespace Practica05._adapter
{
	public interface AlumnoAdaptado
	{
		Alumno getAlumno();
	}

	public class AdaptadorDeAlumno : Student, AlumnoAdaptado
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

		public Alumno getAlumno()
		{
			return alumno;
		}

		public bool equals(Student student)
		{
			AlumnoAdaptado otro = (AlumnoAdaptado)student;
			return alumno.sosIgual(otro.getAlumno());
		}

		public bool lessThan(Student student)
		{
			AlumnoAdaptado otro = (AlumnoAdaptado)student;
			return alumno.sosMenor(otro.getAlumno());
		}

		public bool greaterThan(Student student)
		{
			AlumnoAdaptado otro = (AlumnoAdaptado)student;
			return alumno.sosMayor(otro.getAlumno());
		}
	}
}
