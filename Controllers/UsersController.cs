using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    public class UsersController : BaseAPIController
    {
        private readonly DataContext _dbContext;

        public UsersController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _dbContext.Users.ToListAsync();

            return users;
        }

        [HttpGet("{ID}")]

        public async Task<ActionResult<AppUser>> GetUser(int ID)
        {
            return await _dbContext.Users.FindAsync(ID);
            
        }
    }
}
