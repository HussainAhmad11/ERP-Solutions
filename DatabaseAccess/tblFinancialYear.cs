//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblFinancialYear
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFinancialYear()
        {
            this.tblTransactions = new HashSet<tblTransaction>();
            this.tblTransactions1 = new HashSet<tblTransaction>();
        }

        public int FinancialYearID { get; set; }
        public int UserID { get; set; }
        [Required(ErrorMessage = "*Required!")]
        public string FinancialYear { get; set; }
        [Required(ErrorMessage = "*Required!")]
        [DataType(DataType.Date)]
        public System.DateTime StartDate { get; set; }
        [Required(ErrorMessage = "*Required!")]
        [DataType(DataType.Date)]
        public System.DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions1 { get; set; }
    }
}
