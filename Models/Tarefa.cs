// Models/Tarefa.cs
namespace GerenciadorDeTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; } // Chave primária
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public bool Concluida { get; set; }
    }
}