
// Berkay Şahin 

using Oop2;


GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Berkay";
musteri1.Soyadi = "Şahin";
musteri1.TcNo = "12345678910";


// Tüzel için şirket
TuzelMusteri musteri12 = new TuzelMusteri();
musteri12.Id = 2;
musteri12.MusteriNo = "12346";
musteri12.SirketAdi = "Esas";
musteri12.VergiNo = "1234567890";


CustomerManager customerManager = new CustomerManager();
customerManager.Add(musteri1);
customerManager.Add(musteri12);
// Gerçek Müşteri - Tüzel Müşteri 
//SOLİD "L" 