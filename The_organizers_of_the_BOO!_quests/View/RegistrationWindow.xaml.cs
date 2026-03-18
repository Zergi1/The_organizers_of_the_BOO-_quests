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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void BackToLoginBtn_Click(object sender, RoutedEventArgs e)
        {
            AutorizatinonWindow autoWindow = new AutorizatinonWindow();
            autoWindow.Show();
            this.Close();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            //string fullName = FullNameBox.Text;
            //string nickname = NicknameBox.Text;
            //string email = EmailBox.Text;
            //string employeeCode = EmployeeCodeBox.Text;
            //string password = PasswordBox.Password;
            //string confirm = ConfirmPasswordBox.Password;

            //if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(nickname) ||
            //    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
            //    string.IsNullOrEmpty(confirm))
            //{
            //    MessageBox.Show("Заполните все обязательные поля (ФИО, Никнейм, Почта, Пароль, Подтверждение)!",
            //                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            //    return;
            //}

            //if (password != confirm)
            //{
            //    MessageBox.Show("Пароли не совпадают!", "Ошибка",
            //                    MessageBoxButton.OK, MessageBoxImage.Warning);
            //    return;
            //}

            //string message = $"Регистрация прошла успешно, {nickname}!";
            //if (!string.IsNullOrEmpty(employeeCode))
            //    message += $"\nКод сотрудника: {employeeCode}";

            //MessageBox.Show(message, "Ура!");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
