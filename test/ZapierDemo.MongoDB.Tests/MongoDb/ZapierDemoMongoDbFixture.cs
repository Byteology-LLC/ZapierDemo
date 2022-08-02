using System;
using Mongo2Go;

namespace ZapierDemo.MongoDB;

public class ZapierDemoMongoDbFixture : IDisposable
{
    private static readonly MongoDbRunner MongoDbRunner;
    public static readonly string ConnectionString;

    static ZapierDemoMongoDbFixture()
    {
        MongoDbRunner = MongoDbRunner.Start(singleNodeReplSet: true, singleNodeReplSetWaitTimeout: 20);
        ConnectionString = MongoDbRunner.ConnectionString;
    }

    public void Dispose()
    {
        MongoDbRunner?.Dispose();
    }
}
