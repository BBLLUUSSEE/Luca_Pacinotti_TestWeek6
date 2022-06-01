using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esercitazione.Week6.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IOrderBL _mainBL;


        [HttpPost]
        public IActionResult CreaCliente(Cliente nuovoCliente) // Model Binding
        {
            if (nuovoCliente is null)
                return BadRequest("Invalid Employee data");

            bool cliente = _mainBL.CreaCliente(nuovoCliente);

            if (!cliente)
                return StatusCode(500, "Cannot save Employee");

            return CreatedAtAction(nameof(CreaCliente), new { id = nuovoCliente.Id }, nuovoCliente);
        }
    }
}
