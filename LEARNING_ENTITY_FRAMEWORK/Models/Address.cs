namespace Models
{
	/// <summary>
	/// ارث بری کند BaseEntity به هیچ عنوان نباید از
	/// </summary>
	public class Address : object
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Address>
		{
			public Configuration() : base()
			{
				HasRequired(current => current.Person)
					.WithOptional(person => person.Address)
					.WillCascadeOnDelete(true);
			}
		}
		#endregion /Configuration

		public Address() : base()
		{
		}

		// **********
		// دستور ذيل نبايد نوشته شود
		//public System.Guid Id { get; set; }
		// **********

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Key]
		public System.Guid PersonId { get; set; }
		// **********

		// **********
		public virtual Person Person { get; set; }
		// **********
		// **********
		// **********

		// **********
		public string CityName { get; set; }
		// **********

		// **********
		public string StateName { get; set; }
		// **********

		// **********
		public string CountryName { get; set; }
		// **********
	}
}
