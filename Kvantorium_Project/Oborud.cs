//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kvantorium_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oborud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oborud()
        {
            this.GetOborudovanie = new HashSet<GetOborudovanie>();
            this.PeredachaOborud = new HashSet<PeredachaOborud>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ColOb { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GetOborudovanie> GetOborudovanie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PeredachaOborud> PeredachaOborud { get; set; }
    }
}