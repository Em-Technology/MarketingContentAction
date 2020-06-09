namespace EmtechActions.Events
{
    public class EventWrapper<T> where T : FakeEvent
    {
        public EventWrapper(object payload)
        {
            Event = new FakeEvent();
        }

        internal d Event  { get; private set; } 

      
    }
}