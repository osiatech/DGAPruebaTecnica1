

namespace Domain.DGA.Entities
{
    public class Venta
    {
        public int Id { get; set; }
        public DateOnly Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> ProductosList { get; set; }
        public double Total { get; set; }
    }
}
