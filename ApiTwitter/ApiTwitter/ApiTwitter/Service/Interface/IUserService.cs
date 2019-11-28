using ApiTwitter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTwitter.Service.Interface
{
    public interface IUserService
    {
        bool Add(User user);
       // public bool Login(User user);

    }
}
