using System;


// Ana Program (Kullanıcıdan veri alıp sonuç verdiğimiz yer)
class Arayuz 
{
    static void Main() // Programın başlangıç noktası. static: Bu metot, sınıfın bir örneği oluşturulmadan çağrılabilir. void: Bu metot herhangi bir değer döndürmez. 
    {
        
        SayiIslemleri islem = new SayiIslemleri();  // SayiIslemleri türünde yeni bir nesne oluşturuyoruz.
 
        string deger = "";  //Kullanıcıdan aldığımız veri
        int sayi;

        do // Kullanıcı 'N' girene kadar döngü devam eder.
        {
            Console.WriteLine("Bir sayı giriniz (Çıkmak için N):"); 
            deger = Console.ReadLine(); // Kullanıcıdan değer

            if (int.TryParse(deger, out sayi)) // Kullanıcının girdiği değeri sayıya çevirmeye çalışıyoruz 
            {
                // Kontrol işlemini oluşturduğumuz nesne üzerinden yapıyoruz
                if (islem.CiftMi(sayi)) // CiftMi metodu çağrılıyor ve sayının çift olup olmadığı kontrol ediliyor.
                {
                    Console.WriteLine("Sayı çifttir");
                }
                else
                {
                    Console.WriteLine("Sayı tektir");
                }
            }

        } while (deger.ToUpper() != "N"); // ToUpper ile hem 'n' hem 'N' girişini yakalıyoruz. != : eşit değil mi? anlamına gelir.
    }
}

class SayiIslemleri
{
    // Sayının çift olup olmadığını kontrol eden metot
    public bool CiftMi(int kontrolEdilecekSayi) // Bu metot, sayının çift olup olmadığını kontrol eder. bool : true veya false döndürür.
    {
        return kontrolEdilecekSayi % 2 == 0;       // Eğer sayı 2 ile bölündüğünde kalan 0 ise çift sayıdır. == :eşit mi? diyekontrol eder. % : mod alma operatörüdür.  
    }
}