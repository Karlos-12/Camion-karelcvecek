using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Camion
{
    internal class Camion1
    {
        public int maxcarry { get;}
        public int maxfuel { get;}
        public int consum { get;}

        public int distance { get;}


        public int curentcarry { get; set; }
        public int curentfuel { get; set; }

        public Camion1(int nosnost,int velnadr,int spotreba)
        {
            maxcarry = nosnost;
            maxfuel = velnadr;
            consum = spotreba;
            distance = 0;
            curentcarry = 0;
            curentfuel = 0;
        }

        public void GO(int distance)
        {
            if ((((distance / 100 * consum)/100) * (100 + (curentcarry/(maxcarry/100)))) < curentfuel)
            {
                curentfuel = (((distance / 100 * consum) / 100) * (100 + (curentcarry / (maxcarry / 100))));
            }
            else
            {
                MessageBox.Show("Nemáš dost paliva hhochu!");   
            }
        }


    }
}
