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
using System.Windows.Shapes;

namespace The_organizers_of_the_BOO__quests.View
{
    /// <summary>
    /// Логика взаимодействия для AutorizatinonWindow.xaml
    /// </summary>
    public partial class AutorizatinonWindow : Window
    {
        public AutorizatinonWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            //string login = LoginBox.Text;
            //string password = PasswordBox.Password;

            //if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            //{
            //    MessageBox.Show("Заполните все поля!", "Ошибка",
            //                    MessageBoxButton.OK, MessageBoxImage.Warning);
            //    return;
            //}

            //MessageBox.Show($"Попытка входа: {login}", "Информация");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow regWindow = new RegistrationWindow();
            regWindow.Show();
            this.Close();
        }
    }
}
