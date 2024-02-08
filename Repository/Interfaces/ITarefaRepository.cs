using APITarefas.Models;

namespace APITarefas.Repository.Interfaces
{
    public interface ITarefaRepository
    {
        List<Tarefa> ConsultarTodasAsTarefas();
        List<Tarefa> ConsultarTodasAsTarefasConcluidas();
        List<Tarefa> ConsultarTodasAsTarefasEmAberto();
        int IncluirUmaNovaTarefa(Tarefa tarefa);
        Tarefa? AtualizarADescriçãoDeUmaTarefa(Tarefa tarefa);
        public void ExcluirUmaTarefa(int idTarefa);
    }
}
