//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sezonowosc
    {
        public int NrInwentarzowy { get; set; }
        public Nullable<bool> Styczen { get; set; }
        public Nullable<bool> Luty { get; set; }
        public Nullable<bool> Marzec { get; set; }
        public Nullable<bool> Kwiecien { get; set; }
        public Nullable<bool> Maj { get; set; }
        public Nullable<bool> Czerwiec { get; set; }
        public Nullable<bool> Lipiec { get; set; }
        public Nullable<bool> Sierpien { get; set; }
        public Nullable<bool> Wrzesien { get; set; }
        public Nullable<bool> Pazdziernik { get; set; }
        public Nullable<bool> Listopad { get; set; }
        public Nullable<bool> Grudzien { get; set; }
    
        public virtual Amortyzacja Amortyzacja { get; set; }
    }
}