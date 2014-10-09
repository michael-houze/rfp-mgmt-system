using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_DATABASE.Models
{
    public class VendorRegister
    {
       public RegisterViewModel RegisterViewModel{get; set;}
       public VENDOR VENDOR { get; set; }
       public List<VENDORCONTACT> VENDORCONTACTLIST { get; set; }
       public List<PRODUCTCATEGORY> PRODUCTCATEGORYLIST { get; set; }
    }
}