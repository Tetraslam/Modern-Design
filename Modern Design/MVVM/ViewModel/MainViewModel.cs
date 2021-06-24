
using Modern_Design.Core;
using Modern_Design.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Modern_Design.MVVM.ViewModel
{

    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand MyProjectsViewCommand { get; set; }
        public RelayCommand SetWindowTitle { get; set; }


        public HomeViewModel HomeVm { get; set; }
        public MyProjectsViewModel MyProjectsVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            MyProjectsVm = new MyProjectsViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => {
                CurrentView = HomeVm;
                
            }
            
            );

            MyProjectsViewCommand = new RelayCommand(o => {
                CurrentView = MyProjectsVm;
            }

            

            );
          
        }
    }

}