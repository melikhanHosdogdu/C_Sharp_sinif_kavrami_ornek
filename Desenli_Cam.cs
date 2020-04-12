using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class Desenli_Cam:Cam
    {
        public string desen;

        public Desenli_Cam(string ad,DateTime tarih,string en_boy,int fiyat,string desen):base(ad,tarih,en_boy,fiyat)
        {
            this.desen = desen; 
        }

        public override void cam_listele()
        {
            base.cam_listele();
            Console.WriteLine("Desen: " +desen);
        }
    }
}
