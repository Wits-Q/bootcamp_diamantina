using System.ComponentModel;
namespace Tarefas.Web.Models
{
    public class TarefasViewModel
    {
        [DisplayName("Código")]
        public int id {get;set;}

        [DisplayName("Titulo")]
        public string Titulo {get;set;}

        [DisplayName("Titulo")]
        public string Descricao {get;set;}
    }
}