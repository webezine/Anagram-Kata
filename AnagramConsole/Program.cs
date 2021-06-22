using AnagramConsole.Common.Adapters;
using AnagramConsole.Common.Factories;
using AnagramConsole.Common.Interfaces;
using DAL.Queries;
using DAL.Queries.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using NLog.Extensions.Logging;
using AnagramConsole.Services;

namespace AnagramConsole
{
    class Program
    {

        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<ConsoleApplication>().Run();
            DisposeServices();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            // Setup DB factory with connection string.
            services.AddTransient<IDapperWrapperFactory>(s =>
                new DapperWrapperFactory(ConfigurationManager.ConnectionStrings["anagram_dbConnection"].ConnectionString));

            // Setup logging
            services.AddLogging(loggingBuilder => {
                loggingBuilder.AddNLog("nlog.config");
            });

            services.AddSingleton<ConsoleApplication>();
            services.AddSingleton<IAnagramChecker, AnagramChecker>();

            #if (DEBUG || TEST)
                services.AddSingleton<IAnagramQuery, AnagramQueryStub>();
                services.AddSingleton<ILoggerAdapter<AnagramQueryStub>, LoggerAdapter<AnagramQueryStub>>();
            #else
                services.AddSingleton<IAnagramQuery, AnagramQuery>();
                services.AddSingleton<ILoggerAdapter<AnagramQuery>, LoggerAdapter<AnagramQuery>>();
            #endif

            _serviceProvider = services.BuildServiceProvider(true);
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }

            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
