
namespace TechTest.Domain.PhotosAggregate
{
    public interface IPhotosRepository : IGenericRepository<Photo>
    {
        //If more specific queries are required (maybe a search by title/description)
    }
}
