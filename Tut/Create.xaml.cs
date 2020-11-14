using System;
using System.Collections.Generic;
using System.IO;
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

namespace Tut
{
    /// <summary>
    /// Логика взаимодействия для Create.xaml
    /// </summary>
    public partial class Create : Window
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            string way = create_tB_way.Text, name = create_tB_name.Text;

            if ( way == "" || name == "" )
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
                    File.Create(way + name);
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
            if (create_cB.SelectedIndex == 0)
            {
                create_tB_way.Text = "C:\\Users\\Dima\\Desktop\\";
            }
            if (create_cB.SelectedIndex == 1)
            {
                create_tB_way.Text = "D:\\Tools\\";
            }
            if (create_cB.SelectedIndex == 2)
            {
                create_tB_way.Text = "D:\\Games\\";
            }
            if (create_cB.SelectedIndex == 3)
            {
                create_tB_way.Text = "D:\\Games_Install\\";
            }
        }
    }
}
