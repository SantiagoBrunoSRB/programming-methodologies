/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 07/05/2026
 * Hora: 2:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica__2
{
	/// <summary>
	/// Description of Struct1.
	/// </summary>
	public struct Struct1 : IEquatable<Struct1>
	{
		int member; // this is just an example member, replace it with your own struct members!
		
		#region Equals and GetHashCode implementation
		// The code in this region is useful if you want to use this structure in collections.
		// If you don't need it, you can just remove the region and the ": IEquatable<Struct1>" declaration.
		
		public override bool Equals(object obj)
		{
			if (obj is Struct1)
				return Equals((Struct1)obj); // use Equals method below
			else
				return false;
		}
		
		public bool Equals(Struct1 other)
		{
			// add comparisions for all members here
			return this.member == other.member;
		}
		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			return member.GetHashCode();
		}
		
		public static bool operator ==(Struct1 left, Struct1 right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(Struct1 left, Struct1 right)
		{
			return !left.Equals(right);
		}
		#endregion
	}
}
