//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pekarnia.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ElementGoods
    {
        public int idElement { get; set; }
        public int idGoods { get; set; }
        public int idIngridients { get; set; }
    
        public virtual Goods Goods { get; set; }
        public virtual ingridients ingridients { get; set; }
    }
}
