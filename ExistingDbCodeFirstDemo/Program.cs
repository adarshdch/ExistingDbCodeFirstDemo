using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingDbCodeFirstDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new ExistingDbCodeFirstDemoModel())
			{
				//Get existing record
				var firstExistingRecord = context.ExistingTables.FirstOrDefault();
				
				Console.WriteLine(string.Format("Retrieved record: Id - {0}, Data - {1}", firstExistingRecord.Id, firstExistingRecord.Data));
				Console.WriteLine("Insert this data into new table...");
				//Add new record into new table
				context.NewTables.Add(new NewTable()
				{
					UpdateDateTime = DateTime.UtcNow,
					Data = firstExistingRecord.Data,
					Id = new Random(10).Next(20,20000)
				});
				
				//Save change
				context.SaveChanges();

				Console.WriteLine("Verifying newly insert data from new table...");

				//Get newly inserted data
				var newRecord = context.NewTables.SingleOrDefault(m => m.Data.Equals(firstExistingRecord.Data));
				Console.WriteLine("Retrieved record: Id - {0}, Data - {1}", newRecord.Id, newRecord.Data);
				Console.WriteLine("Press any key to exit...");
				Console.ReadKey();
			}

		}
	}
}
