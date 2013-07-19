#Linq Filters

Provides functionality to create reusable data filters for Entity Framework and other Linq providers (like NHibernate).


The solution is partially based on the article [LINQ to Entities: Combining Predicates](http://blogs.msdn.com/b/meek/archive/2008/05/02/linq-to-entities-combining-predicates.aspx).
No nuget package is provided at the moment and, probably, it doesn't make much sense to create if for this small utility. So just copy the files from LinqFilters project to your one.


##Usage Example

EF Code First Model:

```cs
    public class DrugUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrugUnitId { get; set; }
    
        public DrugStatus DrugStatus { get; set; }
    
        public virtual ICollection<ShipmentEntry> ShipmentEntries { get; set; }
    
        public static FilterExpression<DrugUnit> IsNotInTransit = FilterExpression<DrugUnit>.Create(
            d => d.ShipmentEntries.Any(s => s.Shipment.ShipmentStatus != ShipmentStatus.InTransit));
    
        public static FilterExpression<DrugUnit> IsInTransit = FilterExpression<DrugUnit>.Create(
            d => d.ShipmentEntries.Any(s => s.Shipment.ShipmentStatus == ShipmentStatus.InTransit));
    }
```

Usage of filter expressions:

```cs
    using (var context = new TestDbContext())
    {
        var drugs = context.Drugs.Where(DrugUnit.IsNotInTransit.And(d => d.DrugStatus == DrugStatus.Active));
    
        Console.WriteLine(drugs.ToList().Count);
    }
```
