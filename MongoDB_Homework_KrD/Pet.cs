using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_Homework_KrD
{
    public class Pet
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        public string Nickname { get; set; }
        public Species Species { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Owner Owner { get; set; }
    }
}
