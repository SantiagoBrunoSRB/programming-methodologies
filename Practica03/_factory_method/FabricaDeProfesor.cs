/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 15/05/2026
 * Hora: 2:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica03._factory_method
{
	/// <summary>
	/// Description of FabricaDeProfesor.
	/// </summary>
	public class FabricaDeProfesor : FabricaDeComparables
	{
		public FabricaDeProfesor()
		{
		}
		
		//Inicio implemented abstract members of FabricaDeComparables
		public override Comparable crearAleatorio()
		{
			return new Profesor(generador.stringAleatorio(8),generador.numeroAleatorio(100000000),generador.numeroAleatorio(40));
		}
		public override Comparable crearPorTeclado()
		{
			Console.Write("Ingrese nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese documento: ");
			int doc = int.Parse(Console.ReadLine());
			Console.Write("Ingrese antiguedad: ");
			int antiguedad = int.Parse(Console.ReadLine());
			return new Profesor(nombre,doc,antiguedad);
		}
		//Fin
	}
}