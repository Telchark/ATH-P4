using Prism.Events;

namespace MapDemo.UI.Event
{
    class AfterCastleSavedEvent : PubSubEvent<AfterCastleSavedEventArgs>
    {
    }
    public class AfterCastleSavedEventArgs
    {
        public int CastleId { get; set; }
        public string CastleName { get; set; }
        public int X{ get; set; }
        public int Y { get; set; }
    }
}
