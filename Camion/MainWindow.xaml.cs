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

namespace Camion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Camion1 redcamion;
        Camion1 bluecamion;
        public MainWindow()
        {
            InitializeComponent();
            vp.Background = new SolidColorBrush(Color.FromRgb(128, 0, 0));
            redcamion = new Camion1(250, 125, 25);
            bluecamion = new Camion1(275, 100, 35);
            write();
        }

        private void Jet_Click(object sender, RoutedEventArgs e)
        {
            int m = 0;
            try
            { 
                m = int.Parse(jetb.Text); 
            switch(swa)
                {
                    case 0:
                        redcamion.GO(m);
                        break;
                    case 1:
                        bluecamion.GO(m);
                        break;
                }         
            }
            catch {MessageBox.Show("Napiš tam něco normálního, pls!"); }
            write();
        }
        int swa = 0;

        public void sw_Click(object sender, RoutedEventArgs e)
        {
            if(swa == 0)
            { swa = 1;
                vp.Background = new SolidColorBrush(Color.FromRgb(0, 0, 128));
            }
            else
            { swa = 0;
                vp.Background = new SolidColorBrush(Color.FromRgb(128, 0, 0));
            }
            write();
        }

        public void write()
        {
            switch(swa)
            {
                case 0:
                    vp.Text = "Kamion: červenej \nMax váha: " + redcamion.maxcarry + "\nMax palivo: " + redcamion.maxfuel + "\nSpotřeba: " + redcamion.consum + "\nVzdaálenost: " + redcamion.consum + "\nPalivo: " + redcamion.curentfuel + "\nNáklad: " + redcamion.curentcarry;
                    break;
                case 1:
                    vp.Text = "Kamion: modrej \nMax váha: " + bluecamion.maxcarry + "\nMax palivo: " + bluecamion.maxfuel + "\nSpotřeba: " + bluecamion.consum + "\nVzdaálenost: " + bluecamion.consum + "\nPalivo: " + bluecamion.curentfuel + "\nNáklad: " + bluecamion.curentcarry;
                    break;
            }

        }

        private void tnk_Click(object sender, RoutedEventArgs e)
        {
            switch (swa)
            {
                case 0:
                    try { redcamion.tanko(int.Parse(tnkb.Text)); }
                    catch { MessageBox.Show("Napiš tam něco normálního, pls!"); };
                    break;
                case 1:
                    try { bluecamion.tanko(int.Parse(tnkb.Text)); }
                    catch { MessageBox.Show("Napiš tam něco normálního, pls!"); };
                    break;                
            }
            write();
        }

        private void nakl_Click(object sender, RoutedEventArgs e)
        {
            switch (swa)
            {
                case 0:
                    try { redcamion.naklo(int.Parse(nakla.Text)); }
                    catch { MessageBox.Show("Napiš tam něco normálního, pls!"); };
                    break;
                case 1:
                    try { bluecamion.naklo(int.Parse(nakla.Text)); }
                    catch { MessageBox.Show("Napiš tam něco normálního, pls!"); };
                    break;
            }
            write();
        }

        private void vykldd_Click(object sender, RoutedEventArgs e)
        {
            switch (swa)
            {
                case 0:
                    try { redcamion.vyklo(int.Parse(vykld.Text)); }
                    catch { MessageBox.Show("Napiš tam něco normálního, pls!"); };
                    break;
                case 1:
                    try { bluecamion.vyklo(int.Parse(vykld.Text)); }
                    catch { MessageBox.Show("Napiš tam něco normálního, pls!"); };
                    break;
            }
            write();
        }
    }
}
