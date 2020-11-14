using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;
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
    /// Логика взаимодействия для Open.xaml
    /// </summary>
    public partial class Open : Window
    {
        public Open()
        {
            InitializeComponent();
        }

        private void Open_Button_Click(object sender, RoutedEventArgs e)
        {
            string way = open_tB_way.Text, name = open_tB_name.Text;

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
                    Process.Start(way + name);
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

            if (open_cB.SelectedIndex == 0)
            {
                open_tB_way.Text = "C:\\Users\\Dima\\Desktop\\";
            }
            if (open_cB.SelectedIndex == 1)
            {
                open_tB_way.Text = "D:\\Tools\\";
            }
            if (open_cB.SelectedIndex == 2)
            {
                open_tB_way.Text = "D:\\Games\\";
            }
            if (open_cB.SelectedIndex == 3)
            {
                open_tB_way.Text = "D:\\Games_Install\\";
            }
        }
    }
}