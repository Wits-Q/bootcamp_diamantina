using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers
{
    public class TarefaController : Controller
    {
        public List<TarefasViewModel> listaDeTarefas{get; set;}

        public TarefaController()
        {
            {
             listaDeTarefas = new List<TarefasViewModel>()
            {
                new TarefasViewModel() { id = 1 Titulo = "Arrumando a cama", Descricao = "Dobrar as roupas de cama"},
                new TarefasViewModel() { id = 2 Titulo = "Escovar os dentes", Descricao = "Pegar a escova de dentes"}
            };

        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Index()
        

        public IActionResult Index()
        {
            return View(listaDeTarefas);
        }

        public IActionResult Create(){
            return View();
        }

        public IActionResult Index(){
            return View(listaDeTarefas);
        }

        public IActionResult Details(int id){
            var tarefa = listaDeTarefas.Find(tarefa.id == id);
            return View(tarefa);
        }

    }
}
