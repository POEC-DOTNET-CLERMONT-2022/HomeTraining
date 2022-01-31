using Ipme.Hometraining.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ipme.Hometraining.Persistance
{
    public class UserSqlRepository : IUserRepository
    {
        //injection de dependance du DbContext
        private DbContext SqlContext { get; }

        public UserSqlRepository(DbContext sqlContext)
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
            SqlContext.SaveChanges();
        }

        public UserEntity RemoveUser(Guid id)
        {
            var userEntity = GetSingleUser(id);
            if (userEntity == null)            
                return null;            
            SqlContext.Set<UserEntity>().Remove(userEntity);
            SqlContext.SaveChanges();
            return userEntity;
        }

        UserEntity IUserRepository.UpdateUser(UserEntity userEntity)
        {
            var user = GetSingleUser(userEntity.Id);
            if (user == null)
                return null;
            SqlContext.Set<UserEntity>().Update(userEntity);
            SqlContext.SaveChanges();
            return userEntity;
        }

    }
}
