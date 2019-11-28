using System;
using System.Collections.Generic;
using System.Linq;
using ApiTwitter.Context;
using ApiTwitter.Model;

namespace ApiTwitter.Repository.Class
{
    public class UserRepository
    {
        private readonly DbContextTwitter _context;

        public UserRepository(DbContextTwitter ctx)
        {
            _context = ctx;
        }

        public void Add(User user)
        {
            user.DateCreate = DateTime.Now;
            _context.Users.Add(user);
            _context.SaveChanges();

        }

        public User Find(long id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Remove(long id)
        {
            var entity = _context.Users.First(u => u.Id == id);
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public User Login(User user)
        {
            var userResponse = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
            if (userResponse != null)
            {
                return userResponse;
            }
            else
            {
                return null;
            }
        }
    }
}
