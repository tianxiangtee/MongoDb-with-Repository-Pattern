using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYDC.CodeBase.DataAccess.EntityModel
{     
    public partial class master_announcement
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string CONTENT { get; set; }
        public bool IS_ACTIVE { get; set; }
        public int POSTED_BY { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string MODIFIED_BY { get; set; }
        public DateTime MODIFIED_DATE { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public string EXCERPT { get; set; }
        public string Category { get; set; }
    }
}
