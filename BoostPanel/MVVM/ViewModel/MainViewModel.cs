using BoostPanel.Core;

namespace BoostPanel.MVVM.ViewModel
{
    public class MainViewModel: ObservableObject
    {
        public RelayCommand WingmanViewCommand { get; set; }
        
        public RelayCommand SettingsViewCommand { get; set; }
        public RelayCommand CompetitiveViewCommand { get; set; }
        private WingmanViewModel WingmanVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }


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
            SettingsVM = new SettingsViewModel();
            
            // Default screen
            CurrentView = SettingsVM;

            WingmanViewCommand = new RelayCommand(o =>
            {
                CurrentView = WingmanVM;
            });
            
            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVM;
            });
            

        }
    }
}