using Microsoft.AspNetCore.Mvc;

namespace UsuariosAPI.Controllers;


[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult CadastraUsuario()
    {
        throw new NotImplementedException();
    }
}
