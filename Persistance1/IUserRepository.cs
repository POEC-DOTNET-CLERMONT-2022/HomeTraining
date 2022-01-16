using System;
using System.Collections.Generic;
using Ipme.Hometraining.Entities;

namespace Ipme.Hometraining.Persistance
{
    public interface IUserRepository
    {
        IEnumerable<UserEntity> GetAllUsers();

        UserEntity GetSingleUser(Guid id);

        void AddUser(UserEntity userEntity);

        UserEntity RemoveUser(Guid id);

    }
}

