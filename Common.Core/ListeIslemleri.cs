using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Common.Core
{
    public class ListeIslemleri
    {
        public static T[] ToArray<T>(List<T> liste)
        {
            T[] arr = new T[liste.Count];

            int i = 0;
            foreach (var listeItem in liste)
            {
                arr[i] = listeItem;
                i++;
            }

            return arr;

        }


        public static void AddRAnge<T>(ICollection<T> liste, ICollection<T> rangeListe)
        {

            foreach (var range in rangeListe)
            {
                liste.Add(range);
            }

        }

        public static int AltKumeSayisiniAl<T>(IEnumerable<T> liste)
        {
            int count = liste.Count();
            int altKumeSayisi = (int)Math.Pow(2, count);

            return altKumeSayisi;

        }

        public static List<List<T>> AltKumelerinListesiniAl<T>(List<T> liste)
        {
            List<List<T>> altKumeler = new List<List<T>>();

            altKumeler.Add(new List<T>());
            //altKumeler.Add(liste);

            for (int i = 0; i < liste.Count; i++)
            {

                for (int j = 0; j < liste.Count; j++)
                {
                    List<T> altListe = new List<T>();
                    for (int k = j; k < i + 1; k++)
                    {
                        altListe.Add(liste[k]);
                    }

                    altKumeler.Add(altListe);
                }

            }

            return altKumeler;
        }


        public static double Max(IEnumerable<double> liste)
        {
            double max = liste.ElementAt(0);
            foreach (var deger in liste)
            {
                if (deger > max)
                {
                    max = deger;
                }
            }

            return max;
        }

        public static double Min(IEnumerable<double> liste)
        {
            double min = liste.ElementAt(0);

            foreach (var deger in liste)
            {
                if (deger < min)
                {
                    min = deger;
                }
            }

            return min;
        }

        public static void Swap<T>(T[] arr, int birinciIndex, int ikinciIndex)
        {

            if (birinciIndex >= arr.Length || birinciIndex < 0 || ikinciIndex >= arr.Length || ikinciIndex < 0)
            {
                return;
            }

            T temp = arr[ikinciIndex];
            arr[ikinciIndex] = arr[birinciIndex];
            arr[birinciIndex] = temp;

        }

        public static bool IsOrdered<T>(IEnumerable<T> list) where T : IComparable
        {
            //List<T> arr = ((IEnumerable<T>)list).ToList();

            for (int i = 1; i < list.Count(); i++)
            {
                if (list.ElementAt(i).CompareTo(list.ElementAt(i - 1)) == -1)
                {
                    return false;
                }
            }

            return true;

        }

        public static bool IsNullOrEmpty(IEnumerable list)
        {

            if (list == null)
            {
                return true;
            }

            foreach (var item in list)
            {
                return false;
            }

            return true;
        }

        public static bool IsNullOrEmpty<T>(IEnumerable<T> list)
        {

            if (list == null || list.Any())
            {
                return true;
            }

            return false;
        }


        public static bool SequentialEqual<T>(IEnumerable<T> liste1, IEnumerable<T> liste2)
        {
            int i = 0;

            if (liste1.Count() != liste2.Count())
            {
                return false;
            }

            foreach (var item2 in liste2)
            {
                if (!item2.Equals(liste1.ElementAt(i)))
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public static ObservableCollection<T> ToObservable<T>(IEnumerable<T> liste1)
        {
            return new ObservableCollection<T>(liste1);
        }

        public static decimal MaksimumRepeatedNumber<T>(IEnumerable<decimal> liste)
        {

            var tekrarEdenSayilar = liste.GroupBy(x => x).Select(x => new
            {
                Sayi = x.Count(),
                Deger = x.Key
            }).ToArray();

            decimal maxTekrarEdenSayi = tekrarEdenSayilar[0].Deger;

            for (int i = 1; i < tekrarEdenSayilar.Length; i++)
            {
                if (tekrarEdenSayilar[i].Deger > maxTekrarEdenSayi)
                {
                    maxTekrarEdenSayi = tekrarEdenSayilar[i].Deger;
                }
            }

            return maxTekrarEdenSayi;


        }

        public static decimal MinimumRepeatedNumber<T>(IEnumerable<decimal> liste)
        {

            var tekrarEdenSayilar = liste.GroupBy(x => x).Select(x => new
            {
                Sayi = x.Count(),
                Deger = x.Key
            }).ToArray();

            decimal minimumTekrarEdenSayi = tekrarEdenSayilar[0].Deger;

            for (int i = 1; i < tekrarEdenSayilar.Length; i++)
            {
                if (tekrarEdenSayilar[i].Deger < minimumTekrarEdenSayi)
                {
                    minimumTekrarEdenSayi = tekrarEdenSayilar[i].Deger;
                }
            }

            return tekrarEdenSayilar.FirstOrDefault().Deger;
        }



    }
}
