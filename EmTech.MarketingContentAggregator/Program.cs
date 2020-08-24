using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EmTech.Actions;

namespace EmTech.MarketingContentAggregator
{
  public static class Program
  {
    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
          services.AddHostedService<Worker>();
          services.AddSingleton<IActionRunner, MarketingActionRunner>();
        });
  }
}