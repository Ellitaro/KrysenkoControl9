//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KrysenkoControl9.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeCompetion
    {
        public TypeCompetion()
        {
            this.Accounting = new HashSet<Accounting>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> DirectionID { get; set; }
    
        public virtual ICollection<Accounting> Accounting { get; set; }
        public virtual Direction Direction { get; set; }
    }
}
