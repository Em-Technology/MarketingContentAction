using System;
using System.Threading;
using System.Threading.Tasks;
using EmtechActions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MauticActionWorker
{
  public class Worker : BackgroundService
  {
    private readonly ILogger<Worker> _logger;
    private readonly IActionRunner _actionRunner;

    public Worker(ILogger<Worker> logger, IActionRunner actionRunner)
    {
      _logger = logger;
      _actionRunner = actionRunner;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
      while (!stoppingToken.IsCancellationRequested)
      {
        _actionRunner.Run();
        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        await Task.Delay(1000, stoppingToken);
      }
    }
  }
}