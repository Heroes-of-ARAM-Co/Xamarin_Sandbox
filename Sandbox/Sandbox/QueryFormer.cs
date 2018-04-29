using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace Sandbox
{
    class QueryFormer
    {
        MongoClient client;
        IMongoDatabase db;
         
        public QueryFormer(Sandbox.Models.RoomModel roomQuery)
        {
            DbConnection();
            QueryFile(roomQuery);
            QueryDbSender(roomQuery);

        }
        public QueryFormer(Sandbox.Models.ObjectModel objectQuery )
        {
            DbConnection();
            QueryFile(objectQuery);
            QueryDbSender(objectQuery);
        }
        private void QueryFile(dynamic modelInput)
        {
          string serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(modelInput);

            using (StreamWriter file = File.CreateText(@"path:/test/garen.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, modelInput);
            }

        }
        private void QueryDbSender(dynamic modelInput)
        {
       
            IMongoCollection<dynamic> obj = db.GetCollection<dynamic> ("testowa");
            obj.InsertOne(modelInput);

        }
        private void DbConnection() { 

          client = new MongoClient("mongodb://192.168.47.37:27017");
          db = client.GetDatabase("testowa_apki");
    
            }
   

}
   
}