using System.Threading.Tasks;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
        // Add a generic such as a user or photo
        // We can create one method with generic type which
        // allows us to work with both photos and users
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         
         // When we save changes there will either be zero or more
         // than zeor changes. If more than one was saved, we know
         // nothing happened.
         Task<bool> SaveAll();

         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);

        Task<Photo> GetMainPhotoForUser(int userId);
    }
}