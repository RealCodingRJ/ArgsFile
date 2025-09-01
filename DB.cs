using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace intro
{
    class DB
    {

        public static void CreateDB(string code)
        {

            string URI = "mongodb://localhost:27017/";

            var client = new MongoClient(URI);

            var collection = client.GetDatabase("Args_Passed").GetCollection<BsonDocument>("args");

            var filter = Builders<BsonDocument>.Filter.Eq("title", "Back to the Future");

            var document = collection.Find(filter).First();

            collection.InsertOne(new BsonDocument($"{code}", ""));

            Console.WriteLine(document);


        }
    }
}