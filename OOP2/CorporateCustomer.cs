using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //miras, inheritance : bunun anlamı custımer özelliklerinin diğer classlara eklemek demektir.
    //
    class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
