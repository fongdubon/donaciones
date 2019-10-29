namespace Donaciones.Web.Data.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;

    public interface IGenericRepository<T> where T : class
    {
        //método para obtner todos los datos
        IQueryable<T> GetAll();
        //método para obtener una entidad dado un Id
        Task<T> GetByIdAsync(int id);
        //método para crear una entidad
        Task CreateAsync(T entity);
        //método para actualizar una entidad
        Task UpdateAsync(T entity);
        //método para eliminar una entidad
        Task DeleteAsync(T entity);
        //método para verificar si existe una entidad dado un Id
        Task<bool> ExistAsync(int id);
    }
}
