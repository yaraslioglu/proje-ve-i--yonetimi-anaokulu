//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnaOkuluWebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demirbaslar
    {
        public Demirbaslar()
        {
            this.DemirbasMekanlaris = new HashSet<DemirbasMekanlari>();
        }
    
        public int DEMIRBASID { get; set; }
        public string Adi { get; set; }
        public string Turu { get; set; }
        public string Cinsi { get; set; }
        public Nullable<int> Adet { get; set; }
        public string Birim { get; set; }
        public string AlindigiYer { get; set; }
        public Nullable<System.DateTime> AlisTarihi { get; set; }
        public Nullable<decimal> GirisTutari { get; set; }
        public string AlisFaturaNo { get; set; }
        public Nullable<int> KdvOrani { get; set; }
        public Nullable<decimal> KdvTutari { get; set; }
        public string SatisYeri { get; set; }
        public Nullable<System.DateTime> SatisTarihi { get; set; }
        public Nullable<decimal> SatisTutari { get; set; }
        public string SatisFaturaNo { get; set; }
        public Nullable<decimal> SatisKdvTutari { get; set; }
        public string SatisNedeni { get; set; }
    
        public virtual ICollection<DemirbasMekanlari> DemirbasMekanlaris { get; set; }
    }
}
