using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ReadConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> defaultSettings = new Dictionary<string, string>()
            {
                { "path","value1"}
            };

            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(defaultSettings)
                .AddJsonFile("config.json", true, true)
                .AddEnvironmentVariables()
                .AddCommandLine(args);

            IConfiguration config = builder.Build();

            var serviceProvider = new ServiceCollection()
                .AddOptions().Configure<MyConfig>(config)
                .BuildServiceProvider();

            var myConfigOptions = serviceProvider.GetService<IOptions<MyConfig>>();
            var myConfig = myConfigOptions.Value;

            Console.WriteLine($"path: { myConfig.Path }");

            Console.WriteLine($"path: { config["path"] }");
            Console.WriteLine($"section: { config.GetSection("test:section").Value }");

            Console.Read();
        }
    }
}
