namespace Models
{
	public class Person : BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person>
		{
			public Configuration() : base()
			{
			}
		}
		#endregion /Configuration

		public Person() : base()
		{
		}

		// **********
		public string FullName { get; set; }
		// **********

		// **********
		// **********
		// **********
		// دستور ذيل نبايد نوشته شود
		//public Systme.Guid? AddressId { get; set; }
		// **********

		// **********
		public virtual Address Address { get; set; }
		// **********
		// **********
		// **********
	}
}
