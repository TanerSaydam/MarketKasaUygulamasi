namespace MarketKasaApp
{
    public class Sepet
    {
        public Sepet()
        {

        }
        public Sepet(string urunAdi, int adet, decimal birimFiyati)
        {
            UrunAdi = urunAdi;
            Adet = adet;
            BirimFiyati = birimFiyati;
            Toplam = birimFiyati * adet;
        }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyati { get; set; }
        public decimal Toplam { get; set; }
    }
}
