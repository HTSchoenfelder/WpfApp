using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Services;

namespace WpfApp.ViewModels
{
    public class MainContentViewModel : BaseViewModel
    {
        private AppConfigurationService _appConfigurationService;

        public MainContentViewModel(AppConfigurationService appConfigurationService)
        {
            _appConfigurationService = appConfigurationService;
        }

        public DelegateCommand LoadCommand => new DelegateCommand(() => SampleText = _appConfigurationService.GetSampleText());
        public DelegateCommand ClearCommand => new DelegateCommand(() =>
        {
            SampleText = string.Empty;
            ApplicationLogger.Log("Text cleared");
        });

        private string _sampleText = null;
        public string SampleText
        {
            get { return _sampleText; }
            set { SetProperty(ref _sampleText, value); }
        }
    }
}
