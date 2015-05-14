namespace Exercise_8th.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class custDetail
    {
        [Key]
        [StringLength(50)]
        public string Cust_Account { get; set; }

        public int? Cust_Amount { get; set; }

        public DateTime? Cust_Date { get; set; }

        [StringLength(50)]
        public string Cust_Payee { get; set; }

        [StringLength(50)]
        public string Cust_Tag { get; set; }
    }
}
