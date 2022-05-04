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

        public void GO(int distance1)
        {
            if ((((distance1 / 100 * consum)) + (25* (curentcarry/maxcarry))) < curentfuel)
            {
                curentfuel -= ((((distance1 / 100) * consum)) + (25 *(curentcarry / maxcarry)));
                distance += distance1;
            }
            else
            {
                MessageBox.Show("Nemáš dost paliva hhochu!");   
            }
        }

        public void tanko(int litr)
        {
            if(curentfuel + litr > maxfuel)
            {
                MessageBox.Show("Přeteklo to more!");
                curentfuel = maxfuel;
            }
            else
            {
                curentfuel += litr;
            }
        }

        public void naklo(int nakld)
        {
            if(maxcarry < nakld + curentcarry)
            {
                MessageBox.Show("More ti praskne náprava!");
            }
            else
            {
                curentcarry += nakld;
            }
        }
        
        public void vyklo(int vkld)
        {
            if(vkld > curentcarry)
            {
                MessageBox.Show("A co chceč jako vykládat?");
            }
            else
            {
                curentcarry -= vkld;
            }
        }
    }
}
