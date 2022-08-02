using ZapierDemo.MongoDB;
using Xunit;

namespace ZapierDemo;

[CollectionDefinition(ZapierDemoTestConsts.CollectionDefinitionName)]
public class ZapierDemoWebCollection : ZapierDemoMongoDbCollectionFixtureBase
{

}
