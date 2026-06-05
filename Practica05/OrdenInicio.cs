using System;

namespace Practica05
{
	/// <summary>
	/// Orden que envía el mensaje comenzar al aula.
	/// </summary>
	public class OrdenInicio : OrdenEnAula1
	{
		private Aula aula;
		
		public OrdenInicio(Aula aula)
		{
			this.aula = aula;
		}
		
		public void ejecutar()
		{
			aula.comenzar();
		}
	}
}
