using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ExerciceEntity
    {
        [Key]
        public short UserId { get; set; }
        //https://docs.microsoft.com/fr-fr/sql/t-sql/data-types/int-bigint-smallint-and-tinyint-transact-sql?view=sql-server-ver15
        //https://docs.microsoft.com/en-us/sql/t-sql/data-types/data-type-conversion-database-engine?view=sql-server-ver15
        //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings

        public string UserName { get; set; }
        public string Login { get; set; }
        public DateTime Birthday { get; set; }       
        public Guid Id { get; set; }
       
        public string Name { get; set; }       
        public string Description { get; set; }       
        public MuscleArea MuscleArea { get; set; }       
        public string VideoName { get; set; }


        public ExerciceEntity(short userId, string userName, string login, DateTime birthday)
        {
            UserId = userId;
            UserName = userName;
            Login = login;
            Birthday = birthday;
        }
    }
}
