namespace RentaCar.Dominio
{
    public class Modelo : Catalogo
    {
        // Foreign key
        public int MarcaId { get; set; }

        public Modelo(string nombre, int marcaId) : base(nombre)
        {
            MarcaId = marcaId;
        }

        public Modelo() { }
    }
}