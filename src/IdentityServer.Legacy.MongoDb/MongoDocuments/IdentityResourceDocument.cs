﻿using MongoDB.Bson.Serialization.Attributes;

namespace IdentityServer.Legacy.MongoDb.MongoDocuments
{
    class IdentityResourceDocument
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("BlobData")]
        public string BlobData { get; set; }
    }
}
