using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //field = public string FirstName;
        public int Id { get; set; }
        // aşağıdaki ise bir Property.

        // bir classın özelliklerini tanımlarken prop kullanırız.
        // peki neden? encopsulation
        // neyi set edeceğim? 
        // bir field oluşturuz ve set ve getin içerisine bu fieldı yazarız.
        // içerisinde başka bir şey yapmak istersek prop bu durum için daha etkilidir.
        // buna implementasyon gizlenmesi yani encopsulation denir. fakat bu örnek pek kullanılmaz.
        //ör:
        string _firstName;
        public string FirstName { get { return "Mr." + _firstName; } set { _firstName = value; } }
        //bunun yerine otoproperty kullanılıyor bizim yaptığımız aşağıdaki gibi.
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
