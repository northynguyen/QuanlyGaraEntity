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
    
    public partial class CONGVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONGVIEC()
        {
            this.CHITIET_HD = new HashSet<CHITIET_HD>();
        }
    
        public string MaCV { get; set; }
        public string NoiDungVC { get; set; }
        public Nullable<int> TriGiaCV { get; set; }
        public Nullable<int> KhoanTho { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HD> CHITIET_HD { get; set; }
    }
}