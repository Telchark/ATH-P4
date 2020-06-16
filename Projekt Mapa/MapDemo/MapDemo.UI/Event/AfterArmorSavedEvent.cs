using Prism.Events;

namespace MapDemo.UI.Event
{
    public class AfterArmorSavedEvent : PubSubEvent<AfterArmorSavedEventArgs>
    {
    }
    public class AfterArmorSavedEventArgs
    {
        public int ArmorId { get; set; }
        public string ArmorName { get; set; }
    }
}
