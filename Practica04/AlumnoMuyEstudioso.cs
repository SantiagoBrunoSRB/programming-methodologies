/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 25/05/2026
 * Hora: 2:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica04
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string nom, int doc, int l, double p) : base(nom, doc, l, p)
		{
		}

		public override int responderPregunta(int pregunta)
		{
			return pregunta % 3;
		}
	}
}
