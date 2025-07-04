﻿using MongoDB.Bson.Serialization.Attributes;

namespace ConsoleNet.Entities;

public class BaseEntity
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }
    public bool Deleted { get; set; }
}
