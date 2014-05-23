namespace Employee.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using MongoDB.Bson.Serialization.Attributes;

    [BsonIgnoreExtraElements]
    public class Employee: MongoEntity
    {
        public Employee()
        {
        }

        public string Name { get; set; }
    }
}
