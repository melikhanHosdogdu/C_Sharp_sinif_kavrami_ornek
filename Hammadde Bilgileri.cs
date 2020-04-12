using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class Hammadde_Bilgileri
    {
     
        public string hammadde_adi;
        private int Hammadde_miktari;
        public string hammadde_barkod_no;
        public string tedarikci;
        public DateTime satin_alinma_tarihi;
        public int hammadde_miktari
        {
            get { return Hammadde_miktari; }
            set
            {
                if (value < 100)  Console.WriteLine("Hammadde miktarı 100 kg den az olamaz");
                else Hammadde_miktari = value;

            }
        }
        public Hammadde_Bilgileri(string ad,int miktar,string barkod_no,string tedarikci_bilgi,DateTime tarih)
        {
            hammadde_adi = ad;
            Hammadde_miktari = miktar;
            hammadde_barkod_no = barkod_no;
            tedarikci = tedarikci_bilgi;
            satin_alinma_tarihi = tarih;


        }

        public void hammadde_bilgileri()
        {
            Console.WriteLine("Hammadde Adı:"+hammadde_adi);
            Console.WriteLine("Hammadde Miktarı:"+Hammadde_miktari);
            Console.WriteLine("Hammadde barkod no:"+hammadde_barkod_no);
            Console.WriteLine("Hammadde tedarikçisi"+tedarikci);
            Console.WriteLine("Hammadde alıs tarihi"+satin_alinma_tarihi);
        }

        

    }
}
