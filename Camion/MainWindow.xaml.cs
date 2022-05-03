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
        Camion redcamion;
        Camion bluecamion;
        public MainWindow()
        {
            InitializeComponent();
            redcamion = new Camion(250, 125, 25);
            bluecamion = new Camion(275, 100, 35);
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
            { swa = 1; }
            else
            { swa = 0; }
        }

        public void write()
        {

        }
    }
}
