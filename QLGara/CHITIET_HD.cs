//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLGara
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIET_HD
    {
        public int SoHD { get; set; }
        public string MaCV { get; set; }
        public Nullable<int> TriGiaCV { get; set; }
        public Nullable<int> MaTho { get; set; }
        public Nullable<int> KhoanTho { get; set; }
    
        public virtual CONGVIEC CONGVIEC { get; set; }
        public virtual HOPDONG HOPDONG { get; set; }
    }
}
