using System;
using MongoDB.Driver;

namespace Mongo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new MongoClient(
                "mongodb://localhost:27017/admin"
            );
            var database = client.GetDatabase("test");
        }
    }
}
