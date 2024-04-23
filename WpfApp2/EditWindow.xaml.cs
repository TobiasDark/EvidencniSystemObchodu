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

namespace WpfApp2
{
    /// <summary>
    /// Interakční logika pro EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public Položka Z { get; set; }
        public EditWindow(Položka z)
        {
            Z = z;
            InitializeComponent();
            DataContext = Z;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Z.Jmeno = ProJmeno.Text;
            Z.Cena = ProCenu.Text;
            Z.Pocet = ProPocet.Text;

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
