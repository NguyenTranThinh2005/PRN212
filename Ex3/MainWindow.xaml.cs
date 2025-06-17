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

namespace Ex3
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

        private void BtnGui_Click(object sender, RoutedEventArgs e)
        {
            string binhChon = "";
            if (rbRatTot.IsChecked == true)
            {
                binhChon = rbRatTot.Content + " ";
            }
            else if (rbCungTot.IsChecked == true)
            {
                binhChon = rbCungTot.Content + " ";
            }
            else if (rbTamDuoc.IsChecked == true)
            {
                binhChon = rbTamDuoc.Content + " ";

            }
            else if (rbKhoNoi.IsChecked == true)
            {
                binhChon = rbKhoNoi.Content + " ";
            }
            string gioitinh = "";
            if (rbNam.IsChecked == true)
            {
                gioitinh = rbNam.Content + " ";
            }
            else if (rbNu.IsChecked == true)
            {
                gioitinh = rbNu.Content + " ";
            }
            string infor = "Bình chọn hệ thống : " + binhChon + Environment.NewLine;
            infor += "Giới tính: " + gioitinh;

            MessageBoxResult ret;
            ret = MessageBox.Show(infor, "Mời bạn xác nhận",
                                 MessageBoxButton.YesNo,
                                 MessageBoxImage.Question);

            if (ret == MessageBoxResult.Yes)
            {

            }
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}