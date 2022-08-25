using System;
using System.Collections.Generic;
using System.Text;

namespace GoodFoodMobile.Models
{
    public class User
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string  firstName { get; set; }
        public string  email { get; set; }
        public string  password { get; set; }
        public string  address { get; set; }
        public string  postalCode { get; set; }
        public string  city { get; set; }

    }
}
