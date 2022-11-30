//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            this.Artists = new HashSet<Artist>();
            this.NguoiDungs = new HashSet<NguoiDung>();
        }

        [Display(Name = "UserID")]
        [Required(ErrorMessage = "Please enter UserID ...")]
        public int AccountID { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter Email ...")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [NotMapped]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter Password ...")]
        [DataType(DataType.Password)]
        public string PasswordAccount { get; set; }
        [NotMapped]
        [Compare("PasswordAccount")]
        [Display(Name = "Re-enter Passsword")]
        [Required(ErrorMessage = "Please re-enter Password...")]
        [DataType(DataType.Password)]
        public string ConfirmPass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artist> Artists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
