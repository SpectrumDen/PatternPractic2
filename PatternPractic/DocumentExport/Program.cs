using System.Threading.Tasks;
using DocumentExport.Adapters;
using DocumentExport.Decorators;
using DocumentExport.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DocumentExport
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      using IHost host = CreateHostBuilder(args).Build();

      await host.RunAsync();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
      return Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
          services.AddSingleton<IExport, ExportService>()
                  .AddSingleton<ExportAdapter>()
                  .AddSingleton<ExportAdaptee>()
                  .AddSingleton<StorageService>()   
                  .AddSingleton<EncryptService>()
                  .AddSingleton<EncryptAdapter>()     
                  .AddSingleton<EncryptAdaptee>()
                  .AddSingleton<ArchiveService>()
                  .AddHostedService<DocumentExportService>());
    }
  }
}
