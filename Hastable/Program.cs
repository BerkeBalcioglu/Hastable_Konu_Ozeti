using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();                    // Anahtar-Kilit uyumu vardır array gibidir lakin her değerin 1 eşi vardır. using system.collection.generic kullanır.
            ht.Add("22113017", "Berke Balcıoğlu");
            ht.Add("1923", "Cumuhuriyetin ilanı");             // Aynı değeri iki kere girersek anahar-kilit uyumu olmaz hata verir her değerin bir karşılığı vardır. 
            ht.Add("1919", "Samsuna çıkış");
            foreach (object x in ht.Keys) ;                    //Foreach ile bütün nesnelerin üzerinde tek seferde aynı işlem yapılır. For ile her nesnede ayrı işlem yapılır.
            {
                //Console.WriteLine(ht.[x]);                   // Hastableda ki objeleri x diye anlamlandırıp x kısımnına gelen value kısmındaki isimleri ekrana yazdırır.
                Console.WriteLine(ht["22113017"]);             // 22113017 li anahtara ait kilit nedir ekrana yaz.             
            }
            ht.Add("123456", new int[] { 1, 2, 3, 4, });       //123456 anahtarını tam sayı dizisine eşle ve ekrana yaz.
            Console.WriteLine(ht["123456"]);
            int[] dizi = (System.Int32[])ht["123456"];         // dizi int32 yi çevirip yazdır.
            for (int j = 0; j<dizi.Length; j++)
            {
                Console.WriteLine(dizi[j] + " ");
            }
            Console.WriteLine("************************************************************************************************************************");
            bool cevap = ht.Contains("22113017");              //bu hastable listesinde "22113017" numara ile uyuşan anahtarı bana bul.
            bool cevapc = ht.ContainsKey("22113017");          // anahtarda ara key.
            bool cevapv = ht.ContainsValue("22113017");        // değerler ksımında ara.
            Console.WriteLine(cevapc);
            Console.ReadKey();
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            ht.Remove("1923");                                 // adlı anahtardaki karşılığını sil
            //SORT VE REVERSE FONKSİYONALRI HASTABLE İÇİNDE KAYITLI DEĞİLDİR !!


        }
    }
}
