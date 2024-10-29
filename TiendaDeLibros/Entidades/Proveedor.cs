using System.Collections.Generic;

namespace TiendaDeLibros.Entidades
{
	public class Proveedor
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Telefono { get; set; }
		public string Mail { get; set; }
		public List<Libro> LibrosDisponibles { get; set; }

		public Proveedor()
		{
			LibrosDisponibles = new List<Libro>();
		}
	}
}
