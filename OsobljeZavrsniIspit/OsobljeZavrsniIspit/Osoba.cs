using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OsobljeZavrsniIspit
{
    internal class Osoba
    {
        string ime, prezime, zanimanje, filter, aktivnost;

        public Osoba(string ime, string prezime, string zanimanje, string filter, string aktivnost)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.zanimanje = zanimanje;
            this.filter = filter;
            this.aktivnost = aktivnost;
        }

        public override string ToString()
        {
            string ispis = "Ime: " + this.ime
                + "\tPrezime: " + this.prezime
                + "\tZanimanje: " + this.zanimanje
                + "\tAktivnost: " + this.aktivnost
                + "\r\n";
            return ispis;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Zanimanje { get => zanimanje; set => zanimanje = value; }
        public string Filter { get => filter; set => filter = value; }
        public string Aktivnost { get => aktivnost; set => aktivnost = value;}
    }
}
