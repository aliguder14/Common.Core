using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Common.Core
{
    public class StringIslemleri
    {

        public static int NumerikDegereCevir(string metin)
        {
            int sifirSayisi = metin.Length - 1;
            int sonuc = 0;
            foreach (char ch in metin)
            {
                int rakamDegeri = ch - '0';

                if (rakamDegeri >= 0 && rakamDegeri <= 9)
                {
                    sonuc += (rakamDegeri * (int)Math.Pow(10, sifirSayisi));
                    sifirSayisi--;
                }

                else
                {
                    return 0;
                }
            }

            return sonuc;

        }

        public static bool CheckNumeric(string metin)
        {

            foreach (char ch in metin)
            {
                //int rakamDegeri = ch - '0';

                if (ch < '0' || ch > '9')
                {
                    return false;
                }
            }

            return true;
        }

        public static string BuyukHarfYap(string metin)
        {
            char[] metinKarakterleri = metin.ToCharArray();

            for (int i = 0; i < metin.Length; i++)
            {
                char ch = metinKarakterleri[i];
                if (ch >= 'a' && ch <= 'z')
                {
                    metinKarakterleri[i] = (char)(ch - 32);
                }
            }

            return new string(metinKarakterleri);
        }

        public static string KucukHarfYap(string metin)
        {
            char[] metinKarakterleri = metin.ToCharArray();

            for (int i = 0; i < metin.Length; i++)
            {
                char ch = metinKarakterleri[i];
                if (ch >= 'A' && ch <= 'Z')
                {
                    metinKarakterleri[i] = (char)(ch + 32);
                }
            }

            return new string(metinKarakterleri);
        }

        public static string BuyukHarfYapTurkce(string metin)
        {
            char[] metinKarakterleri = metin.ToCharArray();
            char[] turkceKucukHarflar = { 'ç', 'ğ', 'ı', 'i', 'ö', 'ü', 'ş' };
            char[] turkceBuyukHarfler = { 'Ç', 'Ğ', 'I', 'İ', 'Ö', 'Ü', 'Ş' };

            for (int i = 0; i < metin.Length; i++)
            {
                char ch = metinKarakterleri[i];
                if ((ch >= 'a' && ch <= 'z') && ch != 'i')
                {
                    metinKarakterleri[i] = (char)(ch - 32);
                }

                else
                {
                    int indx = Array.IndexOf(turkceKucukHarflar, ch);

                    if (indx != -1)
                    {
                        metinKarakterleri[i] = turkceBuyukHarfler[indx];
                    }
                }
            }

            return new string(metinKarakterleri);

        }

        public static string KucukHarfYapTurkce(string metin)
        {
            char[] metinKarakterleri = metin.ToCharArray();
            char[] turkceKucukHarfler = { 'ç', 'ğ', 'ı', 'i', 'ö', 'ü', 'ş' };
            char[] turkceBuyukHarfler = { 'Ç', 'Ğ', 'I', 'İ', 'Ö', 'Ü', 'Ş' };

            for (int i = 0; i < metin.Length; i++)
            {
                char ch = metinKarakterleri[i];
                if ((ch >= 'A' && ch <= 'Z') && ch != 'I')
                {
                    metinKarakterleri[i] = (char)(ch - 32);
                }

                else
                {
                    int indx = Array.IndexOf(turkceBuyukHarfler, ch);

                    if (indx != -1)
                    {
                        metinKarakterleri[i] = turkceKucukHarfler[indx];
                    }
                }
            }

            return new string(metinKarakterleri);

        }

        public string TersCevir(string value)
        {
            char[] metinKarakterleri = value.ToCharArray();
            int sonInds = metinKarakterleri.Length - 1;

            for (int i = 0; i < metinKarakterleri.Length; i++)
            {
                char temp = metinKarakterleri[sonInds];
                metinKarakterleri[sonInds] = metinKarakterleri[i];
                metinKarakterleri[i] = temp;
                sonInds--;

            }

            return new string(metinKarakterleri);
        }

        public static bool CheckPolindrom(string metin)
        {
            int sonInds = metin.Length - 1;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != metin[sonInds])
                {
                    return false;
                }

                sonInds--;
            }

            return true;

        }

        public static string Replace(string metin, char eskiDeger, char yeniDeger)
        {
            char[] metinKarakterleri = metin.ToCharArray();

            for (int i = 0; i < metinKarakterleri.Length; i++)
            {
                if (metinKarakterleri[i] == eskiDeger)
                {
                    metinKarakterleri[i] = yeniDeger;
                }

            }

            return new string(metinKarakterleri);
        }

        public static bool Contains(string metin, string arananDeger)
        {

            if (metin.Length < arananDeger.Length)
            {
                return false;
            }

            int i = 0;

            while (i < (metin.Length - arananDeger.Length) + 1)
            {
                bool karakterlerUyuyorMu = true;
                int j;

                for (j = 0; j < arananDeger.Length; j++)
                {
                    if (metin[i] == arananDeger[j])
                    {
                        i++;
                    }

                    else
                    {
                        karakterlerUyuyorMu = false;
                        break;
                    }
                }

                if (karakterlerUyuyorMu)
                {
                    return true;
                }

                // İlk karakterler uymuyor ise. İlk sırada olmayam karakterler uymuyor ise i'yi artırma
                if (j == 0)
                {
                    i++;
                }
            }

            return false;

        }

        public static bool CheckCharactersEqual(string metin)
        {
            int stringUzunluk = metin.Length;
            if (stringUzunluk == 1 || stringUzunluk == 0)
            {
                return false;
            }

            char ilkKarakter = metin[0];

            for (int i = 1; i < stringUzunluk; i++)
            {
                // Eşit olmayan karakter bulununca metottan çık
                if (metin[i] != ilkKarakter)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckCharactersDifferent(string metin)
        {
            int stringUzunluk = metin.Length;
            if (stringUzunluk == 1 || stringUzunluk == 0)
            {
                return false;
            }

            Dictionary<char, bool> karakterSayilari = new Dictionary<char, bool>();
            for (int i = 0; i < stringUzunluk; i++)
            {
                if (karakterSayilari[metin[i]])
                {
                    return false;
                }

                karakterSayilari[metin[i]] = true;
            }

            return true;
        }

        public static string SubString(string metin, int startIndex, int length)
        {

            if (metin.Length == 0 || length == 0)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = startIndex; i < length; i++)
            {
                sb.Append(metin[i]);
            }

            return sb.ToString();

        }

        public static string SubString(string metin, int startIndex)
        {

            if (metin.Length == 0)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = startIndex; i < metin.Length; i++)
            {
                sb.Append(metin[i]);
            }

            return sb.ToString();

        }

        public static string Replace(string metin, string eskiDeger, string yeniDeger)
        {
            int yeniDegerUzunlugu = yeniDeger.Length;
            if (metin.Length < eskiDeger.Length || metin.Length < yeniDeger.Length)
            {
                return metin;
            }

            StringBuilder sb = new StringBuilder();
            int i = 0;
            int aramaBaslangicIndex = 0;
            while (i < (metin.Length - eskiDeger.Length) + 1)
            {
                bool karakterlerUyuyorMu = true;
                int j;

                for (j = 0; j < eskiDeger.Length; j++)
                {
                    if (metin[i] == eskiDeger[j])
                    {
                        i++;
                    }

                    else
                    {
                        karakterlerUyuyorMu = false;
                        break;
                    }
                }

                if (karakterlerUyuyorMu)
                {
                    // Bulunan değerden önceki Karakterleri de ekle
                    for (int k = aramaBaslangicIndex; k <= (i - yeniDegerUzunlugu); k++)
                    {
                        sb.Append(metin[k]);
                    }

                    sb.Append(yeniDeger);

                    // Aranan başlangıç index'ini aranan değerin bulunduğu index numarasına eşitle
                    aramaBaslangicIndex = i;
                }

                // İlk karakterler uymuyor ise. İlk sırada olmayam karakterler uymuyor ise i'yi artırma
                if (j == 0)
                {
                    i++;
                }
            }

            if (sb.Length == 0)
            {
                return metin;
            }

            else
            {
                for (i = aramaBaslangicIndex; i < metin.Length; i++)
                {
                    sb.Append(metin[i]);

                }

                return sb.ToString();
            }


        }

        public static bool StartWith(string metin, string arananDeger)
        {
            int metinUzunluk = metin.Length;
            int arananDegerUzunluk = arananDeger.Length;
            if (metinUzunluk == 0 || metinUzunluk < arananDegerUzunluk)
            {
                return false;
            }

            for (int i = 0; i < arananDegerUzunluk; i++)
            {
                if (metin[i] != arananDeger[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool EndWith(string metin, string arananDeger)
        {
            int metinUzunluk = metin.Length;
            int arananDegerUzunluk = arananDeger.Length;
            if (metinUzunluk == 0 || metinUzunluk < arananDegerUzunluk)
            {
                return false;
            }

            int arananDegerIndex = arananDegerUzunluk - 1;
            for (int i = metinUzunluk - 1; i >= (metinUzunluk - arananDegerUzunluk); i--)
            {
                if (metin[i] != arananDeger[arananDegerIndex])
                {
                    return false;
                }

                arananDegerIndex--;
            }

            return true;
        }

        public static string[] Split(string metin)
        {

            char[] ayracKarakterler = new char[] { '.', ':', ';', ',', '/', '\n', '\t', '?', '\\', ' ' };
            string[] kelimeler = metin.Split(ayracKarakterler, StringSplitOptions.RemoveEmptyEntries);

            return kelimeler;
        }

        public static string[] ParagraflaraAyir(string metin)
        {

            //string[] kelimeler = metin.Split("\n\n", StringSplitOptions.RemoveEmptyEntries);
            string[] kelimeler = Regex.Split(metin, @"\n{2," + int.MaxValue + "}");
            return kelimeler;
        }

        //public static string FindRepetitiveMaximumNumber(List<string> salesManager, List<int> salesCount)
        //{
        //    //Dictionary<int, int> sayilar = new Dictionary<int, int>();
        //    //foreach (var saleItem in salesCount)
        //    //{
        //    //    sayilar[saleItem]++;

        //    //}

        //    var sayilar = salesCount.GroupBy(x => x).Select(x => new { Anahtar = x.Key, Sayi = x.Count() });

        //    var siralanmisSayilar = sayilar.OrderByDescending(x => x.Sayi).ThenByDescending(x => x.Anahtar);


        //    return salesManager[index];
        //}

        public static List<List<int>> MergeSchedule(List<List<int>> scheduleList)
        {


            List<List<int>> mergedList = new List<List<int>>();
            for (int i = 0; i < scheduleList.Count; i++)
            {
                List<int> altListe = new List<int>();
                for (int j = 0; j < scheduleList[i].Count; j++)
                {

                    if (scheduleList[j][0] > scheduleList[i][0] && scheduleList[j][0] < scheduleList[i][1])
                    {
                        altListe.Add(scheduleList[i][0]);
                        altListe.Add(scheduleList[j][1]);
                    }

                    else
                    {
                        altListe.Add(scheduleList[i][0]);
                        altListe.Add(scheduleList[i][1]);
                    }
                }

                mergedList.Add(altListe);
            }

            return mergedList;

        }

        public static SplitInfo SingleSplit(string metin, char[] delimeter)
        {
            int baslangicIndex = 0;
            List<string> delimetedStrings = new List<string>();
            char[] ignoredChars = new char[] { '\n', ' ', '\t', '\r', '\b' };
            var delimetedChars = new List<char>();
            bool splitEdildi = false;
            for (int i = 0; i < metin.Length; i++)
            {
                if (ignoredChars.Contains(metin[i]))
                {
                    continue;
                }

                if (delimeter.Contains(metin[i]))
                {
                    if (!splitEdildi)
                    {
                        delimetedStrings.Add(metin.Substring(baslangicIndex, i - baslangicIndex).Trim());
                        baslangicIndex = i + 1;
                        splitEdildi = true;
                        delimetedChars.Add(metin[i]);
                    }

                }

                else
                {
                    splitEdildi = false;
                }

            }

            // Döngünün Split edilen son string i de ekle
            delimetedStrings.Add(metin.Substring(baslangicIndex, metin.Length - baslangicIndex).Trim());


            return new SplitInfo()
            {
                DelimetedStrings = delimetedStrings,
                DelimeterChars = delimetedChars
            };
        }

        public static string HarfSiraKodunuDondur(int siraNo)
        {
            const int alfabeSayisi = 26;
            int islenecekFark = 'A' - 1;

            if (siraNo <= 26)
            {
                return ((char)(siraNo + islenecekFark)).ToString();
            }

            else
            {
                int harfSayisi = (int)Math.Log(siraNo, alfabeSayisi);
                StringBuilder sbHarfSiraBuilder = new StringBuilder();
                char sonChar = ' ';

                if ((siraNo % alfabeSayisi) > 0)
                {
                    sonChar = (char)((siraNo % alfabeSayisi) + islenecekFark);
                    harfSayisi++;
                }

                else
                {
                    sonChar = (char)(alfabeSayisi + islenecekFark);

                }

                sbHarfSiraBuilder.Insert(0, sonChar);

                for (int i = harfSayisi - 1, sayi = siraNo; i >= 1; i--)
                {
                    char gelenChar = (char)((sayi / (int)Math.Pow(alfabeSayisi, i)) + islenecekFark);
                    sbHarfSiraBuilder.Insert(0, gelenChar);
                    sayi /= 26;
                }

                return sbHarfSiraBuilder.ToString();
            }

        }

        public static int HarfSiraKodunuSiraNumarasinaDondur(string harfSiraNo)
        {
            const int alfabeSayisi = 26;
            int islenecekFark = 'A' - 1;
            int eldeEdilenSiraNo = 0;

            int tersSiraNo = harfSiraNo.Length - 1;

            // İlk Karakter için yap
            int siraNo = (int)Math.Pow(alfabeSayisi, tersSiraNo) * (harfSiraNo[0] - islenecekFark);
            eldeEdilenSiraNo += siraNo;

            if (harfSiraNo.Length > 1)
            {
                for (int i = 1; i < harfSiraNo.Length - 1; i++, tersSiraNo--)
                {
                    siraNo = (int)Math.Pow(alfabeSayisi, tersSiraNo) * (harfSiraNo[i] - islenecekFark - 1);
                    eldeEdilenSiraNo += siraNo;
                }

                // Son karakter için yap
                siraNo = harfSiraNo[harfSiraNo.Length - 1] - islenecekFark;
                eldeEdilenSiraNo += siraNo;

            }

            return eldeEdilenSiraNo;



        }




    }
}
