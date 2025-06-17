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

namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
    
        }

        private void checkAll_Checked(object sender, RoutedEventArgs e)
        {
            chkCongNghe.IsChecked = true;
            chkDaBong.IsChecked = true;
            chkXemPhim.IsChecked = true;
            chkDuLich.IsChecked = true;
        }

        private void checkAll_Unchecked(object sender, RoutedEventArgs e)
        {
            chkCongNghe.IsChecked = false;
            chkDaBong.IsChecked = false;
            chkXemPhim.IsChecked = false;
            chkDuLich.IsChecked = false;
        }

        private void checkAll_CheckAll(object sender, RoutedEventArgs e)
        {
            if (chkCongNghe.IsChecked == true && chkDaBong.IsChecked == true && chkXemPhim.IsChecked == true && chkDuLich.IsChecked == true)
            {
                chkAll.IsChecked = true;
            } else if (chkCongNghe.IsChecked == true && chkDaBong.IsChecked == true && chkXemPhim.IsChecked == true && chkDuLich.IsChecked == true)
            {
                chkAll.IsChecked=false;
            }
        }

    }
}
