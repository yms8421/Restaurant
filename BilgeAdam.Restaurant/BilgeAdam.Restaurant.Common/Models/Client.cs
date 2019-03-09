using BilgeAdam.Restaurant.Common.Helper;

namespace BilgeAdam.Restaurant.Common.Models
{
    public class Client : ModelBase
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public Table Table { get; set; }
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
