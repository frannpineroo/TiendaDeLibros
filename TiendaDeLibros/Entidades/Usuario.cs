using System.Collections.Generic;

namespace TiendaDeLibros.Entidades
{
	public class Usuario
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Telefono { get; set; }
		public string Direccion { get; set; }
		public string Documento { get; set; }
		public List<Libro> CarritoDeCompra { get; set; }

		public Usuario()
		{
			CarritoDeCompra = new List<Libro>();
		}
	}
}
