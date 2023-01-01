using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamestnanec_Vedoucí
{
    internal class Vedouci : Zamestnanec
    {
        private int priplatekZaVedeni;
        private string titul;
        public Vedouci(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda, int priplatekZaVedeni, string titul)
          :  base(jmeno, prijmeni, datumNastupu, hodinovaMzda)
        {

            this.priplatekZaVedeni = priplatekZaVedeni;
            this.titul = titul;

        }

        public override string VypoctiMzdu()
        {
            int mzda = hodinovaMzda * odpracHodiny;
            odpracHodiny = 0;
            mzda = mzda + priplatekZaVedeni;
            return "" + mzda;
        }
        public override string? ToString()
        {
            return " Vedoucí: " +titul+" "+ jmeno +" " + prijmeni + "\nkterý nastoupil: " + datumNastupu + "\ns mzdou na hodinu: " + hodinovaMzda +" kč" + "\nodpracovanými hodinami: " + odpracHodiny;
        }
    }
}
