namespace Donaciones.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    //hereda de la clase dbContext
    public class DataContext : DbContext
    {
        //creamos el constructor y pasamos las opciones del contexto de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //creamos el método para validar la eliminación en cascada en la base de datos
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var cascadeFKs = builder.Model
           .G­etEntityTypes()
           .SelectMany(t => t.GetForeignKeys())
           .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(builder);
        }
    }
}
