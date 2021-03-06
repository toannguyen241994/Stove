﻿using System.Reflection;

using NSubstitute;

using StackExchange.Redis;

using Stove.Reflection.Extensions;
using Stove.TestBase;

namespace Stove.Redis.Tests
{
	public abstract class RedisTestBase : ApplicationTestBase<StoveRedisTestBootstrapper>
	{
		protected RedisTestBase()
		{
			Building(builder =>
			{
				builder.UseStoveRedisCaching(configuration =>
				       {
					       configuration.ConfigurationOptions = new ConfigurationOptions();
					       return configuration;
				       })
				       .RegisterServices(r => r.RegisterAssemblyByConvention(typeof(RedisTestBase).GetAssembly()));
			});
		}
	}
}
