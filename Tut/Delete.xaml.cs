using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.IO;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tut
{
    /// <summary>
    /// Логика взаимодействия для Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            string way = delete_tB_way.Text, name = delete_tB_name.Text;

            if (way == "" || name == "")
            {
                MessageBox.Show("You don't write way or name.",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error,
                    MessageBoxResult.OK);

            }
            else
            {
                try
                {
                    File.Delete(way + name);
                }
                catch
                {
                    MessageBox.Show("You entered the data incorrectly. Please try again.",
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error,
                        MessageBoxResult.OK);
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (delete_cB.SelectedIndex == 0)
            {
                delete_tB_way.Text = "C:\\Users\\Dima\\Desktop\\";
            }
            if (delete_cB.SelectedIndex == 1)
            {
                delete_tB_way.Text = "D:\\Tools\\";
            }
            if (delete_cB.SelectedIndex == 2)
            {
                delete_tB_way.Text = "D:\\Games\\";
            }
            if (delete_cB.SelectedIndex == 3)
            {
                delete_tB_way.Text = "D:\\Games_Install\\";
            }
        }
    }
}