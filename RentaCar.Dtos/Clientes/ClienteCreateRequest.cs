using RentaCar.Dtos.Common;

namespace RentaCar.Dtos.Clientes
{
    public class ClienteCreateRequest : PersonaDto
    {
        public required string Email { get; set; }
        public required string Telefono { get; set; }
    }
}