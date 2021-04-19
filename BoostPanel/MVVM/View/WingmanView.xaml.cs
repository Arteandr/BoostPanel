using BoostPanel.MVVM.ViewModel;
using System.Windows.Controls;

namespace BoostPanel.MVVM.View
{
    public partial class WingmanView : UserControl
    {
        public WingmanView()
        {
            InitializeComponent();
        }

        private void AccountsLoadButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            WingmanViewModel.modelAccountsUpload();
        }
    }
}