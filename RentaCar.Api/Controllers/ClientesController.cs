using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Repositorios;
using RentaCar.Dtos.Clientes;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly ClienteRepositorio _repo;

    public ClientesController(ClienteRepositorio repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public ActionResult<List<ClienteResponse>> Get()
    {
        var clientes = _repo.ObtenerTodos();

        var response = clientes.Select(c => new ClienteResponse
        {
            Dni = c.Dni,
            Nombre = c.Nombre,
            Apellido = c.Apellido,
            Email = c.Email,
            Telefono = c.Telefono,
        }).ToList();

        return Ok(response);
    }

    [HttpGet("{dni}")]
    public ActionResult<ClienteResponse> Get(int dni)
    {
        var cliente = _repo.ObtenerPorDni(dni);

        if (cliente == null)
            return NotFound();

        var response = new ClienteResponse
        {
            Dni = cliente.Dni,
            Nombre = cliente.Nombre,
            Apellido = cliente.Apellido,
            Email = cliente.Email,
            Telefono = cliente.Telefono,
        };

        return Ok(response);
    }


    [HttpPost]
    public IActionResult Post([FromBody] ClienteCreateRequest request)
    {
        if (request == null)
            return BadRequest();

        var cliente = new Cliente
        {
            Dni = request.Dni,
            Nombre = request.Nombre,
            Apellido = request.Apellido,
            Email = request.Email,
            Telefono = request.Telefono,
        };

        _repo.Agregar(cliente);

        return Ok();
    }

    [HttpPut("{dni}")]
    public IActionResult Put(int dni, [FromBody] ClienteUpdateRequest request)
    {
        if (request == null)
            return BadRequest();

        var existente = _repo.ObtenerPorDni(dni);

        if (existente == null)
            return NotFound();

        existente.Nombre = request.Nombre;
        existente.Apellido = request.Apellido;
        existente.Email = request.Email;
        existente.Telefono = request.Telefono;

        _repo.Actualizar(existente);

        return Ok();
    }

    [HttpDelete("{dni}")]
    public IActionResult Delete(int dni)
    {
        var existente = _repo.ObtenerPorDni(dni);

        if (existente == null)
            return NotFound();

        _repo.Eliminar(dni);

        return Ok();
    }
}