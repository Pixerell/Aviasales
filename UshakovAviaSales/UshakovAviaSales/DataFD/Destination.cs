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
    
    public partial class Destination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Destination()
        {
            this.FlightDatas = new HashSet<FlightData>();
            this.FlightDatas1 = new HashSet<FlightData>();
        }
    
        public int idDestination { get; set; }
        public int idCity { get; set; }
        public string Aeroport { get; set; }
        public Nullable<decimal> TimeZone { get; set; }
        public Nullable<decimal> Lat { get; set; }
        public Nullable<decimal> Long { get; set; }
        public int Visits { get; set; }
    
        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightData> FlightDatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightData> FlightDatas1 { get; set; }
    }
}