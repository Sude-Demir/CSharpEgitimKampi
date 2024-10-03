using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            #region DOUBLE DEĞİŞKENLER

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("--- ELMA BİRİM FİYATI : " + applePrice + " TL ");
            Console.WriteLine("--- PORTAKAL BİRİM FİYATI : " + orangePrice + " TL");
            Console.WriteLine("--- ÇİLEK BİRİM FİYATI : " + strawberryPrice + " TL");
            Console.WriteLine("--- PATATES BİRİM FİYATI: " + potatoPrice + " TL");
            Console.WriteLine("--- DOMATES BİRİM FİYATI: " + tomatoPrice + " TL");
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.240;
            orangeGram = 5.264;
            strawberryGram = 0.642;
            potatoGram = 3.531;
            tomatoGram = 0.586;

            double totalApplePrice = appleGram * applePrice;
            double totalOrangePrice = orangeGram * orangePrice;
            double totalStrawberryPrice = strawberryGram * strawberryPrice;
            double totalPotatoPrice = potatoGram * potatoPrice;
            double totalTomatoPrice = tomatoGram * tomatoPrice;


            Console.WriteLine();

            Console.WriteLine("Alınan Ürün: Elma- " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + "          Toplam Tutar: " + totalApplePrice + "  TL");
            Console.WriteLine("Alınan Ürün: Portakal- " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + "     Toplam Tutar: " + totalOrangePrice + "  TL");
            Console.WriteLine("Alınan Ürün: Çilek- " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + "         Toplam Tutar: " + totalStrawberryPrice + "  TL");
            Console.WriteLine("Alınan Ürün: Patates- " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + "    Toplam Tutar: " + totalPotatoPrice + "  TL");
            Console.WriteLine("Alınan Ürün: Domates- " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + "     Toplam Tutar: " + totalTomatoPrice + "  TL");
            double shoppingTotalPrice = totalApplePrice + totalOrangePrice + totalStrawberryPrice + totalTomatoPrice + totalPotatoPrice;

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + "TL");


            #endregion

            #region CHAR DEĞİŞKENLER

            //ABCD
            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region KLAVYEDEN VERİ GİRİŞLERİ

            Console.WriteLine("**** cSharp Hava Yolları Yolcu Bilgileri ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yaş Bilgisi: ");
            passengerAge = Console.ReadLine();

            Console.Write("Kimlik Numarası: ");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Yolcu TC Kimlik Numarası: " + passengerIdentityNumber + "  -  Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + " " + passengerAge + " " + passengerCity + " / " + passengerDistrict);


            #endregion
            Console.WriteLine();

            #region KLAVYEDEN TAM SAYI GİRİŞLERİ VE DÖNÜŞÜMLER
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 2000;
            chairPrice = 2350;
            tvPrice = 1120;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz:  ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Tv Sayısını Giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            Console.WriteLine();

            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);


            #endregion

            #region KLAVYEDEN ONDALIKLI SAYI İŞLEMLERİ
            double exam1, exam2, exam3, result;

            Console.Write("1.Sınav Notunu Giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("2.Sınav Notunu Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("3.Sınav Notunu Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region KLAVYEDEN KARAKTER GİRİŞLERİ
            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyeti Giriniz: " + gender);
            #endregion

            Console.ReadLine();
            

        }
    }
}
