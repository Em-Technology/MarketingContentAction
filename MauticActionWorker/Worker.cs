using System;
using System.Threading;
using System.Threading.Tasks;
using EmtechActions;
using EmtechActions.Events;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MauticActionWorker
{
  public class Worker : BackgroundService
  {
    private readonly ILogger<Worker> _logger;
    private readonly IEventDelegator _eventDelegator;

    public Worker(ILogger<Worker> logger, IEventDelegator eventDelegator)
    {
      _logger = logger;
      _eventDelegator = eventDelegator;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
      while (!stoppingToken.IsCancellationRequested)
      {
        _eventDelegator.Run(new EventWrapper(new { }));
        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        await Task.Delay(1000, stoppingToken);
      }
    }
  }
}