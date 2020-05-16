using Service;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ResultadoController : Controller
    {
        // GET: Resultado
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(string palavra)
        {
            try
            {
                var servico = new PalavraTrianguloService();
                var palavraTriangulo = servico.PalavraTriangulo(palavra);

                return $"O resultado da palavra {palavraTriangulo.Palavra} é {palavraTriangulo.Valor}.";
            }
            catch (System.Exception)
            {
                return "Erro ao processar a palavra.";
            }
        }
    }
}