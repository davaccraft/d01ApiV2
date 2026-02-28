using d01ApiV2.Common.Configuration;
using d01ApiV2.DbFactory.Interface;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace d01ApiV2.DbFactory.Implementation
{
    public class AppDbFactory : BaseDbFactory, IAppDbFactory
    {
        public override string ConnectionString => DbFactoryConfiguration.AppDb;

        public AppDbFactory(IOptions<DbFactoryConfiguration> dbFactoryConfiguration) : base(dbFactoryConfiguration)
        {
        }
    }
}
