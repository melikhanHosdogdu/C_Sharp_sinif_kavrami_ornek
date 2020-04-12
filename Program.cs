using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class Program
    {
        public static int menu()
        {
            int secim = 0;
            Console.Clear();
            Console.WriteLine("1--Ham Cam Ekle ");
            Console.WriteLine("2--İşlenmiş Cam Ekle ");
            Console.WriteLine("3--Cam Sat");
            Console.WriteLine("4--Hammadde Ekle");
            Console.WriteLine("5--Tedarikçi Listele");
            Console.WriteLine("6--Müşteri Listele");
            Console.WriteLine("7--Camları Listele");
            Console.WriteLine("8--Cıkıs");
            Console.Write("Seciminiz ::");
            secim = int.Parse(Console.ReadLine());
            return secim;
        }//menü methodu


        static void Main(string[] args)



        {
            #region diziler
            Musteri_bilgileri[] dizi_musteri = new Musteri_bilgileri[100];//müsteri kayıt edilecek dizi tanımlanıyor
            int musreti_say = 0;//müşteri sayısı tutacak değişken

            Hammadde_Bilgileri[] dizi_hammadde = new Hammadde_Bilgileri[100];//hammadde kayıt edilecek dizi tanımlanıyor
            int hammadde_say = 0;//hammadde sayısı tutacak değişken

            Tedarikci_bilgileri[] dizi_tedarikci = new Tedarikci_bilgileri[100];//tedarikçi kayıt edilecek dizi tanımlanıyor
            int tedarikci_say = 0;//tedarikçi sayısı tutacak değişken

            Cam[] dizi_cam = new Cam[100];//cam kayıt edilecek dizi tanımlanıyor
            int cam_say = 0;//cam sayısı tutacak değişken
            int toplam_hammadde = 0;
            #endregion
            bool dongu = true;//dongu degiskeni
            do
            {
                int menu_secim = menu();//menü methodu cağırılıyor

                switch (menu_secim)
                {
                    case 1://Ham Cam Ekle
                        #region secim 1
                        Console.Clear();
                    secim_1:
                        if (toplam_hammadde < 100)
                        {
                            Console.WriteLine("Yetersiz Hammadde");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("--Ham Cam Ekle--");
                        Console.WriteLine("Boyut Seciniz:");
                        Console.WriteLine("1)20x30");
                        Console.WriteLine("2)40x60");
                        Console.WriteLine("3)80x120");
                        Console.Write("Seciminiz::");
                        string boyut;
                        int ham_secim = int.Parse(Console.ReadLine());//kullanıcıdan bilgi alınıyor

                        if (ham_secim == 1) { boyut = "20x30"; toplam_hammadde = toplam_hammadde - 20; }
                        else if (ham_secim == 2) { boyut = "40x60"; toplam_hammadde = toplam_hammadde - 40; }
                        else if (ham_secim == 3) { boyut = "60x120"; toplam_hammadde = toplam_hammadde - 60; }
                        else goto secim_1;

                        Console.Write("Fiyat Giriniz:");
                        int h_fiyat = int.Parse(Console.ReadLine());
                        DateTime h_c_tarih = DateTime.Now;
                        Console.Write("İşlem Tarihi :  " + h_c_tarih);
                        dizi_cam[cam_say++] = new Cam("Ham Cam", h_c_tarih, boyut, h_fiyat);//yeni cam nesnesi oluşturulup diziye atılıyor

                        #endregion  

                        break;

                    case 2://İşlenmiş Cam Ekle
                        #region secim 2
                        Console.Clear();
                        if (toplam_hammadde < 100)
                        {
                            Console.WriteLine("Yetersiz Hammadde");
                            Console.ReadKey();
                            break;
                        }

                    secim_2:
                        Console.WriteLine("--İşlenmiş Cam Ekle--");
                        Console.WriteLine("--En Boy Bilgilerini Seciniz--");
                        Console.WriteLine("1)20x30 ");
                        Console.WriteLine("2)40x60");
                        Console.WriteLine("3)80x120");
                        Console.Write("Seciminiz::");
                        string desenli_boyut;
                        int desenli_secim = int.Parse(Console.ReadLine());

                        if (desenli_secim == 1) { desenli_boyut = "20x30"; toplam_hammadde = toplam_hammadde - 20; }
                        else if (desenli_secim == 2) { desenli_boyut = "40x60"; toplam_hammadde = toplam_hammadde - 40; }
                        else if (desenli_secim == 3) { desenli_boyut = "60x120"; toplam_hammadde = toplam_hammadde - 60; }
                        else { Console.WriteLine("Hatalı Secim Tekrar Girin"); goto secim_2; }

                        Console.WriteLine("--Desen Bilgilerini Seciniz--");
                        Console.WriteLine("1)Buzlu");
                        Console.WriteLine("2)Kare");
                        Console.WriteLine("3)Oval");
                        Console.WriteLine("4)Ücgen");
                        Console.Write("Seciminiz::");
                        int desen_secim = int.Parse(Console.ReadLine());
                        string desen_sekil;

                        if (desen_secim == 1) { desen_sekil = "Buzlu"; }
                        else if (desen_secim == 2) { desen_sekil = "Kare"; }
                        else if (desen_secim == 3) { desen_sekil = "Oval"; }
                        else if (desen_secim == 4) { desen_sekil = "Ücgen"; }
                        else { Console.WriteLine("Hatalı Secim Tekrar Deneyin "); goto secim_2; }

                        Console.Write("Fiyat Giriniz:");
                        int desenli_fiyat = int.Parse(Console.ReadLine());
                        DateTime desenli_c_tarih = DateTime.Now;
                        Console.Write("İşlem Tarihi :  " + desenli_c_tarih);
                        dizi_cam[cam_say++] = new Cam(desen_sekil, desenli_c_tarih, desenli_boyut, desenli_fiyat);//yeni islenmis cam nesnesi oluşturulup diziye atılıyor
                        #endregion
                        break;

                    case 3://Cam Sat
                        #region secim 3
                        Console.Clear();
                        Console.WriteLine("--Cam Sat--");

                        Console.Clear();
                        Console.WriteLine("-------Hazır Camlar-------");
                        for (int i = 0; i < cam_say; i++)
                        {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Ürün Numarası::" + (i + 1));
                            dizi_cam[i].cam_listele();

                        }
                        Console.Write("Seciminiz::");
                        int cam_secim = int.Parse(Console.ReadLine());
                        Array.Clear(dizi_cam, (cam_secim - 1), 1);
                        DateTime satis_tarihi = DateTime.Now;
                        dizi_cam[cam_secim - 1] = new Cam("Bu Ürün Satıldı", satis_tarihi, "", 0);


                        Console.WriteLine("Müşteri Bilgileri");
                        Console.Write("Adi :");
                        string m_ad = Console.ReadLine();
                        Console.Write("Adresi:");
                        string m_adres = Console.ReadLine();
                        Console.Write("Fax:");
                        string m_fax = Console.ReadLine();
                        Console.Write("Gsm:");
                        string m_gsm = Console.ReadLine();
                        Console.Write("Telefon:");
                        string m_telefon = Console.ReadLine();
                        Console.Write("Mail Adresi:");
                        string m_mail = Console.ReadLine();
                        Console.Write("Web Site Adresi:");
                        string m_web_site = Console.ReadLine();
                        Console.Write("Vergi Numarası:");
                        string m_vergi_no = Console.ReadLine();
                        DateTime m_tarih = DateTime.Now;
                        Console.WriteLine("İşlem Tarihi:  " + m_tarih);
                    bakiye:
                        Console.Write("Bakiye:");
                        int bakiye = int.Parse(Console.ReadLine());
                        if (dizi_cam[cam_secim - 1].fiyat > bakiye)
                        {
                            Console.WriteLine("yetersiz bakiye tekrar deneyin"); goto bakiye;//bakiye kontrolü yapılıyor
                        }
                        //müsteri nesnesi oluşturulup diziye atılıyor
                        dizi_musteri[musreti_say++] = new Musteri_bilgileri(m_ad, m_adres, m_fax, m_gsm, m_telefon, m_mail, m_web_site, m_vergi_no, m_tarih, bakiye);

                        Console.WriteLine();
                        #endregion

                        break;

                    case 4://Hammadde Ekle
                        #region secim 4
                        Console.Clear();
                        Console.WriteLine("--Hammadde Ekle--");

                        Console.Write("Adı:");
                        string h_ad = Console.ReadLine();

                        Console.Write("Miktarı {100 kgden az olamaz}");
                        int miktar = int.Parse(Console.ReadLine());

                        Console.Write("Barkod No");
                        string h_borkod_no = Console.ReadLine();
                        DateTime t_tarih = DateTime.Now;
                        Console.WriteLine("İşlem Tarih:  " + t_tarih);
                        DateTime son_tarih = t_tarih;

                        Console.WriteLine("--Tedarikci Bilgileri--");

                        Console.Write("Adı: ");
                        string t_ad = Console.ReadLine();
                        string t_bilgi = t_ad;

                        Console.Write("Adresi:");
                        string t_adresi = Console.ReadLine();

                        Console.Write("Fax:");
                        string t_fax = Console.ReadLine();

                        Console.Write("Gsm:");
                        string t_gsm = Console.ReadLine();

                        Console.Write("Telefon:");
                        string t_telefon = Console.ReadLine();

                        Console.Write("Mail Adresi:");
                        string t_mail = Console.ReadLine();

                        Console.Write("Web Site Adresi:");
                        string t_web_site = Console.ReadLine();

                        Console.Write("Vergi Numarası:");
                        string t_vergi_no = Console.ReadLine();

                        //tedarikçi nesnesi oluşturulup diziye atılıyor
                        dizi_tedarikci[tedarikci_say++] = new Tedarikci_bilgileri(t_ad, t_adresi, t_fax, t_gsm, t_telefon, t_mail, t_web_site, t_vergi_no, son_tarih);
                        //hammadde nesnesi oluşturulup diziye atılıyor
                        dizi_hammadde[hammadde_say++] = new Hammadde_Bilgileri(h_ad, miktar, h_borkod_no, t_bilgi, t_tarih);
                        Console.ReadKey();

                        for (int i = 0; i < hammadde_say; i++)
                        {
                            toplam_hammadde = dizi_hammadde[i].hammadde_miktari;
                        }
                        #endregion
                        break;

                    case 5://Tedarikçi Listele
                        #region secim 5
                        Console.Clear();
                        for (int i = 0; i < tedarikci_say; i++)
                        {
                            dizi_tedarikci[i].tedarikci_listele();
                            Console.WriteLine("------------------------------");
                            Console.ReadKey();
                        }
                        #endregion
                        break;

                    case 6://Müşteli Listele
                        #region secim 6
                        Console.Clear();
                        for (int i = 0; i < musreti_say; i++)
                        {
                            dizi_musteri[i].musteri_listele();

                            Console.WriteLine("############################");
                        }


                        Console.ReadKey();
                        #endregion
                        break;

                    case 7://Camları listele
                        #region secim 7
                        Console.Clear();
                        for (int i = 0; i < cam_say; i++)
                        {
                            dizi_cam[i].cam_listele();
                            Console.WriteLine("################");
                        }
                        Console.ReadKey();
                        #endregion
                        break;

                    case 8://Çıkıs
                        Console.Clear();
                        Console.WriteLine("Cıkıs yaptınız");
                        dongu = false;
                        break;
                }
            } while (dongu);
            Console.ReadKey();
        }
    }
}
