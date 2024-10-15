using System;
using System.Collections.Generic;

List<string> meyveler = new List<string>();
meyveler.Add("Elma");
meyveler.Add("Armut");
meyveler.Add("Muz");
meyveler.Add("Kiraz");
meyveler.Add("Kavun");


List<string> sebzeler = new List<string>();
sebzeler.Add("Ispanak");
sebzeler.Add("Pırasa");
sebzeler.Add("Brokoli");
sebzeler.Add("Fasulye");
sebzeler.Add("Patlıcan");

 Dictionary<string, double> alinanUrunler = new Dictionary<string, double>();
Dictionary<string, double> MusteriAlinanUrunler = new Dictionary<string, double>();

while (true)
{
  Console.WriteLine("---Hoşgeldiniz.---");
  Console.WriteLine("Meyve mi Sebzemi almak istersiniz?");
  Console.WriteLine("Meyve -> m | Sebze -> s");
  string cevap = Console.ReadLine().ToLower();
  if (cevap == "m")
  {
    Console.WriteLine("Elimizde Olan Meyveler:");
    Console.WriteLine("Lütfen almak istediğiniz meyveyi seçiniz.");
    for (int i = 0; i < meyveler.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {meyveler[i]}");
    }
    int meyveSecim = Convert.ToInt32(Console.ReadLine());
    if (meyveSecim >= 0 && meyveSecim < meyveler.Count)
    {
      string secilenMeyve = meyveler[meyveSecim];
      Console.WriteLine($"Seçtiğiniz Meyve: {secilenMeyve}");
      Console.WriteLine("Bu meyveden kaç kilo almak istersiniz?");
      double kilo = Convert.ToDouble(Console.ReadLine());
      if (alinanUrunler.ContainsKey(secilenMeyve))
      {
        alinanUrunler[secilenMeyve] += kilo;
      }
      else
      {
        alinanUrunler[secilenMeyve] = kilo;
      }
    }
    else
    {
      Console.WriteLine("Geçersiz istek. Lütfen Tekrar deneyin.");
    }
  }

if (cevap == "s")
{
  Console.WriteLine("Elimizde Olan Sebzeler:");
  Console.WriteLine("Lütfen almak istediğiniz sebzeyi seçiniz.");
  for (int i = 0; i < meyveler.Count; i++)
  {
    Console.WriteLine($"{i + 1}. {sebzeler[i]}");
  }
  int sebzeSecim = Convert.ToInt32(Console.ReadLine());
  if (sebzeSecim >= 0 && sebzeSecim < sebzeler.Count)
  {
    string secilenSebze = sebzeler[sebzeSecim];
    Console.WriteLine($"Seçtiğiniz Sebze: {secilenSebze}");
    Console.WriteLine("Bu sebzeden kaç kilo almak istersiniz?");
    double kilo1 = Convert.ToDouble(Console.ReadLine());
    if (alinanUrunler.ContainsKey(secilenSebze))
      {
        alinanUrunler[secilenSebze] += kilo1;
      }
      else
      {
        alinanUrunler[secilenSebze] = kilo1;
      }
  }
  else
  {
    Console.WriteLine("Geçersiz istek. Lütfen Tekrar deneyin.");
  }
}

Console.WriteLine("Başka bir arzunuz var mıydı? (E/H)");
string devam = Console.ReadLine().ToUpper();
if (devam == "H")
{
    break; 
}
else if (devam == "E")
{
  continue;
}
}

while (true)
{
  Console.WriteLine("---Manavda sıradan bir gün---");
  Console.WriteLine("Hoşgeldiniz, Meyve mi Sebze mi satın almak istersiniz?");
  Console.WriteLine("Meyve -> m | Sebze -> s");
  string cevap1 = Console.ReadLine().ToLower();

  if (cevap1 == "m")
  {
    Console.WriteLine("Elimizde Olan meyveler ve maksimum alınabilecek kiloları:");
    foreach (var urunler in alinanUrunler)
    {
      if (meyveler.Contains(urunler.Key))
      {
        Console.WriteLine($"{urunler.Key}: {urunler.Value} kg");
      }
    }
    Console.WriteLine("Almak istediğiniz meyvenin adını giriniz lütfen.");
    string musteriSecim = Console.ReadLine();
    if (alinanUrunler.ContainsKey(musteriSecim))
    {
      Console.WriteLine("Bu meyveden kaç kilo almak istersiniz?");
      double musteriKilo = Convert.ToDouble(Console.ReadLine());
      if (alinanUrunler[musteriSecim] >= musteriKilo)
      {
        alinanUrunler[musteriSecim] -= musteriKilo;
        Console.WriteLine($"{musteriKilo} kg kadar {musteriSecim} aldınız.");
        if (MusteriAlinanUrunler.ContainsKey(musteriSecim))
        {
          MusteriAlinanUrunler[musteriSecim] += musteriKilo;
        }
       else
       {
         MusteriAlinanUrunler[musteriSecim] = musteriKilo;
       }
      }
      else
      {
        Console.WriteLine($"Yeterli {musteriSecim} stoğumuz yok. Lütfen geçerli bir kg giriniz.");
      }
    }
     else
    {
    Console.WriteLine("Bu meyve şuanda elimizde mevcut değil.");
    }
  }

  else if (cevap1 == "s")
  {
    Console.WriteLine("Elimizde Olan sebzeler ve maksimum alınabilecek kiloları:");
    foreach (var urunler in alinanUrunler)
    {
      if (meyveler.Contains(urunler.Key))
      {
        Console.WriteLine($"{urunler.Key}: {urunler.Value} kg");
      }
    }
    Console.WriteLine("Almak istediğiniz sebzenin adını giriniz lütfen.");
    string musteriSecim1 = Console.ReadLine();
    if (alinanUrunler.ContainsKey(musteriSecim1))
    {
      Console.WriteLine("Bu sebzeden kaç kilo almak istersiniz?");
      double musteriKilo1 = Convert.ToDouble(Console.ReadLine());
      if (alinanUrunler[musteriSecim1] >= musteriKilo1)
      {
        alinanUrunler[musteriSecim1] -= musteriKilo1;
        Console.WriteLine($"{musteriKilo1} kg kadar {musteriSecim1} aldınız.");
        if (MusteriAlinanUrunler.ContainsKey(musteriSecim1))
        {
          MusteriAlinanUrunler[musteriSecim1] += musteriKilo1;
        }
       else
       {
         MusteriAlinanUrunler[musteriSecim1] = musteriKilo1;
       }
      }
      else
      {
        Console.WriteLine($"Yeterli {musteriSecim1} stoğumuz yok. Lütfen geçerli bir kg giriniz.");
      }
    }
  }
  else
  {
    Console.WriteLine("Bu meyve şuanda elimizde mevcut değil.");
  }

Console.WriteLine("Başka bir arzunuz var mıydı? (E/H)");
string devam1 = Console.ReadLine().ToUpper();
if (devam1 == "H")
{
    break; 
}
else if (devam1 == "E")
{
  continue;
}
}

Console.WriteLine("---Manavın Elinde Kalan Ürünler Ve Kiloları---");
foreach (var urun in alinanUrunler)
{
  if (urun.Value > 0)
  {
    Console.WriteLine($"{urun.Key}: {urun.Value} kg");
  }
}

Console.WriteLine("---Musterinin Aldığı Ürünler ve Kiloları---");
foreach (var urun1 in MusteriAlinanUrunler)
{
  if (urun1.Value > 0)
  {
    Console.WriteLine($"{urun1.Key}: {urun1.Value} kg");
  }
}