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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class tblEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEmployee()
        {
            this.tblPayrolls = new HashSet<tblPayroll>();
        }

        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "*Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*Required")]
        public string ContactNo { get; set; }
        public string Photo { get; set; }
        [Required(ErrorMessage = "*Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Required")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public string CNIC { get; set; }
        [Required(ErrorMessage = "*Required")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "*Required")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "*Required")]
        public double MonthlySalary { get; set; }
        public int BranchID { get; set; }
        public int CompanyID { get; set; }
        public Nullable<int> UserID { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }

        public virtual tblBranch tblBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPayroll> tblPayrolls { get; set; }
        public virtual tblCompany tblCompany { get; set; }
    }
}
