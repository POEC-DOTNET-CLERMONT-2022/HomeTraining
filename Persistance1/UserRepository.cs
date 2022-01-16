using Ipme.Hometraining.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipme.Hometraining.Persistance
{
    public class UserRepository : IUserRepository
    {

        //injection de dependance du DbContext
        private DbContext SqlContext { get; }


        public UserRepository(DbContext sqlContext)
        {
            SqlContext = sqlContext;
        }


        public UserEntity GetSingleUser(Guid id)
        {
            return SqlContext.Set<UserEntity>().SingleOrDefault(user => user.Id == id);
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            return SqlContext.Set<UserEntity>().ToList();
        }


        public void AddUser(UserEntity userEntity)
        {
            SqlContext.Set<UserEntity>().Add(userEntity);
        }


        public UserEntity RemoveUser(Guid id)
        {
            var userEntity = GetSingleUser(id);
            if (userEntity == null)
            {
                return null;
            }
            SqlContext.Set<UserEntity>().Remove(userEntity);
            return userEntity;
        }





    }
}
