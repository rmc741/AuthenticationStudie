using Microsoft.Extensions.Options;

namespace AuthenticationStudie
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureApi(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddMemoryCache();
            //
            //services.AddSingleton<IBoletoRepository>(provider =>
            //{
            //    var logger = provider.GetRequiredService<ILogger<BoletoRepository>>();
            //    var databaseSettingsUser = provider.GetRequiredService<IOptions<StorageAccountOptions>>();
            //    return new BoletoRepository(databaseSettingsUser.Value.ConexaoSqlServer, logger);
            //});
            //
            //services.AddSingleton<IBancoDoBrasilAgent>(provider =>
            //{
            //    var logger = provider.GetRequiredService<ILogger<BancoDoBrasilAgent>>();
            //    var urlBancoBrasil = provider.GetRequiredService<IOptions<BancoBrasilConfiguration>>();
            //    return new BancoDoBrasilAgent(
            //        logger,
            //        urlBancoBrasil.Value.BancoDoBrasilAuthUrl,
            //        urlBancoBrasil.Value.BancoDoBrasilCobrancaUrl
            //    );
            //});
            //
            //services.AddSingleton<IConcursoBancoLoginRepository>(provider =>
            //{
            //    var logger = provider.GetRequiredService<ILogger<ConcursoBancoLoginRepository>>();
            //    var databaseSettingsUser = provider.GetRequiredService<IOptions<StorageAccountOptions>>();
            //    return new ConcursoBancoLoginRepository(databaseSettingsUser.Value.ConexaoSqlServer, logger);
            //});
            //
            //services.AddSingleton<BancoDoBrasilService>(provider =>
            //{
            //    var bancoBrasilAgent = provider.GetRequiredService<IBancoDoBrasilAgent>();
            //    var boletoRepository = provider.GetRequiredService<IBoletoRepository>();
            //    var concursoBancoLoginRepository = provider.GetRequiredService<IConcursoBancoLoginRepository>();
            //    return new BancoDoBrasilService(bancoBrasilAgent, boletoRepository, concursoBancoLoginRepository);
            //});
            //
            //services.AddSingleton<ISantanderAgent>(provider =>
            //{
            //    var logger = provider.GetRequiredService<ILogger<SantanderAgent>>();
            //    var urlSantander = provider.GetRequiredService<IOptions<SantanderConfiguration>>();
            //    return new SantanderAgent(
            //        logger,
            //        urlSantander.Value.SantanderAuthUrl,
            //        urlSantander.Value.SantanderBillsUrl,
            //        urlSantander.Value.SantanderWorkspacesUrl
            //    );
            //});
            //
            //services.AddSingleton<SantanderService>(provider =>
            //{
            //    var santanderAgent = provider.GetRequiredService<ISantanderAgent>();
            //    var boletoRepository = provider.GetRequiredService<IBoletoRepository>();
            //    var concursoBancoLoginRepository = provider.GetRequiredService<IConcursoBancoLoginRepository>();
            //    var urlSantander = provider.GetRequiredService<IOptions<SantanderConfiguration>>();
            //    return new SantanderService(
            //        santanderAgent,
            //        boletoRepository,
            //        concursoBancoLoginRepository,
            //        urlSantander.Value.SantanderCertificatePath,
            //        urlSantander.Value.SantanderCertificatePassword
            //    );
            //});
            //
            //services.AddSingleton<IBradescoAgent>(provider =>
            //{
            //    var logger = provider.GetRequiredService<ILogger<BradescoAgent>>();
            //    var databaseSettingsUser = provider.GetRequiredService<IOptions<StorageAccountOptions>>();
            //    return new BradescoAgent(databaseSettingsUser.Value.ConexaoSqlServer, logger);
            //});
            //
            //services.AddSingleton<IBanestesAgent>(provider =>
            //{
            //    var logger = provider.GetRequiredService<ILogger<BanestesAgent>>();
            //    var databaseSettingsUser = provider.GetRequiredService<IOptions<StorageAccountOptions>>();
            //    return new BanestesAgent(databaseSettingsUser.Value.ConexaoSqlServer, logger);
            //});

            return services;
        }

        public static IServiceCollection AddOptionsApi(this IServiceCollection service, IConfiguration configuration)
        {
            //service.Configure<StorageAccountOptions>(options =>
            //{
            //    options.ConexaoSqlServer = configuration["ConexaoSqlServer"];
            //});
            //
            //service.Configure<BancoBrasilConfiguration>(options =>
            //{
            //    options.BancoDoBrasilAuthUrl = configuration["BancoDoBrasilAuthUrl"];
            //    options.BancoDoBrasilCobrancaUrl = configuration["BancoDoBrasilCobrancaUrl"];
            //});
            //
            //service.Configure<SantanderConfiguration>(options =>
            //{
            //    options.SantanderAuthUrl = configuration["SantanderAuthUrl"];
            //    options.SantanderBillsUrl = configuration["SantanderBillsUrl"];
            //    options.SantanderWorkspacesUrl = configuration["SantanderWorkspacesUrl"];
            //    options.SantanderCertificatePath = configuration["SantanderCertificatePath"];
            //    options.SantanderCertificatePassword = configuration["SantanderCertificatePassword"];
            //});

            return service;
        }
    }
}
