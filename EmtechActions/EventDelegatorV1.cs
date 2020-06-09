// TODO: Create EventDelegatorV0
// Implement the interface of the EventDelegator type
// Should simply log events for the time being

using System.Text;
using EmtechActions.Events;
using Microsoft.Extensions.Logging;

namespace EmtechActions
{
  public class EventDelegatorV0 : IEventDelegator
  {
    private ILogger<IEventDelegator> _logger;

    public EventDelegatorV0(ILogger<IEventDelegator> logger) => _logger = logger;

    public int Run(EventWrapper<FakeEvent> wrapper)
    {
      _logger.Log(wrapper.);
    }
    
  }
}