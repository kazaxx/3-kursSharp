//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Запчасти
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Запчасти()
        {
            this.Склад = new HashSet<Склад>();
            this.Состав_заказа = new HashSet<Состав_заказа>();
        }
    
        public int ID_запчасти { get; set; }
        public string Название_запчасти { get; set; }
        public string Производитель { get; set; }
        public Nullable<decimal> Цена { get; set; }
        public Nullable<int> ID_поставщика { get; set; }
    
        public virtual Поставщики Поставщики { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Склад> Склад { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Состав_заказа> Состав_заказа { get; set; }
    }
}
