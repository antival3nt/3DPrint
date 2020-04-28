using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPrint
{
    public static class MongoUtils
    {
        static MongoClient dbClient;
        public static void MongoConnect()
        {
            dbClient = new MongoClient("mongodb://192.168.1.97:27017/3dprint");
        }
    }
}
