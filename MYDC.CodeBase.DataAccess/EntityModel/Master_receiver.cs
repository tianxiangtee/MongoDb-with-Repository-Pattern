using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYDC.CodeBase.DataAccess.EntityModel
{
    public partial class master_receiver
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }
        public int ID { get; set; }
        public string RM_ID { get; set; }
        public string RM_RCVER { get; set; }
        public string RM_ADDR { get; set; }
        public string RM_TEL { get; set; }
        public string RM_POSTCODE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public string CREATED_BY { get; set; }
        public string CREATED_DATE { get; set; }
        public string MODIFIED_BY { get; set; }
        public string MODIFIED_DATE { get; set; }
        public int CM_ID { get; set; }

        //public virtual master_company master_company { get; set; }
    }
}
