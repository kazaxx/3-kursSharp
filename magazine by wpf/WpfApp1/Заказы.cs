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
    
    public partial class Заказы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заказы()
        {
            this.Продажи = new HashSet<Продажи>();
            this.Статус_заказа1 = new HashSet<Статус_заказа>();
        }
    
        public int ID_заказа { get; set; }
        public Nullable<System.DateTime> Дата_заказа { get; set; }
        public Nullable<int> ID_клиента { get; set; }
        public Nullable<int> ID_состава { get; set; }
        public Nullable<int> ID_сотрудника { get; set; }
        public string Статус_заказа { get; set; }
    
        public virtual Клиенты Клиенты { get; set; }
        public virtual Состав_заказа Состав_заказа { get; set; }
        public virtual Сотрудники Сотрудники { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Продажи> Продажи { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Статус_заказа> Статус_заказа1 { get; set; }
    }
}
