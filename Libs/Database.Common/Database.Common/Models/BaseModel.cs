﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Database.Common.Models
{
    public abstract class BaseModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
