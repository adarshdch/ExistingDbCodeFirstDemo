
using System.Data.Entity.ModelConfiguration;

namespace ExistingDbCodeFirstDemo
{
	/// <summary>
	/// This is just for sample purpose to override the settings.
	/// This is not necessary to use this file. I have commented it out in DbContext related class
	/// </summary>
	public class NewTableMap : EntityTypeConfiguration<NewTable>
	{
		public NewTableMap(): base()
		{
			HasKey(p => p.Id)
			.ToTable("NewTable");    
		}
	}
}
