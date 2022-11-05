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
using _db = DE_Tarasov.DEEntities;

namespace DE_Tarasov
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

        private void tblGuest_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new open_window().Show();
            Hide();
        }

        private void btnAutorizaton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < _db.GetContext().users.Count(); i++)
            {
                if (tbLogin.Text == _db.GetContext().users.ToList()[i].login &&
                    tbPassword.Text == _db.GetContext().users.ToList()[i].password)
                {
                    MessageBox.Show("Успешная авторизация!");
                    if (_db.GetContext().users.ToList()[i].Role == "Администратор")
                    {
                        new open_window().Show();
                        this.Hide();
                    }
                    else if (_db.GetContext().users.ToList()[i].Role == "Менеджер")
                    {
                        new open_window().Show();
                        this.Hide();
                    }
                    else if (_db.GetContext().users.ToList()[i].Role == "Клиент")
                    {
                        new open_window().Show();
                        this.Hide();
                    }
                }

            }
            
        }
    }
}
