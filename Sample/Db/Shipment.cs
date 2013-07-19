using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample
{
    public class Shipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ShipmentId { get; set; }

        public ShipmentStatus ShipmentStatus { get; set; }

        public virtual ICollection<ShipmentEntry> Entries { get; set; }
    }
}