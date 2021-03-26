using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GörselProgramlamaÖdevSon
{
    public class LessonsManager
    {
        ArrayList dersler = new ArrayList();
        public void Add(int gelendeğer)
        {
            if (Kontrol(gelendeğer) == true)
            {
                Console.WriteLine("ders daha önce eklenmiş");
            }
            else
            {
                dersler.Add(gelendeğer);
                Console.WriteLine("Ders Eklendi");
            }
            dersler.Add(gelendeğer);
        }
        public void Delete(int gelendeğer)
        {
            Console.WriteLine("ders silindi");
            dersler.Remove(gelendeğer);
        }
        public bool Kontrol(int gelendeğer)
        {
            bool kontrol = false;
            for (int i = 0; i < dersler.Count; i++)
            {
                int databasedeğeri = (int)dersler[i];
                if (databasedeğeri == gelendeğer)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }
        public void Göster()
        {
            Console.WriteLine("Seçtiğiniz Dersler: ");

            for (int i = 0; i < dersler.Count; i++)
            {
                int ders = (int)dersler[i];
                Console.WriteLine(ders);
            }
        }
        public void SecilebilecekDersler()
        {
            Console.WriteLine("Seçebileceğiniz dersler ve numaraları aşağıdadır");
            Console.WriteLine("1.Dönem Dersleri");
            Console.WriteLine("Matematik I: 1001");
            Console.WriteLine("Kimya: 1002");
            Console.WriteLine("Fizik I: 1003");
            Console.WriteLine("Türkçe I: 1004");
            Console.WriteLine("Tarih I: 1005");
            Console.WriteLine("Bilgisayar Mühendisliğine Giriş : 1006");
            Console.WriteLine("Kariyer Planlama  : 1007");
            Console.WriteLine("Rek. Seçmeli I (Ders 1) : 1008\n");

            Console.WriteLine("2.Dönem Dersleri");
            Console.WriteLine("Matematik II: 2001");
            Console.WriteLine("C Programlama: 2002");
            Console.WriteLine("Fizik II: 2003");
            Console.WriteLine("Türkçe II: 2004");
            Console.WriteLine("Tarih II: 2005");
            Console.WriteLine("Lineer Cebir : 2006");
            Console.WriteLine("Rek. Seçmeli II (Ders 2) : 2007\n");

            Console.WriteLine("3.Dönem Dersleri");
            Console.WriteLine("Nesne Tabanlı Programlama: 3001");
            Console.WriteLine("Ayrık Matematik : 3002");
            Console.WriteLine("Veri Yapıları : 3003");
            Console.WriteLine("Mesleki İngilizce : 3004");
            Console.WriteLine("Diferansiyel Denklemler: 3005");
            Console.WriteLine("Elektrik Devreleri: 3006");
            Console.WriteLine("Seçmeli III (Ders 1) : 3007\n");

            Console.WriteLine("4.Dönem Dersleri");
            Console.WriteLine("Simulasyon Sistemleri : 4001");
            Console.WriteLine("Otomata Teorisi  : 4002");
            Console.WriteLine("Olasılık ve İstatistik  : 4003");
            Console.WriteLine("Sayısal Elektronik : 4004");
            Console.WriteLine("Proje Planlama ve Yönetimi : 4005");
            Console.WriteLine("Seçmeli IV (Ders 1) : 4006\n");

            Console.WriteLine("5.Dönem Dersleri");
            Console.WriteLine("Mikroişlemciler : 5001");
            Console.WriteLine("Algoritma Analizi   : 5002");
            Console.WriteLine("İşletim Sistemleri I   : 5003");
            Console.WriteLine("Bilgisayar Mimarisi I  : 5004");
            Console.WriteLine("Staj I  : 5005");
            Console.WriteLine("Seçmeli V (Ders 1) : 5006\n");

            Console.WriteLine("6.Dönem Dersleri");
            Console.WriteLine("Veritabanı Yönetim Sistemleri : 6001");
            Console.WriteLine("Sistem Programlama : 6002");
            Console.WriteLine("Gömülü Sistemler   : 6003");
            Console.WriteLine("Yazılım Mühendisliği  : 6004");
            Console.WriteLine("Sinyaller ve Sistemler  : 6005");
            Console.WriteLine("Seçmeli VI (Ders 1) : 6006\n");

            Console.WriteLine("7.Dönem Dersleri");
            Console.WriteLine("Bitirme Projesi I : 7001");
            Console.WriteLine("Staj II   : 7002");
            Console.WriteLine("Seçmeli VII (Ders 1)  : 7003\n");

            Console.WriteLine("8.Dönem Dersleri");
            Console.WriteLine("Veri İletişimi ve Bilgisayar Ağları : 8001");
            Console.WriteLine("Bitirme Projesi II : 8002");
            Console.WriteLine("Seçmeli VIII (Ders 1)  : 8003\n");
        }
    }
}
