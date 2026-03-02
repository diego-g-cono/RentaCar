namespace Dominio
{
    public class Modelo : Catalogo
    {
        // Foreign key
        public int Marca_id { get; set; }

        public Modelo(string nombre, int marca_id) : base(nombre)
        {
            Marca_id = marca_id;
        }

        public Modelo() { }
    }
}