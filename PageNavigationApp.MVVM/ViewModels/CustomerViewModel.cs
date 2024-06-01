using PageNavigationApp.MVVM.Models;

namespace PageNavigationApp.MVVM.ViewModels
{
    public class CustomerViewModel : ViewModelBase
    {
        private readonly Page _page;
        public int CustomerId 
        { 
            get; 
            set => SetProperty(ref, value);
        }
    }
}
