using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace TarasovDE
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
            Open_window ow = new Open_window();
            ow.Show();
            this.Hide();
        }

        private void btnAutorizaton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
