using System;
using System.Collections.Generic;
using System.Text;

namespace RollerKolcsonzo
{
    public class RollerUtazas
    {
        public string FelhasznaloNev {  get; set; }
        public int UtazasIdoPerc { get; set; }
        public double MegtettKm { get; set; }

        public RollerUtazas(string sor)
        {
            string[] darabolt = sor.Split(';');
            FelhasznaloNev = darabolt[0];
            UtazasIdoPerc = int.Parse(darabolt[1]);
            MegtettKm = double.Parse(darabolt[2]);
        }

        public int FizetendoDij()
        {
            return 300 + (UtazasIdoPerc * 60);

        }

        public override string ToString()
        {
            return $"{FelhasznaloNev}: {UtazasIdoPerc} perc, {MegtettKm} km - Fizetendő: {FizetendoDij()} Ft";
        }
    }
}
