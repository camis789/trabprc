using ApiTwitter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTwitter.Repository.Interface
{
    public interface IUserRepository
    {
        void Add(User user);
        User Find(long id);
        IEnumerable<User> GetAll();
        void Remove(long id);

        void Update(User user);
        //User Login(User user);
    }
}
