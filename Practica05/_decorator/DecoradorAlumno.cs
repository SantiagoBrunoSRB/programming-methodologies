using System;
using MetodologíasDeProgramaciónI;
using Practica05._adapter;

namespace Practica05._decorator
{
	public abstract class DecoradorAlumno : Student, AlumnoAdaptado
	{
		protected Student alumno;

		public DecoradorAlumno(Student a)
		{
			alumno = a;
		}

		public virtual string getName()
		{
			return alumno.getName();
		}

		public virtual int yourAnswerIs(int question)
		{
			return alumno.yourAnswerIs(question);
		}

		public virtual void setScore(int score)
		{
			alumno.setScore(score);
		}

		public virtual string showResult()
		{
			return alumno.showResult();
		}

		public virtual bool equals(Student student)
		{
			return alumno.equals(student);
		}

		public virtual bool lessThan(Student student)
		{
			return alumno.lessThan(student);
		}

		public virtual bool greaterThan(Student student)
		{
			return alumno.greaterThan(student);
		}

		public Alumno getAlumno()
		{
			return ((AlumnoAdaptado)alumno).getAlumno();
		}
	}
}
