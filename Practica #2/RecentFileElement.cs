/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 07/05/2026
 * Hora: 2:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;   
using System.Configuration;

namespace Practica__2
{
	/// <summary>
	/// An xml representation of a recent element.
	/// </summary>
	public sealed class RecentFileElement : ConfigurationElement
	{
		/// <summary>
		/// The full path of the recently opened file.
		/// </summary>
		[ConfigurationProperty("fileName", IsKey = true, IsRequired = true)]
		public string Name
		{
			get { return (string)this["fileName"]; }
			set { this["fileName"] = value; }
		}
		
		internal RecentFileElement() : base()
		{}
		
		internal RecentFileElement(string FileName)  : base()
		{
			this.Name = FileName;
		}
	}
	
}

