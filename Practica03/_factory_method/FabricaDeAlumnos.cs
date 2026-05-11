/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 11/05/2026
 * Hora: 1:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica03._factory_method
{
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public FabricaDeAlumnos()
		{
		}
		//inicio implemented abstract members of FabricaDeComparables
		public override Comparable crearAleatorio()
		{
			return new Alumno(generador.stringAleatorio(5),generador.numeroAleatorio(100000000),generador.numeroAleatorio(10000),(double)generador.numeroAleatorio(10));
		}
		public override Comparable crearPorTeclado()
		{
			Console.Write("Ingrese un nombre: ");
			string nombre = lector.stringPorTeclado();
			
			Console.Write("Ingrese un DNI: ");
			int dni = lector.numeroPorTeclado();
			
			Console.Write("Ingrese un legajo: ");
			int legajo = lector.numeroPorTeclado();
			
			Console.Write("Ingrese un promedio: ");
			double promedio = lector.numeroPorTeclado();
			


			return new Alumno(nombre, dni, legajo, promedio);

			
			
			
		}
		//fin
	}
}
