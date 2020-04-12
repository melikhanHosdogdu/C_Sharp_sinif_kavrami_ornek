using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class Cam
    {
        public string adi;
        public DateTime tarihi;
        public string en_x_boy;
        public int fiyat;

        public Cam(string ad,DateTime tarih,string en_boy,int fiyat)
        {
            adi = ad;
            tarihi = tarih;
            en_x_boy = en_boy;
            this.fiyat = fiyat;
        }

        public virtual void cam_listele()
        {
            Console.WriteLine("Adı:"+adi);
            Console.WriteLine("Tarih:"+tarihi);
            Console.WriteLine("En x Boy:"+en_x_boy);
            Console.WriteLine("Fiyat:"+fiyat);
        }
    }
}
