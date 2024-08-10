// See https://aka.ms/new-console-template for more information
using Radore_OOP.AbstractClasses;
using Radore_OOP.Classes;
using Radore_OOP.Constructors;
using Radore_OOP.Constructors2;
using Radore_OOP.Odev_2.Classes;
using Radore_OOP.Odev_2.Interfaces;
using Radore_OOP.solid.kotu;
using Radore_OOP.solid.iyi;
using System.Collections;
using Araba = Radore_OOP.Odev_2.Classes.Araba;
using LogType = Radore_OOP.solid.iyi.LogType;
using XmlLog = Radore_OOP.solid.iyi.XmlLog;
using DbLog = Radore_OOP.solid.iyi_hoca_.DbLog;
using JsonLog = Radore_OOP.solid.iyi.JsonLog;
using Logger = Radore_OOP.solid.iyi_hoca_.Logger;
using Radore_OOP.Overrides;
using Radore_OOP.solid.iyi_hoca_;
using Radore_OOP.Reflections;
using System.Reflection;

//Console.WriteLine("Hello, World!");


////ClassIsmi nesneAdi = new ClassAdi();
////alloc malloc 
//Insan i = new Insan();
//i.adi = "ibrahim";
//i.soyadi = "gökyar";
//i.yas = 46;
//i.maas = 3.14;
//i.cinsiyet = true;
//i.uyu(i.adi, i.soyadi);

//Insan i2 = new Insan("hakan", "yilmaz");

//new Insan("metin", "yildiz", 44, 3.14, true);


////Araba
///*Araba a = new Araba();
//a.marka = "bmw";
//a.model = "x5";
//a.kapiSayisi = 4;
//a.pencereSayisi = 4;
//a.Git(a.marka,a.model);
//*/
//Anne an = new Anne();
//an.adi = "fahriye";
//an.soyadi = "gökyar";
//an.yas = 60;
//an.cinsiyet = false;
//an.ekranaYaz(an.adi, an.soyadi);
//an.oku(an.adi);
//an.yaz(an.adi);

//Baba b = new Baba();
//b.adi = "Kasım";
//b.soyadi = "Gökyar";
//b.ekranaYaz(b.adi, b.soyadi);
//b.oku(b.adi);
//b.dinle(b.adi);


//Cocuk c = new Cocuk();
//c.ekranaYaz("ibrahim", "gökyar");


//AkilliCocuk ak = new AkilliCocuk();
//ak.adSoyadSifatYaz("Hakan", "Yılmaz", "Akıllıdır");
//ak.oku("Hakan");
//ak.dinle("Hakan");
//ak.yaz("Hakan");


//UsluCocuk us = new UsluCocuk();
//us.adi = "Mehmet";
//us.soyadi = "Yıldız";
//us.sifat = "Usludur";
//us.adSoyadSifatYaz(us.adi, us.soyadi, us.sifat);
//us.dinle(us.adi);
//us.yaz(us.adi);


//Matematik m = new Matematik();
//int gelenDeger = m.topla(5, 5);
//Console.WriteLine("Toplam : " + gelenDeger);
//m.topla(5, 5, 5, 4);



//GenelMudur gm = new GenelMudur();
//Mudur mu = new Mudur();
//Programci p = new Programci();
//Stajyer s = new Stajyer();

//double toplamMaas = 0.0;
//toplamMaas += gm.maasinizNedir();
//toplamMaas += mu.maasinizNedir();
//toplamMaas += p.maasinizNedir();
//toplamMaas += s.maasinizNedir();
//Console.WriteLine("Toplam Maaş : " + toplamMaas + " TL maaş alıyorlar");

//Calisan[] calisanlar = { gm, mu, p, s };
//double maasToplam = 0.0;
//for (int z = 0; z < calisanlar.Length; z++)
//{
//    maasToplam += calisanlar[z].maasinizNedir();
//}
//Console.WriteLine("Çalışanların toplam maaşı : " + maasToplam + " TL maaş alıyorlar");


//Goz goz = new Goz("Kahverengi", "retina", 30, 30);
//Kulak kulak = new Kulak("Geniş");
//Burun burun = new Burun("Kemer");
//Kafa kafa = new Kafa(goz, kulak, burun);
//YeniInsan yeni = new YeniInsan("ibrahim", "gökyar", kafa);
//yeni.randevuKayit();




//Marka marka = new Marka("BMW");
//Model model = new Model("x5");
//Kapi kapi = new Kapi(4);
//Pencere pencere = new Pencere(4);
//Kasa kasa = new Kasa(marka, model, kapi, pencere, "Sedan");
//YeniAraba yeniAraba = new YeniAraba(kasa, 2000000.0);
//yeniAraba.siparisVer();

////diziler
////1. yöntem 
//string[] gunler = new string[7];
//gunler[0] = "pazartesi";
//gunler[1] = "salı";
//gunler[2] = "çarşamba";
//gunler[3] = "perşembe";
//gunler[4] = "cuma";
//gunler[5] = "cumartesi";
//gunler[6] = "pazar";


//for (int x = 0; x < gunler.Length; x++)
//{
//    Console.WriteLine(gunler[x]);
//}
////2. yöntem
//int[] sayilar = { 2, 4, 6, 7, 9, 11, 22, 33, 44, 55, 66 };
//int toplam = 0;
//for (int y = 0; y < sayilar.Length; y++)
//{
//    toplam = toplam + sayilar[y];
//}
//Console.WriteLine("Sayıların toplamı : " + toplam);

////generic class lar boxing ve unboxing işlemlerin performans kaybını da engeller
//List<int> liste = new List<int>();

//liste.Add(35);
//liste.Add(45);
//liste.Add(33);
//liste.Add(22);



//List<Personel> personelListesi = new List<Personel>();
//Personel p1 = new Personel("ibrahim", "gökyar", 3000.0);
//Personel p2 = new Personel("hakan", "yilmaz", 4000.0);
//Personel p3 = new Personel("metin", "yildiz", 5000.0);

//personelListesi.Add(p1);
//personelListesi.Add(p2);
//personelListesi.Add(p3);
//double personelMaasToplam = 0.0;
////string[] renkler = { "sarı", "mavi", "yeşil", "beyaz" };
//foreach (Personel personel in personelListesi)
//{
//    Console.WriteLine("personelin adı : " + personel.adi + " soyadı : " + personel.soyadi + " maaşı : " + personel.maas);
//    personelMaasToplam += personel.maas;
//}
//Console.WriteLine("Personellerin toplam maaşı : " + personelMaasToplam + " TL dir");



///*XmlLog xmlLog = new XmlLog();
//DbLog dbLog = new DbLog();
//JsonLog jsonLog = new JsonLog();
//Logger logger = new Logger(dbLog,xmlLog,jsonLog);
//logger.LogKaydet(LogType.Json, "303 nolu hata kodu oluştu");

//*/

///*  --------------Odev_2-------------  */

//Bmw bmw = new Bmw();
//Mercedes mercedes = new Mercedes();
//Porsche porsche = new Porsche();

//bmw.yuzuyor();
//bmw.ucuyor();
//bmw.hizli();

//mercedes.ucuyor();
//mercedes.yuzuyor();

//porsche.hizli();

//Araba[] arabalar = new Araba[]
//        {
//            new Bmw(),
//            new Mercedes(),
//            new Porsche()
//        };

//double toplamBenzinTuketimi = 0.0;

//foreach (var araba in arabalar)
//{
//    toplamBenzinTuketimi += araba.yakitTuketimi;
//}

//Console.WriteLine($"Toplam benzin tüketimi: {toplamBenzinTuketimi} litre");


///*  --------------Odev_3-------------  */

//var loglar = new Dictionary<LogType, ILogger>
//{
//            { LogType.Xml, new XmlLog() },
//            { LogType.Db, new DbLog() },
//            { LogType.Json, new JsonLog() }
//};

//Logger logger = new Logger(loglar);
//logger.logKaydet(LogType.Xml, "This is an XML log message");
//logger.logKaydet(LogType.Db, "This is a DB log message");
//logger.logKaydet(LogType.Json, "This is a JSON log message");


//Child child = new Child();
//child.yaz();

//DbLog dbLog = new DbLog();
//Logger logger = new Logger(dbLog);


Type t = typeof(MyClass);
MethodInfo[] mi = t.GetMethods();
Console.WriteLine("Nesnenin adı: " + t.Name);
foreach(MethodInfo mi2 in mi)
{
    ParameterInfo[] p = mi2.GetParameters();
    Console.WriteLine("Metod Adı: " + mi2.Name + "Dönüş Tipi: " + mi2.ReturnType);
    if(p.Length > 0)
    {
        Console.WriteLine("Parametre var");
    }
    for(int i = 0; i < p.Length; i++)
    {
        Console.WriteLine(i + 1 + ".parametre: Dönüş Değeri: "+ p[i].ParameterType.Name+ "Adı: " + p[i].Name);
    }
}