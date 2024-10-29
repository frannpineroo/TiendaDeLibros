using System.Collections.Generic;
using TiendaDeLibros.Entidades;

namespace TiendaDeLibros.Servicios
{
	public class ServicioDeLibros
	{
		private List<Libro> libros;

		public ServicioDeLibros()
		{
			libros = new List<Libro>();
		}

		public void AgregarLibro(Libro libro) 
		{
			libros.Add(libro);
		}

		public List<Libro> ObtenerLibros()
		{
			return libros;
		}
	}
}
