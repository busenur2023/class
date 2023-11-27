using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örn2
{
    internal class Kullanici
    {
        string ad_soyad;
        string telefon;
        string e_posta;
        string şifre;
        string adres;

        public string Ad_soyad { get => ad_soyad; set => ad_soyad = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string E_posta { get => e_posta; set => e_posta = value; }
        public string Şifre { get => şifre; set => şifre = value; }
        public string Adres { get => adres; set => adres = value; }

        public Kullanici(string ad_soyad, string telefon, string e_posta, string şifre, string adres)
        {
            this.ad_soyad = ad_soyad;
            this.telefon = telefon;
            this.e_posta = e_posta;
            this.şifre = şifre;
            this.adres = adres;
        }
    }
}
