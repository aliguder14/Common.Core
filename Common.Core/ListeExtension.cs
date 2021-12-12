using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common.Core
{
    public static class ListeExtension
    {
        public static void ForEach<TSource>(this IEnumerable<TSource> liste, Action<TSource> action)
        {

            foreach (var item in liste)
            {
                action.Invoke(item);
            }
        }

        public static IEnumerable<T> Select<TSource, T>(this IEnumerable<TSource> liste, Func<TSource, T> selector)
        {

            foreach (var item in liste)
            {
                yield return selector.Invoke(item);
            }
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> liste, Predicate<T> whereClause)
        {

            foreach (var item in liste)
            {
                if (whereClause(item))
                {
                    yield return item;
                }
            }


        }

        public static List<T> ToList<T>(this IEnumerable<T> liste)
        {
            return new List<T>(liste);
        }

        public static T[] ToArray<T>(this IEnumerable<T> liste)
        {

            T[] arr = new T[liste.Count()];

            int i = 0;
            foreach (var item in liste)
            {
                arr[i] = item;
                i++;
            }

            return arr;
        }

        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> liste)
        {
            return new ObservableCollection<T>(liste);
        }

        public static Stack<T> ToStack<T>(this IEnumerable<T> liste)
        {
            return new Stack<T>(liste);
        }

        public static Queue<T> ToQueue<T>(this IEnumerable<T> liste)
        {
            return new Queue<T>(liste);
        }

        public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> liste)
        {
            return new LinkedList<T>(liste);
        }

        public static ConcurrentBag<T> ToConcurrentBag<T>(this IEnumerable<T> liste)
        {
            return new ConcurrentBag<T>(liste);
        }
        public static ArrayList ToArrayList<T>(this IEnumerable<T> liste)
        {
            if (liste is ICollection)
            {
                return new ArrayList((ICollection)liste);
            }

            else
            {
                return null;
            }
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> liste)
        {
            if (liste?.Any() != true)
            {
                return true;
            }

            return false;
        }

        public static List<T> ToList<T>(this DataTable dt)
        {
            List<T> liste = new List<T>();
            IEnumerable<PropertyInfo> propertyInfos = typeof(T).GetProperties().Where(x => x.CanWrite);


            foreach (DataRow dataRow in dt.Rows)
            {
                T item = Activator.CreateInstance<T>();

                foreach (DataColumn dataColumn in dt.Columns)
                {
                    var property = propertyInfos.Where(x => x.Name == dataColumn.ColumnName).FirstOrDefault();

                    if (property != null)
                    {
                        if (property.PropertyType == dataRow[dataColumn.ColumnName].GetType())
                        {
                            property.SetValue(item, dataRow[dataColumn.ColumnName]);
                        }
                    }


                }

                if (dt.Columns.Count > 0)
                {
                    liste.Add(item);
                }
            }

            return liste;
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> liste)
        {
            DataTable dt = new DataTable();
            IEnumerable<PropertyInfo> listeProperties = typeof(T).GetProperties().Where(x => x.CanWrite && x.CanRead);
            foreach (PropertyInfo property in listeProperties)
            {
                dt.Columns.Add(property.Name, property.PropertyType);
            }

            foreach (var listeItem in liste)
            {
                DataRow dr = dt.NewRow();

                foreach (DataColumn column in dt.Columns)
                {
                    PropertyInfo propertyInfo = listeProperties.Where(x => x.Name == column.ColumnName).FirstOrDefault();

                    if (propertyInfo != null)
                    {
                        dr[column.ColumnName] = propertyInfo.GetValue(listeItem);
                    }
                }

                dt.Rows.Add(dr);

            }

            return dt;
        }

        public static string StringJoin<T>(this IEnumerable<T> liste, string ayrac)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerator<T> rc = liste.GetEnumerator();

            rc.MoveNext();
            sb.Append(rc.Current.ToString());

            while (rc.MoveNext())
            {
                sb.Append($"{ayrac} {rc.Current.ToString()}");

            }

            return sb.ToString();

        }
    }
}
