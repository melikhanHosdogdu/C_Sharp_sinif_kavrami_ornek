using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class Tedarikci_bilgileri
    {
        public string tedarikci_adi;
        public string tedarikci_adres;
        public string tedarikci_fax;
        public string tedarikci_gsm;
        public string tedarikci_telefon;
        public string tedarikci_mail_adresi;
        public string tedarikci_web_site_linki;
        public string tedarikci_vergi_numarasi;
        public DateTime tedarikci_son_sipariş_tarihi;


        public Tedarikci_bilgileri(string ad,string adres,string fax,string gsm,string telefon, string mail,string web_site,string vergi_no,DateTime son_siparis_tarihi)
        {
            tedarikci_adi = ad;
            tedarikci_adres = adres;
            tedarikci_fax = fax;
            tedarikci_gsm = gsm;
            tedarikci_telefon = telefon;
            tedarikci_mail_adresi = mail;
            tedarikci_web_site_linki = web_site;
            tedarikci_vergi_numarasi = vergi_no;
            tedarikci_son_sipariş_tarihi = son_siparis_tarihi;

        }

        public void tedarikci_listele()
        {
            Console.WriteLine("Adı:"+tedarikci_adi);
            Console.WriteLine("Adres:"+tedarikci_adres);
            Console.WriteLine("Fax:"+tedarikci_fax);
            Console.WriteLine("Gsm:"+tedarikci_gsm);
            Console.WriteLine("Telefon:"+tedarikci_telefon);
            Console.WriteLine("Mail:"+tedarikci_mail_adresi);
            Console.WriteLine("Web Site:"+tedarikci_web_site_linki);
            Console.WriteLine("Vergi No:"+tedarikci_vergi_numarasi);
            Console.WriteLine("Son Siparis Tarihi:"+tedarikci_son_sipariş_tarihi);

        }
    }

   
}
