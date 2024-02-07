using APITarefas.Data;
using APITarefas.Models;
using APITarefas.Repository.Interfaces;

namespace APITarefas.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly AppDbContext _context;

        public TarefaRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Tarefa> ObterTodasTarefas()
        {
            return _context.Tarefas.ToList();
        }
    }
}
