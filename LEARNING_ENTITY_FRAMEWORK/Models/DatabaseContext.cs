namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{
		}

		// **********
		public System.Data.Entity.DbSet<Person> People { get; set; }
		// **********

		// **********
		public System.Data.Entity.DbSet<Address> Addresses { get; set; }
		// **********

		protected override void OnModelCreating
			(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Configurations.Add(new Person.Configuration());
			modelBuilder.Configurations.Add(new Address.Configuration());
		}
	}
}
