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
        public Vedouci(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda, int priplatekZaVedeni,string titul)
        {
                
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.hodinovaMzda = hodinovaMzda;
            this.priplatekZaVedeni = priplatekZaVedeni;
            this.titul = titul;

        }
        
        public override string VypoctiMzdu()
        {
            int mzda = hodinovaMzda * odpracHodiny;
            mzda = mzda + priplatekZaVedeni;
            return "" + mzda;
        }
    }
}
