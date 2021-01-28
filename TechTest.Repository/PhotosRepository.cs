using System.Collections.Generic;
using System.Linq;
using TechTest.Domain;
using TechTest.Domain.PhotosAggregate;

namespace TechTest.Repository
{
    public class PhotosRepository : GenericRepository<Photo>, IPhotosRepository
    {
        public PhotosRepository(TechTestDbContext context) : base(context)
        {

        }

        //Implementation of more specific queries go here using linq

    }
}