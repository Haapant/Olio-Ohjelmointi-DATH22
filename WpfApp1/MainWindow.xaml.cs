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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Opiskelija> Opiskelija = new List<Opiskelija>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_LuoOpiskelija_Click(object sender, RoutedEventArgs e)
        {
            Opiskelija uusiOpiskelija = new Opiskelija();

            uusiOpiskelija.Nimi = Input_Nimi.Text;
            uusiOpiskelija.OpiskelijaId = Input_OpiskelijaId.Text;
            uusiOpiskelija.Opintopisteet = int.Parse(Input_Opintopisteet.Text);

            Input_Nimi.Text = "";
            Input_OpiskelijaId.Text = "";
            Input_Opintopisteet.Text = "";

            TXT_Lopputulos.Text = "Opiskelijan tiedot:\n" + uusiOpiskelija.HaeTiedot();
            Opiskelija.Add(uusiOpiskelija);
        }
    }
}
