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
			return new Alumno(lector.stringPorTeclado(),lector.numeroPorTeclado(),lector.numeroPorTeclado(),(double)lector.numeroPorTeclado());
		}
		//fin
	}
}
