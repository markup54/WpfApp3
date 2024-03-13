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

namespace WpfApp3
{
    /// <summary>
    /// Logika interakcji dla klasy DodajPytanieWindow.xaml
    /// </summary>
    public partial class DodajPytanieWindow : Window
    {
        public DodajPytanieWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tresc = Tresc_pytania.Text;
           string odp;
            if(odp_tak.IsChecked == true) {
                odp = "tak";
            }
            else
            {
                odp = "nie";
            }
            StreamWriter streamWriter = new StreamWriter("../../../pytania.txt", true);
            streamWriter.WriteLine(tresc);
            streamWriter.WriteLine(odp);
            streamWriter.Close();
        }
    }
}
