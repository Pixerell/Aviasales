//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UshakovAviaSales.DataFD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Notifications = new HashSet<Notification>();
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int idClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GenderCode { get; set; }
        public int PassportSeries { get; set; }
        public int PassportNumber { get; set; }
        public int intPassportType { get; set; }
        public Nullable<int> idUser { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual PassportType PassportType { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
