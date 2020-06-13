using System.Threading.Tasks;

namespace MapDemo.UI.ViewModel
{
    public interface IResourceDetailViewModel
    {
        Task LoadAsync(int resourceId);
    }
}