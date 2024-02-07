using System.ComponentModel.DataAnnotations.Schema;

namespace APITarefas.Models
{
    [Table("Tarefa")]
    public class Tarefa
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("data_criacao")]
        public string DataCriacao { get; set; }

        [Column("responsavel")]
        public string Responsavel { get; set; }

        [Column("concluida")]
        public bool Concluida { get; set; }
    }
}
