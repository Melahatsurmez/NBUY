using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core
{
    public static class Jobs
    {
        public static string InitUrl(string url)
        {
            #region Açıklamalar
            /*Bu metot kendisine gerlen url değişkeninin içindeki
             * 1) Latin alfabesine çevirilrken problem çıkaran İ-i, ı-i gibi dönüşümleri yapacak
             * 2) Türkçe karakterlerin yerine latin alfabesindeli karşılıklarını koyacak 
             * 3) Boşluklar yerine - koyacak
             * 4) Nokta slashgibi karakterleri kaldıracak
             */
            #endregion
            #region SorunlukarakterlerÖdnüştürülüyor
            url = url.Replace("I", "i");
            url=url.Replace("İ", "i");
            url=url.Replace("ı", "i");
            #endregion
            #region KüçükHarfeDöüştürülür
            url = url.ToLower();
            #endregion
            #region TürkçeKarakterlerDeğiştiriliyor
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            #endregion
            #region SorunluKarakterlerKaldırılıyor
            url = url.Replace(" ", "-");
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("{", "");
            url = url.Replace("}", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            #endregion
            return url;





        }
    }
}
