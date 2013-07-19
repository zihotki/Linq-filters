using System;
using System.Data.Entity;

namespace Sample
{
    public class TestDbContextInitializer : DropCreateDatabaseIfModelChanges<TestDbContext>
    {
        protected override void Seed(TestDbContext context)
        {
            context.Drugs.Add(new DrugUnit
            {
                DrugUnitId = 1,
                DrugStatus = DrugStatus.Active,
            });

            context.Drugs.Add(new DrugUnit
            {
                DrugUnitId = 2,
                DrugStatus = DrugStatus.Active
            });

            context.Drugs.Add(new DrugUnit
            {
                DrugUnitId = 3,
                DrugStatus = DrugStatus.Active
            });

            context.Drugs.Add(new DrugUnit
            {
                DrugUnitId = 4,
                DrugStatus = DrugStatus.Active
            });

            context.Drugs.Add(new DrugUnit
            {
                DrugUnitId = 5,
                DrugStatus = DrugStatus.Active
            });

            context.Drugs.Add(new DrugUnit
            {
                DrugUnitId = 6,
                DrugStatus = DrugStatus.Damaged
            });

            context.Drugs.Add(new DrugUnit
            {
                DrugUnitId = 7,
                DrugStatus = DrugStatus.Damaged
            });



            context.Shipments.Add(new Shipment
            {                           
                ShipmentId = Guid.Parse("1112cd56-7930-42a1-9b1a-7040e3da73bd"),
                ShipmentStatus = ShipmentStatus.InTransit,
            });

            context.Shipments.Add(new Shipment
            {
                ShipmentId = Guid.Parse("2222cd56-7930-42a1-9b1a-7040e3da73ff"),
                ShipmentStatus = ShipmentStatus.Received,
            });




            context.ShipmentEntries.Add(new ShipmentEntry
            {
                DrugUnitId = 1,
                ShipmentId = Guid.Parse("1112cd56-7930-42a1-9b1a-7040e3da73bd")
            });

            context.ShipmentEntries.Add(new ShipmentEntry
            {
                DrugUnitId = 2,
                ShipmentId = Guid.Parse("1112cd56-7930-42a1-9b1a-7040e3da73bd")
            });

            context.ShipmentEntries.Add(new ShipmentEntry
            {
                DrugUnitId = 3,
                ShipmentId = Guid.Parse("2222cd56-7930-42a1-9b1a-7040e3da73ff")
            });

            context.ShipmentEntries.Add(new ShipmentEntry
            {
                DrugUnitId = 4,
                ShipmentId = Guid.Parse("2222cd56-7930-42a1-9b1a-7040e3da73ff")
            });

            context.ShipmentEntries.Add(new ShipmentEntry
            {
                DrugUnitId = 5,
                ShipmentId = Guid.Parse("2222cd56-7930-42a1-9b1a-7040e3da73ff")
            });

            context.SaveChanges();
        }
    }
}