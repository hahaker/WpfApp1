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
    
    public partial class Bets
    {
        public int Bet_id { get; set; }
        public Nullable<int> Member_id { get; set; }
        public Nullable<int> Race_id { get; set; }
        public Nullable<int> Horse_id { get; set; }
        public decimal Bet_amount { get; set; }
        public Nullable<System.DateTime> Bet_date { get; set; }
    
        public virtual Horses Horses { get; set; }
        public virtual Members Members { get; set; }
        public virtual Races Races { get; set; }
    }
}
