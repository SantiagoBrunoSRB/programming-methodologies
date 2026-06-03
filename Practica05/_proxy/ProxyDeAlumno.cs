using System;
using System.Collections.Generic;
using Practica05._strategy;
using Practica05._observer;

namespace Practica05._proxy
{
	/// <summary>
	/// Proxy para Alumno que implementa el patrón Proxy.
	/// Almacena los datos del alumno y crea la instancia real solo cuando es necesario
	/// (al momento de responder una pregunta).
	/// </summary>
	public class ProxyDeAlumno : Persona, Observador
	{
		private Alumno alumnoReal;
		private int legajo;
		private double promedio;
		private int calificacion;
		private List<string> frases;
		private IEstrategiaDeComparacion estrategia;
		private bool esAlumnoMuyEstudioso;
		private Random azar;

		public ProxyDeAlumno(string nombre, int dni, int legajo, double promedio, bool esAlumnoMuyEstudioso) 
			: base(nombre, dni)
		{
			this.legajo = legajo;
			this.promedio = promedio;
			this.esAlumnoMuyEstudioso = esAlumnoMuyEstudioso;
			this.calificacion = 0;
			this.estrategia = new EstrategiaPorDni();
			this.frases = new List<string>(){"Mirando el celular","Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
			this.azar = new Random();
			this.alumnoReal = null;
		}

		private void CrearAlumnoReal()
		{
			if (alumnoReal == null)
			{
				if (esAlumnoMuyEstudioso)
				{
					alumnoReal = new AlumnoMuyEstudioso(getNombre(), getDni(), legajo, promedio);
				}
				else
				{
					alumnoReal = new Alumno(getNombre(), getDni(), legajo, promedio);
				}
				alumnoReal.setCalificacion(calificacion);
				alumnoReal.setEstrategia(estrategia);
			}
		}

		public int getLegajo()
		{
			return this.legajo;
		}

		public double getPromedio()
		{
			return this.promedio;
		}

		public int getCalificacion()
		{
			return this.calificacion;
		}

		public void setCalificacion(int c)
		{
			this.calificacion = c;
			if (alumnoReal != null)
			{
				alumnoReal.setCalificacion(c);
			}
		}

		public virtual int responderPregunta(int pregunta)
		{
			CrearAlumnoReal();
			return alumnoReal.responderPregunta(pregunta);
		}

		public string mostrarCalificacion()
		{
			return getNombre() + " " + calificacion;
		}

		public void setEstrategia(IEstrategiaDeComparacion e)
		{
			this.estrategia = e;
			if (alumnoReal != null)
			{
				alumnoReal.setEstrategia(e);
			}
		}

		public override bool sosIgual(Comparable c)
		{
			return this.estrategia.sosIgual(this, (Alumno)c);
		}

		public override bool sosMenor(Comparable c)
		{
			return this.estrategia.sosMenor(this, (Alumno)c);
		}

		public override bool sosMayor(Comparable c)
		{
			return this.estrategia.sosMayor(this, (Alumno)c);
		}

		public IEstrategiaDeComparacion getEstrategia()
		{
			return this.estrategia;
		}

		public override string ToString()
		{
			return "\nEstrategia de Comparacion: " + getEstrategia() +"\nNombre: " + getNombre() + " \nDNI: " + getDni() + " \nLegajo: " + getLegajo() + " \nPromedio: " + getPromedio();
		}

		public void prestarAtencion()
		{
			Console.WriteLine("Prestando atencion: ");
		}

		public void distraerse()
		{
			int indiceAleatorio = azar.Next(this.frases.Count);
			Console.WriteLine(this.frases[indiceAleatorio]);
		}

		public void actualizar(Observado o)
		{
			if (((Profesor)o).estaHablando())
			{
				this.prestarAtencion();
			}
			else
			{
				this.distraerse();
			}
		}
	}
}
