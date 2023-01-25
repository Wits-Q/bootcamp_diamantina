using Microsoft.AspNetCore.Mvc;

namespace Tarefas.Web.Controllers
{
    public class TarefaController : Controller
    {
        public IActionResult Creat()
        {
            return View();
        }
    }
}