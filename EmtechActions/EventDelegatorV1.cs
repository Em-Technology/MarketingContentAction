// TODO: Create EventDelegatorV0
// Implement the interface of the EventDelegator type
// Should simply log events for the time being

using EmtechActions.Events;
using Microsoft.Extensions.Logging;

namespace EmtechActions
{
  public class EventDelegatorV0 : IEventDelegator
  {
    private ILogger<IEventDelegator> _logger;

    public EventDelegatorV0(ILogger<IEventDelegator> logger) => _logger = logger;

    public int Run(EventWrapper wrapper)
    {
      _logger.LogInformation(wrapper.ToString());
      return 0;
    }
    
  }
}