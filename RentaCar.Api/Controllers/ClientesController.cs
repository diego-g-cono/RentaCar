using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Repositorios;

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
    public ActionResult<List<Cliente>> Get()
    {
        return _repo.ObtenerTodos();
    }

    [HttpGet("{dni}")]
    public ActionResult<Cliente> Get(int dni)
    {
        var cliente = _repo.ObtenerPorDni(dni);
        if (cliente == null) return NotFound();
        return cliente;
    }

    [HttpPost]
    public IActionResult Post([FromBody] Cliente cliente)
    {
        _repo.Agregar(cliente);
        return Ok();
    }

    [HttpPut("{dni}")]
    public IActionResult Put(int dni, [FromBody] Cliente cliente)
    {
        _repo.Actualizar(cliente);
        return Ok();
    }

    [HttpDelete("{dni}")]
    public IActionResult Delete(int dni)
    {
        _repo.Eliminar(dni);
        return Ok();
    }
}
