using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LinqKit;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TestDbContext())
            {
                Database.SetInitializer(new TestDbContextInitializer());
                context.Database.Initialize(force:false);

                context.SaveChanges();
            }

            using (var context = new TestDbContext())
            {
                var drugs = context.Drugs.Where(DrugUnit.IsNotInTransit.And(d => d.DrugStatus == DrugStatus.Active));

                Console.WriteLine(drugs.ToString());
            }

        }
    }
}
