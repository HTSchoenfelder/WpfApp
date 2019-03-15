using Prism.Mvvm;
using Prism.Regions;
using WpfApp.Services;
using WpfApp.Views;

namespace WpfApp.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _title = "WpfApp";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }        
    }
}
