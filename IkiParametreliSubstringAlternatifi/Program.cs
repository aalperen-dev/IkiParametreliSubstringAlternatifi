using System;

namespace IkiParametreliSubstringAlternatifi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Substring metodunun 2 parametreli versiyonunu kendiniz yazın.
            //(Bu metot için string veri de parametreden gönderilsin ve hiçbir System sınıfından string metot kullanılmasın.)

            string metin = "buralara çok uzun birşeyler yazmak lazım";
            //substring oynamalık bir metin
            Console.WriteLine("Örnek metin: " + metin);
            //metini ekrana yazdırdım.
            Console.Write("Kaçıncı index'den itibaren başlayalım? : ");
            int bslngc = int.Parse(Console.ReadLine());
            //cift parametreli substring için ilk parametreyi kullanıcıdan istedim.
            Console.Write("Kaç index ilerleyelim? : ");
            int bts = int.Parse(Console.ReadLine());
            //cift parametreli substring için ikinci parametreyi de kullanıcıdan istedim.
            //kullanıcının her zaman doğru aralıkta değer girdiğini kabul ediyorum.
            //değerlerin uygunluğunu kontrol etmek için ekstra kontroller gerekli.
            Console.WriteLine();
            SubStringCiftParametreli(metin, bslngc, bts);
            //çift parametreli substring ile aynı işlemi yapan void metotuma gereken parametreleri gönderdim.
        }

        static void SubStringCiftParametreli(string gelen1, int baslangic, int bitis)
        {
            //bu metotun calışması her bir string ifadenin
            //aynı zamanda string bir dizi olması mantığına dayanıyor.
            int sayac = 0;
            while (true)
            {
                Console.Write(gelen1[baslangic]);
                //"dizi" içinde istediğim başlangıç indexini yazdırdım.
                baslangic++;
                //bir sonraki indexi yazdırmak için değişkeni bir arttırdım.
                sayac++;
                //sonsuz döngüden bir noktada çıkmak için sayacı da bir arttırdım.
                if (sayac == bitis)
                {
                    //sayac değeri istenilen index kadar ilerlediğinde
                    //sonsuz döngüden çıkıyorum.
                    break;
                }
            }
        }

    }
}

