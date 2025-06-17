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

namespace WPFList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int>  dsDuLieu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsDuLieu.Add(x);
            HienDanhSach();
            txtGiaTri.Text = "";

        }
        void HienDanhSach()
        {
            DuLieu1st.Items.Clear();
            for(int i = 0; i < dsDuLieu.Count; i++) {
                int x = dsDuLieu[i];
                DuLieu1st.Items.Add(x);
            }

        }

        private void btnChen_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTriChen.Text);
            int position = int.Parse(txtViTriChen.Text);
            dsDuLieu.Insert(position, x);
            HienDanhSach();
            txtGiaTriChen.Text = "";
            txtViTriChen.Text = "";
        }
        private void btnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienDanhSach();
        }
        private void btnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            HienDanhSach();
        }
        private void btnXoa1_Click(object sender, RoutedEventArgs e)
        {
            if (DuLieu1st.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn phần tử để xóa", "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            dsDuLieu.RemoveAt(DuLieu1st.SelectedIndex);
            HienDanhSach() ;
        }
        private void btnXoaNhieu_Click(object sender, RoutedEventArgs e)
        {
            if (DuLieu1st.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn phần tử để xóa", "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            while(DuLieu1st.SelectedItems.Count > 0)
            {
                int data = (int)DuLieu1st.SelectedItems[0];
                dsDuLieu.Remove(data);
            }
        }
        private void btnXoaHet_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienDanhSach();
        }

    }
}