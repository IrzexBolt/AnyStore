//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnyStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_products
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<System.DateTime> added_date { get; set; }
        public Nullable<int> added_by { get; set; }
    }
}
