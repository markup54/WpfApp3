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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window okno = new WykonajTestWindow();
            //okno.ShowDialog();//okno modalne nic nie można zrobić w tle
            okno.Show(); //okno niemodalne w tle możemy nadal wykonywać inne ...
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window okno = new DodajPytanieWindow();
            okno.Show();
        }
    }
}
