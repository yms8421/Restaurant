using BilgeAdam.Restaurant.Common.Helper;

namespace BilgeAdam.Restaurant.Common.Models
{
    public sealed class Client : ModelBase
    {
        private Client()
        {

        }
        public string FullName { get; private set; }
        public string Phone { get; private set; }
        public Table Table { get; set; }
        /// <summary>
        /// Müşteri oluşturmayı sağlar.
        /// </summary>
        /// <param name="name">müşteri adı (isim boş olamaz ve isim soyisim biçiminde yazılmalıdır)</param>
        /// <param name="phone">müşteri telefonu (boş geçilmez)</param>
        /// <returns>oluşturulan müşteri</returns>
        public static Client CreateClient(string name, string phone)
        {
            ValidationHelper.CheckNullEntry(name, "isim");
            ValidationHelper.CheckNullEntry(phone, "telefon");
            ValidationHelper.CheckTextLength(name, 5, "isim");
            ValidationHelper.CheckIfRealName(name, "isim");
            ValidationHelper.CheckIfPhone(phone);

            var newClient = new Client
            {
                FullName = name,
                Phone = phone
            };
            return newClient;
        }
    }
}

/*
 Insan
 Turk
 Aydinli
 Erkek
 Mehmet
     class Insan {}
     class Turk : Insan {}
     class Aydinli : Turk {}
     class Erkek : Aydinli {}
     class Mehmet  : Erkek {}
     class Can  : Erkek {}
     class Bolulu : Turk {}
     class Ahmet : Erkek {}

    public void A()
    {
        object t = new Table();
        var o = new Order();

        if (t is Table) true
        if (t is ModelBase) true
        if (t is Order) false
        {
            var t01 = t as Table;
        }
    }

    Çalışma sıra:
    En base en önce çalışır

    Örneğimiz için:
        ModelBase : parent/base class
        Client, Table ... etc : child/derived class
*/
