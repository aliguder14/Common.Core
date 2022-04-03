using System.Globalization;
using System.Text;

namespace Common.Core
{
    public static class StringIslemleriExtension
    {

        public static bool IsNullOrEmpty(this string str)
        {

            return string.IsNullOrEmpty(str);
        }

        public static bool IsNullOrEmptyWhiteSpace(this string str)
        {

            return string.IsNullOrWhiteSpace(str);
        }

        public static string ToTitleCase(this string str)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(str);
        }

        public static string ToTitleCase(this string str, CultureInfo culture)
        {
            TextInfo textInfo = culture.TextInfo;
            return textInfo.ToTitleCase(str);
        }

        public static string Add(this string str, string strItem)
        {
            StringBuilder sb = new StringBuilder(str);
            sb.Append(strItem);

            return sb.ToString();

        }

    }
}
