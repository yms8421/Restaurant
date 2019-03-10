using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BilgeAdam.Restaurant.Common.Helper
{
    class ValidationHelper
    {
        public static void CheckNullEntry(string value, string message = "değer") // kullanıldığı yerde ikinci parametre verilmezse message deeğr ifadesini alır
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new FormatException($"{message} boş geçilemez");
            }
        }

        public static void CheckTextLength(string value, int length, string message = "değer")
        {
            if (value.Length < length)
            {
                throw new FormatException($"{message}, {length} karakterden az olamaz");
            }
        }

        public static void CheckIfRealName(string value, string message = "değer")
        {
            if (!value.Trim().Contains(" "))
            {
                throw new FormatException($"{message}, gerçek bir isim olmalı");
            }
        }

        public static void CheckIfPhone(string value, string message = "değer")
        {
            var phoneFormat = new Regex(@"^(?:\(?)(\d{3})(?:[\).\s]?)(\d{3})(?:[-\.\s]?)(\d{4})(?!\d)");//@ işareti string içinde escape karakter kullanmayı yasaklar (Verbatim string)
            if (!phoneFormat.Match(value).Success)
            {
                throw new FormatException($"{message} uygun telefon biçiminde değil");
            }
        }
    }
}
