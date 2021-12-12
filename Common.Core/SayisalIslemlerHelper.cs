using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Common.Core
{
    public class SayisalIslemlerHelper
    {
        public int RakamlariTopla(int total)
        {
            int rakamlarinToplami = 0;
            for (int n = total; n > 0; n /= 10)
            {
                int rakam = n % 10;
                rakamlarinToplami += rakam;
            }

            return rakamlarinToplami;
        }

        public int BasamkSayisiniAl(int num)
        {

            int basamakSayisi = 0;
            for (int n = num; n > 0; n /= 10)
            {
                basamakSayisi++;
            }

            return basamakSayisi;
        }

        public int EnBuyukRakamiAl(int num)
        {

            int enBuyukRakam = 0;

            for (int n = num; n > 0; n /= 10)
            {
                int rakam = n % 10;

                if (rakam > enBuyukRakam)
                {
                    enBuyukRakam = rakam;
                }
            }

            return enBuyukRakam;

        }


        public int EnKucukRakamiAl(int num)
        {
            int enKucukRakam = 9;

            for (int n = num; n > 0; n /= 10)
            {
                int rakam = n % 10;

                if (rakam < enKucukRakam)
                {
                    enKucukRakam = rakam;
                }
            }

            return enKucukRakam;

        }

        public bool RakamlarEsitMi(int num)
        {
            int basamakSayisi = 0;
            int alinanRakam = 0;
            int esitRakamSaiyisi = 0;
            for (int n = num; n > 0; n /= 10)
            {
                int rakam = n % 10;

                if (basamakSayisi == 0)
                {
                    alinanRakam = rakam;
                }

                else if (basamakSayisi > 0 && alinanRakam == rakam)
                {
                    esitRakamSaiyisi++;
                }

                // Rakamlar birinden farklı çıkarsa metottan false olcak şekilde çık
                else
                {
                    return false;
                }

                alinanRakam = rakam;
                basamakSayisi++;

            }

            if (esitRakamSaiyisi == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool RakamlarFarkliMi(int num)
        {

            Dictionary<int, bool> dicRakamSayilari = new Dictionary<int, bool>();
            int rakamSayisi = 0;
            for (int n = num; n > 0; n /= 10)
            {
                int rakam = n % 10;

                if (dicRakamSayilari[rakam])
                {
                    return false;
                }

                dicRakamSayilari[rakam] = true;
                rakamSayisi++;
            }

            return true;

        }

        public BigInteger FaktoriyelAl(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }

            BigInteger sonuc = 1;
            for (int i = 2; i <= num; i++)
            {
                sonuc *= i;
            }

            return sonuc;
        }

        public static bool AsalSayiMi(int number)
        {

            if (number == 0 || number == 1)
            {
                return false;
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public long FibonacciSayiAl(uint siraNo)
        {
            long birinciSayi = 0;
            long ikinciSayi = 1;
            long sonSayi = 0;

            if (siraNo < 3)
            {
                return siraNo - 1;
            }

            for (int i = 1; i <= siraNo - 3; i++)
            {
                sonSayi = birinciSayi + ikinciSayi;
                birinciSayi = ikinciSayi;
                ikinciSayi = sonSayi;
            }

            sonSayi = birinciSayi + ikinciSayi;

            return sonSayi;
        }

        public bool RakamIceriyorMu(byte arananRakam, long num)
        {
            for (long n = num; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);

                if (arananRakam == rakam)
                {
                    return true;

                }

            }

            return false;
        }

        public double KuvvetAl(double num, double kuvvet)
        {

            if (kuvvet == 0)
            {
                return 1;
            }

            num = kuvvet < 0 ? 1 / num : num;

            double sonuc = num;

            for (long i = 2; i <= kuvvet; i++)
            {
                sonuc *= num;
            }

            return sonuc;
        }


        public decimal MutlakDegerAl(decimal num)
        {

            if (num < 0)
            {
                return 0 - num;
            }

            return num;
        }

        public static IEnumerable<byte> RakamlarListesiniAl(long num)
        {

            List<byte> rakamlar = new List<byte>();

            for (long n = num; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                rakamlar.Insert(0, rakam);

            }

            return rakamlar;
        }

        public static bool CheckPalindrome(long number)
        {
            long tersCevrilenSayi = 0;
            for (long n = number; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                tersCevrilenSayi = tersCevrilenSayi * 10 + rakam;
            }

            if (number == tersCevrilenSayi)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static long TersCevir(long num)
        {

            long tersCevrilenSayi = 0;
            for (long n = num; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                tersCevrilenSayi = tersCevrilenSayi * 10 + rakam;
            }

            return tersCevrilenSayi;
        }

        public static List<string> FizzBuzzListesiGetir(IEnumerable<int> sayilar)
        {
            List<string> fizzBuzzListesi = new List<string>();
            foreach (int sayi in sayilar)
            {
                if (sayi % 3 == 0)
                {
                    fizzBuzzListesi.Add($"{sayi} FIZZ");
                }

                else if (sayi % 5 == 0)
                {
                    fizzBuzzListesi.Add($"{sayi} BUZZ");
                }

                if (sayi % 15 == 0)
                {
                    fizzBuzzListesi.Add($"{sayi} FIZZBUZZ");
                }

                else
                {
                    fizzBuzzListesi.Add($"{sayi} ");

                }
            }

            return fizzBuzzListesi;
        }


        public static long OndalikTabanaCevir(long num, int taban)
        {

            long sonuc = 0;
            int kuvvet = 0;
            for (long n = num; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                sonuc += ((long)Math.Pow(taban, kuvvet) * rakam);
                kuvvet++;
            }

            return sonuc;
        }

        public static long OndalikTabandanGelenTabanaCevir(long num, int taban)
        {
            if (taban == 1)
            {
                return 0;
            }

            long sonuc = 0;
            int kuvvet = 0;
            long n;


            for (n = num; n >= taban; n /= taban)
            {
                sonuc += ((n % taban) * (long)Math.Pow(10, kuvvet));
                kuvvet++;
            }

            sonuc += ((n / taban) * (long)Math.Pow(10, kuvvet));

            return sonuc;
        }

        public static double LogaritmaAl(double sayi, double tabanSayi)
        {

            if (sayi > 1 && tabanSayi == 1)
            {
                return 0;
            }

            double cikanSayi = sayi;
            int kuvvetSayisi = 1;

            while (sayi < tabanSayi)
            {
                cikanSayi *= sayi;
                kuvvetSayisi++;
            }

            return kuvvetSayisi;

        }




        public static string SayiyiYaziIleOku(long num)
        {
            if (num == 0)
            {
                return "Sıfır";
            }

            Dictionary<int, string> rakamOkunuslari = new Dictionary<int, string>()
            {
                {1,"Bir" },{2,"İki"},{3,"Üç"},{4,"Dört"},{5,"Beş"},
                {6,"Altı"}, {7,"Yedi"},{8,"Sekiz"},{9,"Dokuz"}
            };

            Dictionary<int, string> onlarBasamagiOkunuslari = new Dictionary<int, string>()
            {
                {1,"On" },{2,"Yirmi"},{3,"Otuz"},{4,"Kırk"},{5,"Elli"},
                {6,"Altmış"}, {7,"Yetmiş"},{8,"Sekesn"},{9,"Doksan"}
            };

            Dictionary<int, string> basamakDegeriOkunuslari = new Dictionary<int, string>()
            {
                {4,"Bin" },{7,"Milyon"},{10,"Milyar"},{13,"Tirilyon"},{16,"Kantrilyon"},
                {19,"Kentilyon"}, {22,"Seksilyon"},{25,"Septilyon"},{28,"Oktilyon"},
                {31,"Nonilyon"}
            };

            StringBuilder sbSayiOkunuslari = new StringBuilder();
            int basamakDegeri = 1;
            bool binlerBasamagindaSifirBulundu = false;

            for (long n = num; n > 0; n /= 10)
            {
                int rakam = (int)(n % 10);

                if (rakam == 0)
                {
                    if (basamakDegeri > 1 && basamakDegeri % 3 == 1)
                    {
                        binlerBasamagindaSifirBulundu = true;
                    }

                    basamakDegeri++;
                    continue;
                }

                if (basamakDegeri % 3 == 1)
                {

                    if (basamakDegeri > 1)
                    {
                        sbSayiOkunuslari.Insert(0, basamakDegeriOkunuslari[basamakDegeri]);
                    }

                    if (basamakDegeri != 4 || rakam > 1 || n > 10)
                    {
                        sbSayiOkunuslari.Insert(0, rakamOkunuslari[rakam]);
                    }

                }

                else if (basamakDegeri % 3 == 2)
                {
                    if (binlerBasamagindaSifirBulundu)
                    {
                        sbSayiOkunuslari.Insert(0, basamakDegeriOkunuslari[basamakDegeri - 1]);
                        binlerBasamagindaSifirBulundu = false;
                    }

                    sbSayiOkunuslari.Insert(0, onlarBasamagiOkunuslari[rakam]);
                }

                else
                {
                    if (binlerBasamagindaSifirBulundu)
                    {
                        sbSayiOkunuslari.Insert(0, basamakDegeriOkunuslari[basamakDegeri - 2]);
                        binlerBasamagindaSifirBulundu = false;
                    }

                    sbSayiOkunuslari.Insert(0, "Yüz");

                    if (rakam > 1)
                    {
                        sbSayiOkunuslari.Insert(0, rakamOkunuslari[rakam]);
                    }

                }

                basamakDegeri++;
            }

            return sbSayiOkunuslari.ToString();

        }

        public static double DortIslemSonucunuDondur(string islem)
        {

            char[] toplamaCikarmaIslemAyraclari = new char[] { '+', '-' };
            char[] carpmaBolmeIslemAyraclari = new char[] { '*', '/', '%' };
            List<string> subOperands;
            List<char> delimtersInCaprmaBolme;

            //string[] operands = islem.Split(toplamaCikarmaIslemAyraclari, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim())
            //               .Where(p => !string.IsNullOrWhiteSpace(p))
            //               .ToArray();

            //string[] operands = Regex.Split(islem, @"\s").Select(p => p.Trim())
            //               .Where(p => !string.IsNullOrWhiteSpace(p))
            //               .ToArray();




            //string[] operands = islem.Split(new string[] { "+","-"},StringSplitOptions.None).Select(p => p.Trim())
            //               .Where(p => !string.IsNullOrWhiteSpace(p))
            //               .ToArray();



            Dictionary<char, Func<double, double, double>> islemTanimlari = new Dictionary<char, Func<double, double, double>>()
            {
                {'+', (x,y) => x + y },
                {'-', (x,y) => x - y },
                {'*', (x,y) => x * y },
                {'/', (x,y) => x / y },
                {'%', (x,y) => x % y }
            };

            SplitInfo toplamaCikarmaSplitInfo = StringIslemleri.SingleSplit(islem, toplamaCikarmaIslemAyraclari);

            List<char> operrators = toplamaCikarmaSplitInfo.DelimeterChars;
            List<string> operands = toplamaCikarmaSplitInfo.DelimetedStrings;


            //List<char> delimtersInIslemSiralanmis = delimtersInIslem.ToList();

            //Dictionary<int,char> delimtersInTopmaCikarma = new();
            //for (int i = 0; i < islem.Length; i++)
            //{
            //    if (toplamaCikarmaIslemAyraclari.Contains(islem[i]))
            //    {
            //        delimtersInTopmaCikarma.Add(i, islem[i]);
            //    }
            //}


            //delimtersInIslemSiralanmis.Sort();

            string sonucIfade = operands[0];

            if (!double.TryParse(sonucIfade, out double sonuc))
            {
                if (sonucIfade.StartsWith('(') && sonucIfade.EndsWith(')'))
                {
                    string parantIciIslem = sonucIfade.Substring(1, sonucIfade.Length - 2);
                    sonuc = DortIslemSonucunuDondur(parantIciIslem);
                }


                else
                {
                    subOperands = StringIslemleri.SingleSplit(sonucIfade, carpmaBolmeIslemAyraclari).DelimetedStrings;
                    delimtersInCaprmaBolme = StringIslemleri.SingleSplit(sonucIfade, carpmaBolmeIslemAyraclari).DelimeterChars;

                    if (!double.TryParse(subOperands[0], out double subSonuc))
                    {
                        throw new Exception("Geçersiz Format");

                    }

                    for (int j = 0; j < delimtersInCaprmaBolme.Count; j++)
                    {
                        if (!double.TryParse(subOperands[j + 1], out double deger))
                        {
                            throw new Exception("Geçersiz Format");
                        }

                        subSonuc = islemTanimlari[delimtersInCaprmaBolme[j]].Invoke(subSonuc, deger);
                    }

                    sonuc = subSonuc;
                }
            }

            for (int i = 0; i < operands.Count - 1; i++)
            {
                sonucIfade = operands[i + 1];
                if (!double.TryParse(operands[i + 1], out double deger))
                {
                    if (sonucIfade.StartsWith('(') && sonucIfade.EndsWith(')'))
                    {
                        string parantIciIslem = sonucIfade.Substring(1, sonucIfade.Length - 2);
                        deger = DortIslemSonucunuDondur(parantIciIslem);
                    }

                    else
                    {
                        SplitInfo carpmaBolmeSplitInfo = StringIslemleri.SingleSplit(sonucIfade, carpmaBolmeIslemAyraclari);
                        subOperands = carpmaBolmeSplitInfo.DelimetedStrings;
                        delimtersInCaprmaBolme = carpmaBolmeSplitInfo.DelimeterChars;

                        if (!double.TryParse(subOperands[0], out double subSonuc))
                        {
                            throw new Exception("Geçersiz Format");
                        }

                        for (int j = 0; j < subOperands.Count - 1; j++)
                        {
                            if (!double.TryParse(subOperands[j + 1], out double subdeger))
                            {
                                throw new Exception("Geçersiz Format");
                            }

                            subSonuc = islemTanimlari[delimtersInCaprmaBolme[j]].Invoke(subSonuc, subdeger);
                        }

                        deger = subSonuc;
                    }
                }

                sonuc = islemTanimlari[operrators[i]].Invoke(sonuc, deger);

            }

            return sonuc;
        }


    }

    public class OpertorComparer : Comparer<char>
    {
        public override int Compare(char ilk, char ikinci)
        {
            if (ilk == '*' && ikinci == '+')
            {
                return 1;
            }

            else if (ilk == '+' && ikinci == '-')
            {
                return -1;
            }

            else if (ilk == '*' && ikinci == '-')
            {
                return 1;
            }

            else if (ilk == '-' && ikinci == '*')
            {
                return -1;
            }

            else if (ilk == '/' && ikinci == '+')
            {
                return 1;
            }

            else if (ilk == '+' && ikinci == '/')
            {
                return -1;
            }

            else if (ilk == '/' && ikinci == '-')
            {
                return 1;
            }

            else if (ilk == '-' && ikinci == '/')
            {
                return -1;
            }

            else if (ilk == '+' && ikinci == '-' || ilk == '-' && ikinci == '+')
            {
                return 0;
            }

            else if (ilk == '*' && ikinci == '/' || ilk == '/' && ikinci == '*')
            {
                return 0;
            }

            else
            {
                return 0;
            }
        }
    }
}
