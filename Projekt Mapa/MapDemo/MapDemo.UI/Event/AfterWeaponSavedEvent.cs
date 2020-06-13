using Prism.Events;

namespace MapDemo.UI.Event
{
    public class AfterWeaponSavedEvent : PubSubEvent<AfterWeaponSavedEventArgs>
    {
    }
    public class AfterWeaponSavedEventArgs
    {
        public int WeaponId { get; set; }
        public string WeaponName { get; set; }
    }
}
