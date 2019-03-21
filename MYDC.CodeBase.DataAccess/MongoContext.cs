using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MYDC.CodeBase.DataAccess.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYDC.CodeBase.DataAccess
{
    public class MongoContext
    {
        public IConfigurationRoot Configuration { get; }
        private IMongoDatabase _database = null;

        public MongoContext(IOptions<Settings> settings)
        {
            Configuration = settings.Value.iConfigurationRoot;
            settings.Value.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
            settings.Value.Database = Configuration.GetSection("MongoConnection:Database").Value;

            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }
        }
        public IMongoDatabase mongoDatabase
        {
            get
            {
                return _database;
            }
        }
        public IMongoCollection<master_keyword> master_keyword
        {
            get
            {
                return _database.GetCollection<master_keyword>("master_keyword");
            }
        }

        public IMongoCollection<master_receiver> master_receiver
        {
            get
            {
                return _database.GetCollection<master_receiver>("master_receiver");
            }
        }

        public IMongoCollection<master_announcement> master_announcement
        {
            get
            {
                return _database.GetCollection<master_announcement>("master_announcement");
            }
        }
    }
}
