namespace TiendaDeLibros.Entidades
{
	public class Libro
	{
		public int Codigo { get; set; }
		public string Categoria { get; set; }
		public string Nombre { get; set; }
		public string Autor { get; set; }
		public string Editorial { get; set; }
		public int Cantidad { get; set; }
		public decimal Precio { get; set; }
	}
}
