using EmtechActions;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace EmtechActionsUnitTests.Fixtures
{
    [TestFixture]
    public class EventDelegatorFixture
    {
        protected IEventDelegator DelegatorUnderTest;
        protected Mock<ILogger<IEventDelegator>> LoggerMock;
        
        [SetUp] 
        public void Init()
        {
            LoggerMock = new Mock<ILogger<IEventDelegator>>();
            DelegatorUnderTest = new EventDelegatorV0(LoggerMock.Object);
        }
    }
}