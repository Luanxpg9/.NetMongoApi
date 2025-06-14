﻿using MongoDB.Bson.Serialization.Attributes;

namespace ConsoleNet.Entities;

public abstract class BaseEntity
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }
}
