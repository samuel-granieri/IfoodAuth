using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IfoodAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IfoodController : ControllerBase
    {
        [HttpGet("callback")]
        public IActionResult Callback([FromQuery] string code, [FromQuery] string state)
        {
            if (string.IsNullOrEmpty(code))
                return BadRequest("Código não recebido.");

            // Aqui você pode salvar o CODE ou chamar o serviço que troca pelo access token
            // Exemplo (opcional): salvar em log temporário
            Console.WriteLine("CODE recebido do iFood: " + code);

            // Você pode redirecionar para uma página de sucesso (opcional)
            return Ok(new
            {
                message = "Código recebido com sucesso!",
                code = code
            });
        }

    }
}
