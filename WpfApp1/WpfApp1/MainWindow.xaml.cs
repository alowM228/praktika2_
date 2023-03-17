using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp1.sq1DataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        studentTableAdapter sq2 = new studentTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            Aqw.ItemsSource = sq2.GetData();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sq2.InsertQuery(NameTbx.Text, NameTbx1.Text, NameTbx2.Text, Convert.ToInt32(NameTbx3.Text));

            Aqw.ItemsSource = sq2.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
            
        }



    }
}
