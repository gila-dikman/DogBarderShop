using DogBarderShopWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBarderShopWebApp.Servies
{
    public class LoginServies
    {
        public User CheckLogin(string userName, string password)
        {
            var user = new DogBarbershopDBContext().Query<User>().FromSql("spCheckLogin @p0,@p1", userName, password).ToList();
            return user.FirstOrDefault();

        }

        public User CreateUser(string firstName, string userName, string password)
        {
            var user = new DogBarbershopDBContext().Query<User>().FromSql("spCreateUser @p0,@p1,@p2", firstName, userName, password).ToList();
            return user.FirstOrDefault();

        }
    }
}
