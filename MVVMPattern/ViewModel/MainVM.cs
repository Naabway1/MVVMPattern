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

        private string _login;
        public string Login
        {
            get => _login;
            set
            {
                if (value != _login)
                {
                    _login = value;
                }
                OnPropertyChanged(nameof(Login));
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                if (value != _password)
                {
                    _password = value;
                }
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand AuthCommand { get; private set; }

        public MainVM(Navigation navigation)
        {
            _navigation = navigation;

            AuthCommand = new RelayCommand(_ => Auth());
        }

        private void Auth()
        {
            if (_login == "123" && _password == "123")
            {
                _navigation.NavigateTo("MainPage", this);
            } 
        }
    }
}
