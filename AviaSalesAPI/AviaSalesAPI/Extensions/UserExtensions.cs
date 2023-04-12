using AviaSalesAPI.Contracts;
using AviaSalesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesAPI
{
    public static class UserExtensions
    {
        public static UserResponse ToResponse(this User user)
        {
            return new UserResponse
            {
                IdUser = user.IdUser,
                IdRole = user.IdRole,
                Login = user.Login,
                Password = user.Password
            };
        }
    }
}
