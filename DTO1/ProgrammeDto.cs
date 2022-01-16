﻿using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    internal class ProgrammeDto
    {
        [DataMember]
        public Guid Id { get; set; } 

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime Created { get; set; }

        [DataMember]
        public Difficulty Difficulty { get; set; }

        [DataMember]
        public Guid UserId { get; set; }
                

    }
}
