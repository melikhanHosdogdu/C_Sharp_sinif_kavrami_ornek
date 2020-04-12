using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class Musteri_bilgileri
    {
        public string musteri_adi;
        public string musteri_adres;
        public string musteri_fax;
        public string musteri_gsm;
        public string musteri_telefon;
        public string musteri_mail_adresi;
        public string musteri_web_site_linki;
        public string musteri_vergi_numarasi;
        public DateTime musteri_son_sipariş_tarihi;
        public int musteri_bakiye;

        public Musteri_bilgileri(string ad,string adres,string fax,string gsm,string telefon,string mail,string web_site_link,string vergi_no,DateTime son_siparis_tarihi,int bakiye )
        {
            musteri_adi = ad;
            musteri_adres = adres;
            musteri_fax = fax;
            musteri_gsm = gsm;
            musteri_telefon = telefon;
            musteri_mail_adresi = mail;
            musteri_web_site_linki = web_site_link;
            musteri_vergi_numarasi = vergi_no;
            musteri_son_sipariş_tarihi = son_siparis_tarihi;
            musteri_bakiye = bakiye;
        }
        public void musteri_listele()
        {
            Console.WriteLine("Adı:"+musteri_adi);
            Console.WriteLine("Adres:"+musteri_adres);
            Console.WriteLine("Fax:"+musteri_fax);
            Console.WriteLine("Gsm:"+musteri_gsm);
            Console.WriteLine("Telefon:"+musteri_telefon);
            Console.WriteLine("Mail:"+musteri_mail_adresi);
            Console.WriteLine("Web Site Linki:"+musteri_web_site_linki);
            Console.WriteLine("Vergi _No:"+musteri_vergi_numarasi);
            Console.WriteLine("Son Siparis Tarihi:"+musteri_son_sipariş_tarihi);
        }
    }
}
