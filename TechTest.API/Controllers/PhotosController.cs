using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechTest.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PhotosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<PhotosController>
        [HttpGet]
        public async Task<IEnumerable<Photo>> GetAsync()
        {
            return await _unitOfWork.Photos.GetAll();
        }

        // GET api/<PhotosController>/5
        [HttpGet("{id}")]
        public async Task<Photo> GetAsync(int id)
        {
            return await _unitOfWork.Photos.Get(id);
        }


        // POST api/<PhotosController>
        [HttpPost]
        public async Task PostAsync([FromBody] Photo photo)
        {
            await _unitOfWork.Photos.Add(photo);
        }

        // PUT api/<PhotosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //change image title and/or discription (unused for now)
        }

        // DELETE api/<PhotosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO when deleting photos is required (unused for now)
        }
    }
}
