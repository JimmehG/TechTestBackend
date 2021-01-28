using TechTest.Domain.PhotosAggregate;

namespace TechTest.Domain
{
    public interface IUnitOfWork
    {
        IPhotosRepository Photos { get; }

        int Complete();
    }
}