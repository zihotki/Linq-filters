using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class TestDbContext : DbContext
    {
        public DbSet<DrugUnit> Drugs { get; set; }
        public DbSet<ShipmentEntry> ShipmentEntries { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        public TestDbContext()
            : base("TestConnection")
        {
        }
    }
}
