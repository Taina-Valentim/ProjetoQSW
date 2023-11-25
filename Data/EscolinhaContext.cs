using Microsoft.EntityFrameworkCore;
using ProjetoQSW.Models;

namespace ProjetoQSW.Data
{
    public class EscolinhaContext : DbContext
    {
        public EscolinhaContext(DbContextOptions<EscolinhaContext> opcoes) : base(opcoes)
        {
        }

        public DbSet<Professor> Professores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<MateriaGrade> MateriasGrades { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
