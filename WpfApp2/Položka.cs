using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Položka
    {
        public Položka(int id, string jmeno, string pocet, string cena /*TypPoložky typ*/)
        {
            Id = id;
            Jmeno = jmeno;
            Pocet = pocet;
            Cena = cena;
            //Typ = typ;
        }

        public int? Id { get; set; }
        public string Jmeno { get; set; }
        public string Pocet { get; set; }

        public string Cena { get; set; }
        //public TypPoložky Typ { get; set; }

        public override string ToString()
        {
            return $"{Jmeno} {Pocet} {Cena} ";
        }
    }
}
