namespace EmtechActions.Events
{
    public class EventWrapper
    {
        public FakeEvent Event { get; }

        public EventWrapper(object payload)
        {
            Event = new FakeEvent();
        }
      
    }
}