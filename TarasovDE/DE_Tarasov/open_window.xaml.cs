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
using _db = DE_Tarasov.DEEntities;

namespace DE_Tarasov
{
    /// <summary>
    /// Логика взаимодействия для open_window.xaml
    /// </summary>
    public partial class open_window : Window
    {
        public open_window()
        {
            InitializeComponent();
            dgProduct.ItemsSource = DEEntities.GetContext().product.ToList();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var productremove = dgProduct.SelectedItems.Cast<product>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {productremove.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    _db.GetContext().product.RemoveRange(productremove);
                    _db.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dgProduct.ItemsSource = _db.GetContext().product.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
