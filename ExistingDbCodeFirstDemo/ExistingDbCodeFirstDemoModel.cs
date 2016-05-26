namespace ExistingDbCodeFirstDemo
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class ExistingDbCodeFirstDemoModel : DbContext
	{
		public ExistingDbCodeFirstDemoModel(): base("name=ExistingDbCodeFirstDemo")
		{
		}

		public virtual DbSet<ExistingTable> ExistingTables { get; set; }
		public virtual DbSet<NewTable> NewTables { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			// You can override the settings for the table
			// modelBuilder.Configurations.Add(new NewTableMap());
		}
	}
}
