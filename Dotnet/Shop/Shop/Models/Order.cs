//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.Orderdetails = new HashSet<Orderdetail>();
        }
    
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public string Status { get; set; }
        public string Order_Date { get; set; }
        public Nullable<int> Total_Cost { get; set; }
    
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
        public virtual User User { get; set; }
    }
}