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
        private Button btnIsClick = new Button();
        private StackPanel spnIsVisiable = new StackPanel();
        public MainWindow()
        {
            InitializeComponent();
            btnIsClick = null;
            spnIsVisiable = null;
        }

        // đổi màu nút đã bấm 
        private void ChangeColorButtonClicked(Button btn,bool isDuplicate = false)
        {
            if (btnIsClick != null)
            {
                btnIsClick.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            }
            if (isDuplicate==false)
            {
                btn.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
            btnIsClick = btn;
        }

        // hàm show/hidden sub menu
        private void hiddenSubMenu(StackPanel stkPanel, Button btn)
        {
            bool isDuplicate = false;
            if (stkPanel.Visibility != Visibility.Visible)
            {
                stkPanel.Visibility = Visibility.Visible;
            }
            else
            {
                isDuplicate = true;
                stkPanel.Visibility = Visibility.Collapsed;
            }

            if(spnIsVisiable != null && spnIsVisiable != stkPanel)
            {
                spnIsVisiable.Visibility = Visibility.Collapsed;
            }
            ChangeColorButtonClicked(btn, isDuplicate);
            spnIsVisiable = stkPanel;
        }

        private void btnQLVatPham_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            hiddenSubMenu(stackPanelSubMenuQLVP,btn);
        }

        private void btnBanVatPham_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            hiddenSubMenu(stackPanelSubMenuBanVP,btn);
        }

        private void btnQLNhanVien_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            hiddenSubMenu(stackPanelSubMenuQLNV,btn);
        }

        private void btnQLKhachHang_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            hiddenSubMenu(stackPanelSubMenuQLKH,btn);
        }

        private void btnQLThuChi_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            hiddenSubMenu(stackPanelSubMenuQLThuChi,btn);
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            ChangeColorButtonClicked(btn);
        }

        private void btnQLBaoCao_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            ChangeColorButtonClicked(btn);
        }

        private void btnQLSuKien_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            ChangeColorButtonClicked(btn);
        }

        private void btnQLMail_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            ChangeColorButtonClicked(btn);
        }

        private void btnCaiDatChung_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            ChangeColorButtonClicked(btn);
        }
    }
}
