using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Repositorios;
using RentaCar.Dtos.Clientes;
using RentaCar.Infraestructura;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly ClienteRepositorio _repoClientes;
    private readonly UsuarioRepositorio _repoUsuarios;

    public ClientesController(ClienteRepositorio repoClientes, UsuarioRepositorio repoUsuarios)
    {
        _repoClientes = repoClientes;
        _repoUsuarios = repoUsuarios;
    }

    [HttpGet]
    public ActionResult<List<ClienteResponse>> Get()
    {
        var clientes = _repoClientes.ObtenerTodos();

        var response = clientes.Select(c => new ClienteResponse
        {
            Dni = c.Dni,
            Nombre = c.Nombre,
            Apellido = c.Apellido,
            Email = c.Email,
            Telefono = c.Telefono,
            NombreUsuario = c.UsuarioId.HasValue
            ? _repoUsuarios.ObtenerPorId(c.UsuarioId.Value)?.NombreUsuario ?? "Sin usuario"
            : "Sin usuario"

        }).ToList();

        return Ok(response);
    }

    [HttpGet("{dni}")]
    public ActionResult<ClienteResponse> Get(int dni)
    {
        var cliente = _repoClientes.ObtenerPorDni(dni);

        if (cliente == null)
            return NotFound();

        var response = new ClienteResponse
        {
            Dni = cliente.Dni,
            Nombre = cliente.Nombre,
            Apellido = cliente.Apellido,
            Email = cliente.Email,
            Telefono = cliente.Telefono,
            NombreUsuario = cliente.UsuarioId.HasValue
            ? _repoUsuarios.ObtenerPorId(cliente.UsuarioId.Value)?.NombreUsuario ?? "Sin usuario"
            : "Sin usuario"
        };

        return Ok(response);
    }


    [HttpPost]
    public IActionResult Post([FromBody] ClienteCreateRequest request)
    {
        if (request == null)
            return BadRequest();


        var existente = _repoClientes.ObtenerPorDni(request.Dni);

        if(existente != null)
        {
            if (existente.Activo)
                return Conflict("Ya existe un cliente activo con ese DNI.");
            
            // Está per inactivo, lo reactivamos y actualizamos sus datos
            existente.Nombre = request.Nombre;
            existente.Apellido = request.Apellido;
            existente.Email = request.Email;
            existente.Telefono = request.Telefono;
            existente.Activo = true;
            
            
            _repoClientes.Actualizar(existente);
            return Ok();
        }


        var cliente = new Cliente
        {
            Dni = request.Dni,
            Nombre = request.Nombre,
            Apellido = request.Apellido,
            Email = request.Email,
            Telefono = request.Telefono,
        };

        _repoClientes.Agregar(cliente);

        return Ok();
    }

    [HttpPut("{dni}")]
    public IActionResult Put(int dni, [FromBody] ClienteUpdateRequest request)
    {
        if (request == null)
            return BadRequest();

        var existente = _repoClientes.ObtenerPorDni(dni);

        if (existente == null)
            return NotFound();

        existente.Nombre = request.Nombre;
        existente.Apellido = request.Apellido;
        existente.Email = request.Email;
        existente.Telefono = request.Telefono;

        _repoClientes.Actualizar(existente);

        return Ok();
    }

    [HttpDelete("{dni}")]
    public IActionResult Delete(int dni)
    {
        var existente = _repoClientes.ObtenerPorDni(dni);

        if (existente == null)
            return NotFound();

        _repoClientes.Eliminar(dni);

        return Ok();
    }
}