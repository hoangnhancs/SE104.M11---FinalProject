using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bookStoreManagetment
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
        private void hiddenSubMenu(StackPanel stkPanel)
        {
            if (stkPanel.Visibility != Visibility.Visible)
            {
                stkPanel.Visibility = Visibility.Visible;
            }
            else
            {
                stkPanel.Visibility = Visibility.Collapsed;
            }
        }
        private void btnQLVatPham_Click(object sender, RoutedEventArgs e)
        {
            hiddenSubMenu(stackPanelSubMenuQLVP);
        }

        private void btnBanVatPham_Click(object sender, RoutedEventArgs e)
        {
            hiddenSubMenu(stackPanelSubMenuBanVP);
        }

        private void btnQLNhanVien_Click(object sender, RoutedEventArgs e)
        {
            hiddenSubMenu(stackPanelSubMenuQLNV);
        }

        private void btnQLKhachHang_Click(object sender, RoutedEventArgs e)
        {
            hiddenSubMenu(stackPanelSubMenuQLKH);
        }

        private void btnQLThuChi_Click(object sender, RoutedEventArgs e)
        {
            hiddenSubMenu(stackPanelSubMenuQLThuChi);
        }
    }
}
