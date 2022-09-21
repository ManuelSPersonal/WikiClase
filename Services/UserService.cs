using WikiClase.Data;
using WikiClase.Models;

namespace WikiClase.Services
{
    public class UserService
    {
        ApplicationDbContext dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<User> getAll()
        {
            return dbContext.Users.ToList();
        }

        public User register(User newUser)
        {
            dbContext.Users.Add(newUser);
            dbContext.SaveChangesAsync();
            return newUser;
        }
    }
}
