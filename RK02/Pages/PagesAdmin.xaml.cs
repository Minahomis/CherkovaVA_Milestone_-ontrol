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

namespace RK02.Pages
{
    /// <summary>
    /// Interaction logic for PagesAdmin.xaml
    /// </summary>
    public partial class PagesAdmin : Page
    {
        public PagesAdmin(int status)
        {
            if (status == 1)
            {
                MessageBox.Show("Добро пожаловать! Вы вошли, как гость");
            }
            else
            {
                MessageBox.Show("Добро пожаловать!");
            }
                InitializeComponent();
        }
    }
}
