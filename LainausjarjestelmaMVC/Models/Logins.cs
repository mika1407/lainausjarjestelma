//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LainausjarjestelmaMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Logins
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Logins()
        {
            this.Lainaajat = new HashSet<Lainaajat>();
        }
    
        public int LoginID { get; set; }

        //Määritetään muuttujan näyttönimi
        [Display(Name = "Sähköposti")]
        //Määritetään väärän/puuttuvan sähköpostiosoitteen virheilmoitus
        [Required(ErrorMessage = "Anna sähköpostiosoite!")]
        public string Email { get; set; }

        //Määritetään muuttujan näyttönimi
        [DataType(DataType.Password)]
        //Määritetään väärän/puuttuvan salasanan virheilmoitus
        [Required(ErrorMessage = "Anna salasana!")]
        public string Salasana { get; set; }
        public string Kirjautumisvirhe { get; set; }
        public Nullable<bool> Admin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lainaajat> Lainaajat { get; set; }
    }
}
