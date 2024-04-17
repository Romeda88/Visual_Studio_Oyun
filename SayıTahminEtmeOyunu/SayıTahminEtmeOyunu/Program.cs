using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec, sayi;
            string o, oy;
            int a;
            Random rastgele = new Random();
            a = rastgele.Next(1, 100);
            try
            {
                do
                {
                    Console.WriteLine("Oyunu kaç kişilik oynamak istersiniz?\n=>Bir Kişilik => 1\n=>İki Kişilik => 2");
                    Console.Write("Seçilen: ");
                    sec = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-------------------------------");
                    if (sec == 1)
                    {
                        Console.WriteLine("Oyunu Tek Kişilik Oynayacaksınız.\n--------------------------------");
                        Console.Write("İsminizi Giriniz: ");
                        o = Console.ReadLine();
                        Console.WriteLine("**\nOYUNUN AMACI:1-100 Arasında Sayı Girin ve benim aklımda tuttuğum sayıyı bulun.\n**\nNOT:Oyunu tekrar oynadığınız zaman aklımdaki sayı değişecektir.\n**");
                        do
                        {
                            Console.Write("'{0}' Bir Sayı Gir: ", o);
                            sayi = Convert.ToInt32(Console.ReadLine());
                            if (sayi < 1 || sayi > 100)
                            {
                                Console.Write("=>HATA!!,1-100 Arasında Sayı Girmelisiniz.\n");
                            }
                            else if (sayi < a)
                            {
                                Console.WriteLine("***Daha büyük bir sayı giriniz.***");
                            }
                            else if (sayi > a)
                            {
                                Console.WriteLine("***Daha küçük bir sayı giriniz.***");
                            }
                            else if (sayi == a)
                            {
                                Console.WriteLine("*****************************\n=>TEBRİKLER!! Bildin.'{0}'\n*****************************\n", o);
                            }
                        } while (sayi != a);
                    }
                    else if (sec == 2)
                    {
                        Console.WriteLine("Oyunu İki Kişilik Oynayacaksınız.\n--------------------------------");
                        Console.Write("OYUNCU-1 İsminizi Giriniz: ");
                        o = Console.ReadLine();
                        Console.Write("OYUNCU-2 İsminizi Giriniz: ");
                        oy = Console.ReadLine();
                        Console.WriteLine("**\nOYUNUN AMACI:1-100 Arasında Sayı Girin ve benim aklımda tuttuğum sayıyı bulun.\n**\nNOT:Oyunu tekrar oynadığınız zaman aklımdaki sayı değişecektir.\n**");
                        do
                        {
                            Console.Write("'{0}' Bir Sayı Gir: ", o);
                            sayi = Convert.ToInt32(Console.ReadLine());
                            if (sayi < 1 || sayi > 100)
                            {
                                Console.Write("=>HATA!!,1-100 Arasında Sayı Girmelisiniz.[Sıranı Kaybettin]\n");
                            }
                            else if (sayi < a)
                            {
                                Console.WriteLine("***Daha büyük bir sayı girmeliydin.***");
                            }
                            else if (sayi > a)
                            {
                                Console.WriteLine("***Daha küçük bir sayı girmeliydin.***");
                            }
                            else if (sayi == a)
                            {
                                Console.WriteLine("*****************************\n=>TEBRİKLER!! Bildin.'{0}'\n*****************************", o);
                                Console.ReadKey();
                            }
                            Console.Write("'{0}' Bir Sayı Gir: ", oy);
                            sayi = Convert.ToInt32(Console.ReadLine());
                            if (sayi < 1 || sayi > 100)
                            {
                                Console.Write("=>HATA!!,1-100 Arasında Sayı Girmelisiniz.[Sıranı Kaybettin]\n");
                            }
                            else if (sayi < a)
                            {
                                Console.WriteLine("***Daha büyük bir sayı girmeliydin.***");
                            }
                            else if (sayi > a)
                            {
                                Console.WriteLine("***Daha küçük bir sayı girmeliydin.***");
                            }
                            else if (sayi == a)
                            {
                                Console.WriteLine("*****************************\n=>TEBRİKLER!! Bildin.'{0}'\n*****************************\n", oy);
                                Console.ReadKey();
                            }
                        } while (sayi != a);
                    }
                    else if (sec != 1 || sec != 2)
                    {
                        Console.WriteLine("=>>>HATA!! [1 veya 2 kişilik oynayabilirsiniz]\n--------------------------------");
                    }
                } while (sec != 1 || sec != 2);
            }
            catch { Console.WriteLine("*************************************\n=>HATA:Lütfen Sadece Sayısal Değer Giriniz.!!\n>>Programı Lütfen Tekrar Açın\n**************************************"); }
            Console.ReadKey();
            
        }
    }
}