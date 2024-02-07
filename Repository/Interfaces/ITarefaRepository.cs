using APITarefas.Models;

namespace APITarefas.Repository.Interfaces
{
    public interface ITarefaRepository
    {
        List<Tarefa> ObterTodasTarefas();
    }
}
