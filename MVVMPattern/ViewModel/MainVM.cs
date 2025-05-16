using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMPattern.ViewModel
{
    internal class MainVM : ObservableObject
    {
        private readonly Navigation _navigation;

        public MainVM(Navigation navigation)
        {
            _navigation = navigation;
        }
    }
}
