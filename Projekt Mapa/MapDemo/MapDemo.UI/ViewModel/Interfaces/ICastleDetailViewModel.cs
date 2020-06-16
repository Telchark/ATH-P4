using System.Threading.Tasks;

namespace MapDemo.UI.ViewModel
{
    public interface ICastleDetailViewModel
    {
        Task LoadAsync(int? castleId);
    }
}