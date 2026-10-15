using System;

class Program 
{
    static void Main() // Programın başlangıç noktası. static: Bu metot, sınıfın bir örneği oluşturulmadan çağrılabilir. void: Bu metot herhangi bir değer döndürmez. 
    {
        // SayiKontroloru türünde yeni bir nesne oluşturuyoruz.
        SayiKontroloru sayiNesnesi = new SayiKontroloru(); 
        
        string giris = ""; 

        do 
        {
            Console.WriteLine("Bir sayı giriniz (Çıkmak için N):"); 
            giris = Console.ReadLine(); 

            // Kullanıcının girdiği değeri sayıya çevirmeye çalışıyoruz
            if (int.TryParse(giris, out int parseEdilenSayi)) 
            {
                // Değişkene doğrudan erişemiyoruz. (kapsülleme)
                // Değeri Setter üzerinden güvenli bir şekilde atıyoruz.
                sayiNesnesi.GirilenSayi = parseEdilenSayi;

                if (sayiNesnesi.CiftMi()) // Nesne kendi private değişkeni üzerinde çalışıyor.Çift mi tek mi kontrolü yapıyor.
                {
                    Console.WriteLine("Sayı çifttir");
                }
                else
                {
                    Console.WriteLine("Sayı tektir");
                }
            }

        } while (giris.ToUpper() != "N"); // Kullanıcı 'N' girene kadar döngü devam eder.
    }          // ToUpper ile hem 'n' hem 'N' girişini yakalıyoruz. != : eşit değil mi? anlamına gelir.
}

class SayiKontroloru
{
    // 1. KAPSÜLLEME: private değişken. Dışarıdan doğrudan erişime ve değiştirilmeye kapalıdır.
    private int _girilenSayi; 

    // _girilenSayi değişkenine kontrollü erişim sağlar.
    public int GirilenSayi 
    {
        get // _girilenSayi değişkeninin değerini döndürür.
        { 
            // Okunmak istendiğinde çalışır
            return _girilenSayi; 
        }
        set //kullanıcıdan aldığı değeri kaydeder.
        { 
            // Değer atanmak istendiğinde çalışır. 
            _girilenSayi = value; 
        }
    }

    // 3. Metot artık dışarıdan parametre almıyor, nesnenin kendi private verisi üzerinde çalışıyor.
    public bool CiftMi() // Bu metot, sayının çift olup olmadığını kontrol eder. bool : true veya false döndürür.
    {
        return _girilenSayi % 2 == 0;  // Eğer sayı 2 ile bölündüğünde kalan 0 ise çift sayıdır. == :eşit mi? diyekontrol eder. % : mod alma operatörüdür.  
    }
}