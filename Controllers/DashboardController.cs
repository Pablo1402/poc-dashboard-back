using Microsoft.AspNetCore.Mvc;

namespace poc_backend_dashboard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : Controller
    {
        [HttpGet("carteira_total")]
        public IActionResult GetCarteiraTotal()
        {
            var carteiraTotal = new Carteira
            {
                total_carteira = 1234569,
                percentuais = new List<Percentuais>
                {
                    new Percentuais
                    {
                        cor = "#fff",
                        tipo = "fundos",
                        valor = 10
                    },
                    new Percentuais
                    {
                        cor = "#fff",
                        tipo = "acoes",
                        valor = 40
                    },
                    new Percentuais
                    {
                        cor = "#fff",
                        tipo = "renda fixa",
                        valor = 50
                    }

                }
            };
            return Ok(carteiraTotal);

        }

        [HttpGet("suitability")]
        public IActionResult GetSuitability()
        {
            var suitability = new List<Suitability>()
            {
                new Suitability()
                {
                    data_referencia = "out/2022",
                    quantidade = 254
                },
                new Suitability()
                {
                    data_referencia = "nov/2022",
                    quantidade = 541
                },
                new Suitability()
                {
                    data_referencia = "dez/2022",
                    quantidade = 725
                }
            };
            return Ok(suitability);

        }
    }
}
