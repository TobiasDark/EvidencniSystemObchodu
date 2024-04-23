using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Položka> Polozka { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Polozka = new();
            seznam.ItemsSource = Polozka;
        }


        private void Dialog_Closing(object? sender, EventArgs e)
        {
            seznam.ItemsSource = null;
            seznam.ItemsSource = Polozka;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddWindow dialog = new(Polozka);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Položka? hledany = seznam?.SelectedItem as Položka;
            if (hledany != null)
            {
                EditWindow edit = new EditWindow(hledany);
                edit.Closing += Dialog_Closing;
                edit.ShowDialog();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Položka? info = seznam?.SelectedItem as Položka ?? new Položka(-1, "Nenalezeno", "Nenalezeno", "Nenalezeno" );
            if (seznam.SelectedItem != null)
            {
                MessageBox.Show($"Zobrazení Detailu : ID:{info.Id} Název:{info.Jmeno} Cena:{info.Cena} Pocet:{info.Pocet}");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
                
        }
    }
}