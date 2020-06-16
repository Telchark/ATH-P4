using System.Threading.Tasks;

namespace MapDemo.UI.ViewModel
{
    public interface IArmorDetailViewModel
    {
        Task LoadAsync(int? armorId);
    }
}