using System;
using System.Threading;
using System.Threading.Tasks;
using EmTech.Actions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EmTech.MarketingContentAggregator
{
    public class Worker : IHostedService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IActionRunner _actionRunner;
        private IHostApplicationLifetime _applicationLifetime;

        public Worker(ILogger<Worker> logger, IActionRunner actionRunner, IHostApplicationLifetime applicationLifetime)
        {
            _logger = logger;
            _actionRunner = actionRunner;
            _applicationLifetime = applicationLifetime;
        }

        /// <inheritdoc />
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            var result = await _actionRunner.Run();
            result.Match(
                Succ: v => { _logger.LogInformation("Success"); },
                Fail: e => { _logger.LogError(e, "Error"); }
            );
           _applicationLifetime.StopApplication(); 
        }

        /// <inheritdoc />
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}