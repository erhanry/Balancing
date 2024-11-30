using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESO.Utilities;
using System.Windows.Input;

namespace ESO.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object? _currentView;
        public object CurrentView
        {
            get { return _currentView!; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand DashboardCommand { get; set; }
        public ICommand IbexCommand { get; set; }

        private void Dashboard(object obj) => CurrentView = new DashboardVM();
        private void Ibex(object obj) => CurrentView = new IbexVM();

        public NavigationVM()
        {
            DashboardCommand = new RelayCommand(Dashboard);
            IbexCommand = new RelayCommand(Ibex);

            // Startup Page
            CurrentView = new DashboardVM();
        }
    }
}
