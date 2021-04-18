using BoostPanel.Core;

namespace BoostPanel.MVVM.ViewModel
{
    public class MainViewModel: ObservableObject
    {
        public RelayCommand WingmanViewCommand { get; set; }
        public RelayCommand CompetitiveViewCommand { get; set; }
        public WingmanViewModel WingmanVM { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            WingmanVM = new WingmanViewModel();
            CurrentView = WingmanVM;

            WingmanViewCommand = new RelayCommand(o =>
            {
                CurrentView = WingmanVM;
            });

        }
    }
}