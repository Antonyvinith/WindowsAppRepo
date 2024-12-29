using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;


namespace WpfApp1
{
    
    public partial class MainWindow : Window

        
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object Sender,RoutedEventArgs e)
        {
            Trace.WriteLine('A Log message here')
        }
        

        
    }
}