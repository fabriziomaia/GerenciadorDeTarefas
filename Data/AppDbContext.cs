// Data/AppDbContext.cs
using GerenciadorDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefas.Data
{
    public class AppDbContext : DbContext
    {
        // DbSet representa a coleção da entidade Tarefa, que se tornará uma tabela
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura o DbContext para usar o banco de dados SQLite
            // O arquivo do banco será criado na raiz do projeto
            optionsBuilder.UseSqlite("Data Source=tarefas.db");
        }
    }
}