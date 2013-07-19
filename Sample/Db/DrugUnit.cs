using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using LinqKit;

namespace Sample
{
    public class DrugUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrugUnitId { get; set; }

        public DrugStatus DrugStatus { get; set; }

        public virtual ICollection<ShipmentEntry> ShipmentEntries { get; set; }

        public static FilterExpression<DrugUnit> IsNotInTransit =
            FilterExpression<DrugUnit>.Create(d => d.ShipmentEntries.Any(s => s.Shipment.ShipmentStatus != ShipmentStatus.InTransit));

        public static FilterExpression<DrugUnit> IsInTransit =
            FilterExpression<DrugUnit>.Create(d => d.ShipmentEntries.Any(s => s.Shipment.ShipmentStatus == ShipmentStatus.InTransit));
    }
}