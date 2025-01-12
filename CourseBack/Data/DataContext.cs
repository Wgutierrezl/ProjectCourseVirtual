using EntitiesControllers.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CourseBack.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<EstudianteCursos> EstudianteCursos { get; set; }
        public DbSet<Evaluaciones> Evaluaciones { get; set; }
        public DbSet<PreguntasEvaluacion> preguntasEvaluacion { get; set; }
        public DbSet<Respuestas> Respuestas { get; set; }

        //Agrego estas para saber si no causa error pero no las voy a utilizar
        //public DbSet<LoginDTO> LoginDTO { get; set; }
        //public DbSet<SesionDTO> sesionDTO { get;set; }
        // Para crear index y evitar repeticiones de nombres de los tipos de categorias
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Tipo>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<EstudianteCursos>()
            .HasKey(e => new { e.EstudianteID, e.CodigoCurso });
            // modelBuilder.Entity<EstudianteCursos>()
            //.ToTable(tb => tb.UseSqlOutputClause(false));
        }

    }
}
