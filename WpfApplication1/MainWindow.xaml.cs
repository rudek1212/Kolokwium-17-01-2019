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
using System.ComponentModel;
using System.IO;



namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //należy dodać źródło dla comboboxa oraz przeładować funkcje zawartościami textboxów za pomocą kontrolka.ToString()
        Serwis serwis = new Serwis();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DodajPralkeButton_Click(object sender, RoutedEventArgs e)
        {
            //serwis.DodajPralke();
        }

        private void DodajLodowkeButton_Click(object sender, RoutedEventArgs e)
        {
            //serwis.DodajLodowke();
        }

        private void RaportButton_Click(object sender, RoutedEventArgs e)
        {
            serwis.GenerujRaport();
        }

        private void NaprawaButton_Click(object sender, RoutedEventArgs e)
        {
            serwis.Napraw();
        }

        private void NaprawaPoNrButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
