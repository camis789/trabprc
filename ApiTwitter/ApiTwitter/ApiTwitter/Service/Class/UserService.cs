using ApiTwitter.Model;
using ApiTwitter.Repository.Interface;
using ApiTwitter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTwitter.Service.Class
{
    public class UserService : IUserService
    {
 
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool Add(User user)
        {
            if (userRepository.Find(user.Id) == null)
            {
                userRepository.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }

       /* public bool Login(User user)
        {
            if (userRepository.Login(user.Email, user.Password) == null)
            {

                return true;
            }
            else
            {
                return false;
            }
            */
        }
    }

