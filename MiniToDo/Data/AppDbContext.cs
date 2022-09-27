using Microsoft.EntityFrameworkCore;
using MiniToDo.Models;

namespace MiniToDo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDo>  Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");    //configurando conexão com o banco de dados
    }
}
