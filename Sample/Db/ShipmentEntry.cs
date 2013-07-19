using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample
{
    public class ShipmentEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int DrugUnitId { get; set; }

        [ForeignKey("DrugUnitId")]
        public virtual DrugUnit DrugUnit { get; set; }


        public Guid ShipmentId { get; set; }

        [ForeignKey("ShipmentId")]
        public virtual Shipment Shipment { get; set; }
    }
}