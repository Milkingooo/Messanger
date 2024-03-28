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

namespace Messanger
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == "admin" && PassBox.Password == "admin")
            {
                Open(ContactScreen);
            }
            else
            {
                Warning.Text = " Ty invalid";
                Warning.Visibility = Visibility.Visible;
            }
        }
        private void Open(Border screen)
        {
            LoginScreen.Visibility = Visibility.Hidden;
            screen.Visibility = Visibility.Visible;
        }

        private void ContactsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Метод вызывается, когда меняется индекс выделенного элемента
            //При выделении элемент списка будет подсвечиваться
            //Чтобы убрать это, мы будем менять индекс на -1
            //Чтобы метод не срабатывал повторно, мы проверяем, чтобы индекс был больше или равен 0
            if (ContactsList.SelectedIndex >= 0)
            {
                //Тут будет код загрузки сообщений из чата

                //Сбрасываем индекс
                ContactsList.SelectedIndex = -1;

                Open(ChatScreen);
            }
        }
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {

            string text = "";

            if (!string.IsNullOrEmpty(MessageBox.Text))
            {

                text = MessageBox.Text.Trim();
            }

            if (!string.IsNullOrEmpty(text))
            {

                bool result = true;

                if (result)
                {
                    MessageBox.Text = "";
                }

            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Open(ContactScreen);
        }
    }
}
