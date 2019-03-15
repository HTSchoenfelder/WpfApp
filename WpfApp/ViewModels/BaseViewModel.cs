using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;
using WpfApp.Services;

namespace WpfApp.ViewModels
{
    public class BaseViewModel : BindableBase
    {
        [Dependency]
        public ILogger ApplicationLogger { get; set; }
    }
}
