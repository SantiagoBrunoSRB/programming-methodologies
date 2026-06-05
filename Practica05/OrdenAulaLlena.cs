using System;

namespace Practica05
{
	/// <summary>
	/// Orden que envía el mensaje claseLista al aula.
	/// </summary>
	public class OrdenAulaLlena : OrdenEnAula1
	{
		private Aula aula;
		
		public OrdenAulaLlena(Aula aula)
		{
			this.aula = aula;
		}
		
		public void ejecutar()
		{
			aula.claseLista();
		}
	}
}
