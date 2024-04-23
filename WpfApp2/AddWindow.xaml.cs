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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WpfApp2
{
    /// <summary>
    /// Interakční logika pro AddWindow.xaml
    /// </summary>
     public partial class AddWindow : Window
        {
            List<Položka> _polozka;
            public AddWindow(List<Položka> polozka)
            {
                _polozka = polozka;
                InitializeComponent();
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }

            private int VytvorId() => _polozka.Count + 1;

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                string jmeno = ProNazev.Text;
                string cena = ProCena.Text;
                string pocet = ProPocet.Text;
                //TypPoložky typ = TypPoložky.Text;



                Položka Novy = new Položka(VytvorId(), jmeno, cena, pocet /*typ*/);
                _polozka.Add(Novy);

                

                this.Close();
            }
        }

}
