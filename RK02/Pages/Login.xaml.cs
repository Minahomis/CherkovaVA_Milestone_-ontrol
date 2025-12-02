using MovieCatalogApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = FakeDatabase.GetContext();
            // var db = Helper.Get();
            var adms = db.Users.Where(a => a.Username == tbLogin.Text).ToList();

            if (adms.Count >= 1)
            {
                var adm = adms[0];
                if (adm.Password == tbPassword.Password)
                {
                    if (adm.RoleId == 1)
                    {
                        int status = 0;
                        NavigationService.Navigate(new PagesAdmin(status));
                    }
                    else if (adm.RoleId == 2)
                    {
                        MessageBox.Show(adm.Username);
                        //NavigationService.Navigate(new MainPage());
                    }
                    else
                        MessageBox.Show("Ваша роль не имеет прав доступа к другим страницам", "Нет доступа", MessageBoxButton.OK, MessageBoxImage.Information);


                }
                else
                    MessageBox.Show("Неверный пароль", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Пользователь не найден", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void tbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_Guest(object sender, RoutedEventArgs e)
        {
            int status = 1;
            NavigationService.Navigate(new PagesAdmin(status));
        }
    }
}
