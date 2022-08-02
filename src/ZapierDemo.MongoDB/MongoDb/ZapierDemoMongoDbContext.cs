﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ZapierDemo.MongoDB;

[ConnectionStringName("Default")]
public class ZapierDemoMongoDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //modelBuilder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
