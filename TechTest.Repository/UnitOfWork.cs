using System;
using TechTest.Domain;
using TechTest.Domain.PhotosAggregate;

namespace TechTest.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TechTestDbContext _context;
        public IPhotosRepository Photos { get; }

        public UnitOfWork(TechTestDbContext techTestDbContext,
            IPhotosRepository photosRepository)
        {
            this._context = techTestDbContext;

            this.Photos = photosRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
