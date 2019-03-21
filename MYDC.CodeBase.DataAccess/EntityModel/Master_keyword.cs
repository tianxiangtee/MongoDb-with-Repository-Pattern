using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYDC.CodeBase.DataAccess.EntityModel
{
    public partial class master_keyword
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }
        public BsonInt32 Id { get; set; }
        public string KEY { get; set; }
        public string KEYWORDS { get; set; }
        public string TYPE { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string MODIFIED_BY { get; set; }
        public System.DateTime MODIFIED_DATE { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
