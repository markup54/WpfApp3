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
    /// Logika interakcji dla klasy WykonajTestWindow.xaml
    /// </summary>
    public partial class WykonajTestWindow : Window
    {
        List<Pytanie> PytanieList {get;set;} = new List<Pytanie>();
        int numerPytania { get;set;}
        int LiczbaPunktow { get; set; }
        public WykonajTestWindow()
        {
            InitializeComponent();
            przygotujPytania();
            wyswietlPytanie(0);
        }

        private void wyswietlPytanie(int indeks)
        {
            trescPytanie_textblock.Text = PytanieList[indeks].Tresc;
        }
        private void przygotujPytania()
        {
            PytanieList.Clear();
            StreamReader streamReader = new StreamReader("../../../pytania.txt");
            string trescpytania = streamReader.ReadLine();
            string odpowiedz= streamReader.ReadLine();
            while (trescpytania != null)
            {
                if (odpowiedz == "tak")
                    PytanieList.Add(new Pytanie(trescpytania, true));
                else
                    PytanieList.Add(new Pytanie(trescpytania,false));
                trescpytania = streamReader.ReadLine();
                odpowiedz = streamReader.ReadLine();
            }

            streamReader.Close();
        }

        private void tak_button_Click(object sender, RoutedEventArgs e)
        {
            podliczPytania(true);
        }
        private void podliczPytania(bool odp)
        {
            if (PytanieList[numerPytania].Odpowiedz == odp)
            {
                LiczbaPunktow++;
            }
            numerPytania++;
            if (numerPytania == PytanieList.Count)
            {
                MessageBox.Show("wynik: "+LiczbaPunktow.ToString());
                Close();
            }
            else
            {
                wyswietlPytanie(numerPytania);
            }
        }
        private void nie_button_Click(object sender, RoutedEventArgs e)
        {
            podliczPytania(false);
        }
        
    }
}
