using EmtechActions.Events;

namespace EmtechActions
{
    public interface IEventDelegator
    {
        public int Run(EventWrapper eventWrapper);
    }
}