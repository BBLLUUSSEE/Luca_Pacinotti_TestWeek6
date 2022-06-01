using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esercitazione.Week6.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderBL _mainBL;

        public OrderController(IOrderBL mainBL)
        {
            _mainBL = mainBL;
        }





        [HttpGet("{id}")]
        public IActionResult CercaPerId(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid order id");

            var order = _mainBL.CercaPerId(id);

            if (order is null)
                return NotFound();

            return Ok(order);
        }







        [HttpPost]
        public IActionResult CreaOrdine(Ordine nuovoOrdine) // Model Binding
        {
            if (nuovoOrdine is null)
                return BadRequest("Invalid Employee data");

            bool order = _mainBL.CreaOrdine(nuovoOrdine);

            if (!order)
                return StatusCode(500, "Cannot save Employee");

            return CreatedAtAction(nameof(CreaOrdine), new { id = nuovoOrdine.Id }, nuovoOrdine);
        }
    }
}
