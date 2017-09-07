using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloomySpider
{
    public static class KiwoomUtil
    {
        public static string ToPersentage(this string data)
        {
            string result = string.Empty;
            if (data.Substring(0, 1).Equals("-"))
            {
                result = double.Parse("-" + data.Remove(0, 1).TrimStart('0')).ToString("0.00");
            }
            else
            {
                result = double.Parse(data.TrimStart('0')).ToString("0.00");
            }
            return result;
        }

        public static string ToPrice(this string data)
        {
            string result = string.Empty;
            if (data.Substring(0, 1).Equals("-"))
            {
                result = "-" + data.Remove(0, 1).TrimStart('0');
            }
            else
            {
                result = data.TrimStart('0');
            }
            return result;
        }
    }
}
