using System.Net.WebSockets;

namespace ATM_PROJESİ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM'YE HOŞHELDİNİZ");
            Console.WriteLine("KARTLI İŞLEM İÇİN: 1");
            Console.WriteLine("KARTSIZ İŞLMEM İÇİM: 2");

            int secim = Convert.ToInt32(Console.ReadLine());



            if (secim == 1)
            {




                Console.WriteLine("lütfen kart şifrenizi giriniz");

                string password = "ab18";


                int hak = 3;
                while (hak > 0)
                {



                    Console.WriteLine("Şifreniz:");
                    string sifre = Console.ReadLine();

                    hak--;

                    if (sifre == password)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        Console.WriteLine("lütfen yapmak istediğiniz işlemi seçiniz");
                        Console.WriteLine("1:para çekme");
                        Console.WriteLine("2:para yatırma");
                        Console.WriteLine("3:para transferleri");
                        Console.WriteLine("4:eğitim ödemeleri");
                        Console.WriteLine("5:fatura ödemeleri");
                        Console.WriteLine("6:bilgi güncellemeleri");
                        int secim1 = Convert.ToInt32(Console.ReadLine());
                        int bakiye = 50000;
                        if (secim1 == 1)
                        {
                            Console.WriteLine("lütfen çekmek istediğiniz tutarı giriniz");

                            int cekeilecek_tutar = Convert.ToInt32(Console.ReadLine());
                            if (cekeilecek_tutar <= bakiye)
                            {
                                Console.WriteLine("kalan bakiyeniz :" + (bakiye - cekeilecek_tutar));
                                Console.WriteLine("ana menü için: 9");
                                Console.WriteLine("çikiş için: 0");
                                int secim2 = Convert.ToInt32(Console.ReadLine());
                                if (secim2 == 9)
                                {
                                    Console.WriteLine("ana menüye dönülüyor");
                                    continue;

                                }
                                else if (secim2 == 0)
                                {
                                    Console.WriteLine("çıkış yapılıyor");

                                }
                            }
                            else
                            {
                                Console.WriteLine("yetersiz bakiye");
                                Console.WriteLine("ana menü için: 9");
                                Console.WriteLine("çikiş için: 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());
                                if (secim3 == 9)
                                {
                                    Console.WriteLine("ana menüye dönüldü");



                                }
                                if (secim3 == 0)
                                {
                                    Console.WriteLine("çıkış yapıldı");
                                    break;




                                }



                            }

                        }
                        else if (secim1 == 2)
                        {
                            Console.WriteLine("kkartı için: 1");
                            Console.WriteLine("kendi hesabınıza yatırmak için: 2");
                            int hesap_secimi = Convert.ToInt32(Console.ReadLine());
                            if (hesap_secimi == 1)
                            {


                                Console.WriteLine("lütfen 12 haneli kart numaranızı giriniz");
                                long kkartı_ = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("kkartınız: TR" + kkartı_);
                                Console.WriteLine("lütfen yatırmak isteiğiniz tutarı giriniz");
                                int kkartı_yatırılacaktutar = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("kkartınıza: " + kkartı_yatırılacaktutar + (" TL Para yatmıştır"));
                                Console.WriteLine("ana menü için: 9");
                                Console.WriteLine("çikiş için: 0");
                                int secim4 = Convert.ToInt32(Console.ReadLine());

                                if (secim4 == 9)
                                {
                                    Console.WriteLine("ana menüye dönülüyor");
                                    continue;


                                }
                                if (secim4 == 0)
                                {
                                    Console.WriteLine("çıkış yapıldı");
                                    break;


                                }

                            }
                            if (hesap_secimi == 2)
                            {

                                Console.WriteLine("lütfen yatırmak istediğiniz tutarı giriniz");
                                int hesabayatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("yeni bakiyeniz :" + (hesabayatırılacak_tutar + bakiye));
                                Console.WriteLine("ana menü için: 9");
                                Console.WriteLine("çikiş için: 0");
                                int secim5 = Convert.ToInt32(Console.ReadLine());
                                if (secim5 == 9)
                                {
                                    Console.WriteLine("ana menüye dönülüyor");
                                    continue;


                                }
                                if (secim5 == 0)
                                {
                                    Console.WriteLine("çıkış yapıldı");
                                    break;


                                }


                            }
                        }
                        else if (secim1 == 3)
                        {
                            Console.WriteLine("Başka Hesaba EFT: 1");
                            Console.WriteLine("Başka hesaba havale: 2");
                            int hesab_secimi = Convert.ToInt32(Console.ReadLine());
                            if (hesab_secimi == 1)
                            {

                                Double eft_numaras = 234567890123;


                                Console.WriteLine("lütfen 12 haneli EFT nurası girin");
                                double eftNumarası = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("EFT numarası TR:" + eft_numaras);
                                if (eftNumarası == eft_numaras)
                                {
                                    Console.WriteLine("lütfen göndernek istediğniz tutarı giriniz");
                                    double gönderılıcek_tutar = Convert.ToDouble(Console.ReadLine());


                                    if (gönderılıcek_tutar <= bakiye)
                                    {
                                        Console.WriteLine("para gönderildi yeni bakiyeniz :" + (bakiye - gönderılıcek_tutar));

                                    }
                                    if (gönderılıcek_tutar > bakiye)
                                    {
                                        Console.WriteLine("lütfen farklı tutar giriniz");
                                        continue;


                                    }

                                }
                                if (eftNumarası != eft_numaras)
                                {
                                    Console.WriteLine("hatalı eft numarası");
                                    Console.WriteLine("lütfen eft numarasını kontrol ediniz");
                                    break;


                                }





                            }
                            if (hesab_secimi == 2)
                            {

                                Double havale_numaras = 12345678901;


                                Console.WriteLine("lütfen 11 haneli havale nurası girin");
                                double havale_Numarası = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("havale numarası TR:" + havale_numaras);
                                if (havale_Numarası == havale_numaras)
                                {
                                    Console.WriteLine("lütfen göndernek istediğniz tutarı giriniz");
                                    double gönderılıcek_tutar1 = Convert.ToDouble(Console.ReadLine());


                                    if (gönderılıcek_tutar1 <= bakiye)
                                    {
                                        Console.WriteLine("para gönderildi yeni bakiyeniz :" + (bakiye - gönderılıcek_tutar1));

                                    }
                                    if (gönderılıcek_tutar1 > bakiye)
                                    {
                                        Console.WriteLine("lütfen farklı tutar giriniz");
                                        continue;


                                    }

                                }
                                if (havale_Numarası != havale_numaras)
                                {
                                    Console.WriteLine("hatalı eft numarası");
                                    Console.WriteLine("lütfen eft numarasını kontrol ediniz");
                                    break;


                                }



                            }
                        }
                        else if (secim1 == 4)
                        {
                            Console.WriteLine("Eğitim Ödemeleri sayfası arızalı");
                            Console.WriteLine("ana menü için: 9");
                            Console.WriteLine("çıkış için: 0");
                            double arızalı_seçim = Convert.ToDouble(Console.ReadLine());
                            if (arızalı_seçim == 9)
                            {
                                Console.WriteLine("ana menüye dönüldü");
                                continue;

                            }
                            if (arızalı_seçim == 0)
                            {
                                Console.WriteLine("çıkış yapıldı");
                                break;


                            }

                        }
                        else if (secim1 == 5)
                        {
                            Console.WriteLine("Elektrik Faturası: ");
                            Console.WriteLine("Telefon Faturası: ");
                            Console.WriteLine("İnternet faturası: ");
                            Console.WriteLine("Su Faturası: ");
                            Console.WriteLine("OGS Ödemeleri: ");
                            Console.WriteLine("Tüm Faturalarınız Ödemek İçin: 1");
                            Double fatura_secimi = Convert.ToInt64(Console.ReadLine());


                            if (fatura_secimi == 1)
                            {
                                Console.WriteLine("elektirik faturanızı giriniz");
                                double elektirik_faturası = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("telefon faturanızı giriniz");
                                Double telefon_faturası = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("internet faturanızı giriniz");
                                double interne_faturası = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("su faturanızı giriniz");
                                double su_faturası = Convert.ToInt64(Console.ReadLine());

                                if (elektirik_faturası <= bakiye || telefon_faturası <= bakiye || interne_faturası <= bakiye || su_faturası <= bakiye)
                                {
                                    Console.WriteLine("faturalarınız  ödendi");
                                    Console.WriteLine("yeni bakiyeniz :" + (bakiye - elektirik_faturası - telefon_faturası - interne_faturası - su_faturası));
                                    Console.WriteLine("ana menü: 1");
                                    Console.WriteLine("çıkış için: 0");
                                    double fatura_çıkışı = Convert.ToInt64(Console.ReadLine());
                                    if (fatura_çıkışı == 1)
                                    {
                                        Console.WriteLine("ana menüye dönüldü");
                                        continue;

                                    }
                                    if (fatura_çıkışı == 0)
                                    {
                                        Console.WriteLine("çıkış yapıldı");
                                        break;
                                    }
                                }
                            }
                            if (fatura_secimi != 1)
                            {
                                Console.WriteLine("hatalı tuşlama yaptınız lütfen tekrar deneyiniz");
                                continue;
                            }

                        }
                        else if (secim1 == 6)
                        {
                            Console.WriteLine("şifre değiştirmek için: 1");
                            Console.WriteLine("çıkış için: 0");

                            double şifre_değişimi = Convert.ToInt64(Console.ReadLine());
                            if (şifre_değişimi == 1)
                            {
                                Console.WriteLine("lütfen şifrenizi giriniz");
                                string password1 = "ab18";

                                string sifre1 = Console.ReadLine();

                                if (password1 == sifre1)
                                {
                                    Console.WriteLine("lütfen yeni şifrenizi giriniz");
                                    string sıfre2 = (Console.ReadLine());
                                    Console.WriteLine("lütfen şifreyi tekrar giriniz");
                                    string sıfre3 = (Console.ReadLine());
                                    if (sıfre2 == sıfre3)
                                    {
                                        Console.WriteLine("şifreniz güncellendi");
                                        break;


                                    }
                                    if (sıfre2 != sıfre3)
                                    {
                                        Console.WriteLine("hatalı şifre girdiniz lütfen tekrar deneyiniz");
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                    else if (hak == 0)
                    {
                        Console.WriteLine("Giriş Hakkınız Kalmadı...");
                        Console.WriteLine("hesabınız bloke oldu");
                        Thread.Sleep(500000);
                    }
                    else
                    {
                        Console.WriteLine("Giriş Başarısız!!");
                        Console.WriteLine("Tekrar Deneyiniz.");
                    }
                }
            }
            else if (secim == 2)
            {
                int bakiye = 25000;
                Console.WriteLine("CepBank Para Çekmek: 1");
                Console.WriteLine("Para yatırmak için: 2");
                Console.WriteLine("Para transferi için: 3");
                Console.WriteLine("Eğitim Ödemeleri için: 4");
                Console.WriteLine("Fatura Ödemeler için:  5");
                double kartsız_secim = Convert.ToInt64(Console.ReadLine());
                if (kartsız_secim == 1)
                {
                    Double tc = 20993803532;
                    Double tel = 5394388029;
                    int hak1 = 3;
                    while (hak1 > 0)
                    {
                        Console.WriteLine("lütfen tc kimlik numaranızı giriniz");
                        Double tc_kimlik = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("lütfen telefon numaranızı giriniz");
                        Double telefon_no = Convert.ToInt64(Console.ReadLine());
                        hak1--;

                        if (tc == tc_kimlik && tel == telefon_no)
                        {
                            Console.WriteLine("Giriş Başarılı");
                            Console.WriteLine("1000 TL para çekebilirsiniz");
                            Console.WriteLine("lütfen çekmek istediğiniz tutarı giriniz");
                            Double cepbank_çekim = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("para çekildi" + (bakiye - cepbank_çekim));
                            Console.WriteLine("ana menü için: 1");
                            Console.WriteLine("çıkış için: 0");
                            Double cepbank_çıkış = Convert.ToInt64(Console.ReadLine());
                            if (cepbank_çıkış == 9)
                            {
                                Console.WriteLine("ana menüye dönüldü");
                                continue;
                            }
                            if (cepbank_çıkış == 0)
                            {
                                Console.WriteLine("çıkış yapıldı");
                                break;
                            }
                        }

                        else if (hak1 == 0)
                        {
                            Console.WriteLine("Giriş Hakkınız Kalmadı...");
                            Console.WriteLine("hesabınız 1 saat kilitlenmiştir");
                            Thread.Sleep(600000000);
                            Console.WriteLine("Sistem açıldı");
                            hak1 = 3;
                        }
                    }
                }
                else if (kartsız_secim == 2)
                {
                    Double kredi_kartı = 123456789012;
                    Double t_c = 20993803532;
                    Console.WriteLine("nakik ödeme için: 1");
                    Console.WriteLine("hesaptan ödeme: 2");
                    int kartsız_secimi = Convert.ToInt32(Console.ReadLine());
                    if (kartsız_secimi == 1)
                    {
                        Console.WriteLine("lütfen 12 haneli kart numaranızı giriniz");
                        long kkartı_2 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("kkartınız: TR" + kkartı_2);
                        Console.WriteLine("lütfen TC kimlik numaranızı girin");
                        Double tc1 = Convert.ToInt64(Console.ReadLine());
                        if (kredi_kartı == kkartı_2 && t_c == tc1)
                        {
                            Console.WriteLine("nakit olarak ödeme yapıldı");
                            Console.WriteLine("ana menü için: 9");
                            Console.WriteLine("çıkış inin: 0");
                            Double kartsız_ödeme_çıkışı = Convert.ToInt64(Console.ReadLine());
                            if (kartsız_ödeme_çıkışı == 9)
                            {
                                Console.WriteLine("ana menüye dönüldü");

                            }
                        }
                    }
                    else if (kartsız_secimi == 2)
                    {
                        Console.WriteLine("lütfen 12 haneli kkartı girin");
                        Double kıredi_kartı = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("lütfen hesap numaranızı girin");
                        Double hesap_no = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("hesabınıza para yatırıldı");
                        Console.WriteLine("ana menü için: 9");
                        Console.WriteLine("çıkış için: 0");
                        Double kartsız_çıkış = Convert.ToInt64(Console.ReadLine());
                        if (kartsız_çıkış == 9)
                        {
                            Console.WriteLine("ana menüye dönüldü");
                        }
                        if (kartsız_çıkış == 0)
                        {
                            Console.WriteLine("çıkış yapıldı");
                        }
                    }
                }
                else if (kartsız_secim == 3)
                {
                    Console.WriteLine("Başka Hesaba EFT: 1");
                    Console.WriteLine("Başka hesaba havale: 2");
                    int hesab_secimi = Convert.ToInt32(Console.ReadLine());
                    if (hesab_secimi == 1)
                    {
                        Double eft_numaras = 234567890123;
                        Console.WriteLine("lütfen 12 haneli EFT nurası girin");
                        double eftNumarası = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("EFT numarası TR:" + eft_numaras);
                        if (eftNumarası == eft_numaras)
                        {
                            Console.WriteLine("lütfen göndernek istediğniz tutarı giriniz");
                            double gönderılıcek_tutar = Convert.ToDouble(Console.ReadLine());
                            if (gönderılıcek_tutar <= bakiye)
                            {
                                Console.WriteLine("para gönderildi yeni bakiyeniz :" + (bakiye - gönderılıcek_tutar));
                            }
                            if (gönderılıcek_tutar > bakiye)
                            {
                                Console.WriteLine("lütfen farklı tutar giriniz");
                            }

                        }
                        if (eftNumarası != eft_numaras)
                        {
                            Console.WriteLine("hatalı eft numarası");
                            Console.WriteLine("lütfen eft numarasını kontrol ediniz");
                        }

                    }
                    if (hesab_secimi == 2)
                    {
                        Double havale_numaras = 12345678901;
                        Console.WriteLine("lütfen 11 haneli havale nurası girin");
                        double havale_Numarası = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("havale numarası TR:" + havale_numaras);
                        if (havale_Numarası == havale_numaras)
                        {
                            Console.WriteLine("lütfen göndernek istediğniz tutarı giriniz");
                            double gönderılıcek_tutar1 = Convert.ToDouble(Console.ReadLine());
                            if (gönderılıcek_tutar1 <= bakiye)
                            {
                                Console.WriteLine("para gönderildi yeni bakiyeniz :" + (bakiye - gönderılıcek_tutar1));
                            }
                            if (gönderılıcek_tutar1 > bakiye)
                            {
                                Console.WriteLine("lütfen farklı tutar giriniz");
                            }

                        }
                        if (havale_Numarası != havale_numaras)
                        {
                            Console.WriteLine("hatalı eft numarası");
                            Console.WriteLine("lütfen eft numarasını kontrol ediniz");
                        }
                    }
                }
                else if (kartsız_secim == 4)
                {
                    Console.WriteLine("Eğitim Ödemeleri sayfası arızalı");
                    Console.WriteLine("ana menü için: 9");
                    Console.WriteLine("çıkış için: 0");
                    double arızalı_seçim = Convert.ToDouble(Console.ReadLine());
                    if (arızalı_seçim == 9)
                    {
                        Console.WriteLine("ana menüye dönüldü");
                    }
                    if (arızalı_seçim == 0)
                    {
                        Console.WriteLine("çıkış yapıldı");
                    }
                }
                else if (kartsız_secim == 5)
                {
                    Console.WriteLine("Elektrik Faturası: ");
                    Console.WriteLine("Telefon Faturası: ");
                    Console.WriteLine("İnternet faturası: ");
                    Console.WriteLine("Su Faturası: ");
                    Console.WriteLine("OGS Ödemeleri: ");
                    Console.WriteLine("Tüm Faturalarınız Ödemek İçin: 1");
                    Double fatura_secimi = Convert.ToInt64(Console.ReadLine());
                    if (fatura_secimi == 1)
                    {
                        Console.WriteLine("elektirik faturanızı giriniz");
                        double elektirik_faturası = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("telefon faturanızı giriniz");
                        Double telefon_faturası = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("internet faturanızı giriniz");
                        double interne_faturası = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("su faturanızı giriniz");
                        double su_faturası = Convert.ToInt64(Console.ReadLine());

                        if (elektirik_faturası <= bakiye || telefon_faturası <= bakiye || interne_faturası <= bakiye || su_faturası <= bakiye)
                        {
                            Console.WriteLine("faturalarınız  ödendi");
                            Console.WriteLine("yeni bakiyeniz :" + (bakiye - elektirik_faturası - telefon_faturası - interne_faturası - su_faturası));
                            Console.WriteLine("ana menü: 1");
                            Console.WriteLine("çıkış için: 0");
                            double fatura_çıkışı = Convert.ToInt64(Console.ReadLine());
                            if (fatura_çıkışı == 1)
                            {

                                Console.WriteLine("ana menüye dönüldü");
                            }
                            if (fatura_çıkışı == 0)
                            {
                                Console.WriteLine("çıkış yapıldı");

                            }
                        }
                    }
                    if (fatura_secimi != 1)
                    {
                        Console.WriteLine("hatalı tuşlama yaptınız lütfen tekrar deneyiniz");


                    }

                }
            }
            else
            {
                Console.WriteLine("lütfen size gösterilen seçimi yapınız");
            }
        }
    }
}




