using APITarefas.Models;
using APITarefas.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APITarefas.Controllers
{
    [Route("[controller]")]
    public class TarefaController : Controller
    {
        private readonly ITarefaRepository _tarefaRepository;
        [HttpGet("[action]")]
        public List<Tarefa> ObterTodasTarefas()
        {
            return _tarefaRepository.ObterTodasTarefas();
        }
    }
}
