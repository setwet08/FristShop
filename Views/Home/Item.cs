using sampleEco.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sampleEco.Views.Home
{
    public class Item
    {
        public tbl_product product { get; set; }
        public int Quantity { get; set; }
    }
}