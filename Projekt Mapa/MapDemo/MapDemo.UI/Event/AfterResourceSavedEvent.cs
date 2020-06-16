using Prism.Events;

namespace MapDemo.UI.Event
{
    public class AfterResourceSavedEvent : PubSubEvent<AfterResourceSavedEventArgs>
    {
    }
    public class AfterResourceSavedEventArgs
    {
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
    }
}
