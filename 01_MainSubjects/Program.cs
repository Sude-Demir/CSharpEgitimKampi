using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Hello World");
            //Console.Write("Hİ");

            //Console.WriteLine("*** YEMEK ÇEŞİTLERİ ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*** YEMEK ÇEŞİTLERİ ***");

            #endregion

            #region STRİNG DEĞİŞKENLER

            //string
            //değişken_türü değişken_adı;

            //string name;
            //name = "Sude";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Sude";
            //customerSurname = "Demir";
            //customerPhone = "+90 517 382 48 52";
            //customerEmail = "deneme@gmail.com";
            //district = "Kağızman";
            //city = "Kars";

            //Console.WriteLine("*** REZERVASYON KARTI ***");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri Kartı= " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim= " + customerPhone);
            //Console.WriteLine("Email adresi= " + customerEmail);
            //Console.WriteLine("Adres= " + district + "/ " + city);
            //Console.WriteLine("---------------------------");

            //Console.WriteLine();

            //customerName = "Ecrin";
            //customerSurname = "Demir";
            //customerPhone = " +90 400 300 20 10 ";
            //customerEmail = " test@gmail.com ";
            //district = "Ataşehir";
            //city = "Elazığ";

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------");

            #endregion

            #region İNT DEĞİŞKENLER

            //int
            //int number = 20;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

           
            Console.WriteLine("***RESTORAN MENÜ FİYATI***");
            Console.WriteLine();
            Console.WriteLine("--Hamburger:" + hamburgerPrice +"TL");
            Console.WriteLine("--Kola:" + cokePrice + "TL");
            Console.WriteLine("--Su:" + waterPrice + "TL");
            Console.WriteLine("--Kızartma:" + friesPrice + "TL");
            Console.WriteLine("--Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("--Limonata:" + lemonadePrice + "TL");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;



            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " +totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine();
            int totalPrice = totalCokePrice + totalFriesPrice + totalHamburgerPrice + totalLemonadePrice + totalWaterPrice + totalPizzaPrice;
            Console.WriteLine("TOPLAM ÖDENECEK TUTAR: " + totalPrice + "TL");
           
            #endregion

            Console.Read();
        }
    }
}