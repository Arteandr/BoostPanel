using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BoostPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DraggablePanel_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        

    }
}