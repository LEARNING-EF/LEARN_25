using System.Linq;
using System.Data.Entity;

namespace LEARNING_ENTITY_FRAMEWORK
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void AddNewPeopleButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.Person person = null;

				// **************************************************
				person =
					new Models.Person
					{
						FullName = "Ali Reza Alavi",
					};

				databaseContext.People.Add(person);
				// **************************************************

				// **************************************************
				person =
					new Models.Person
					{
						FullName = "Dariush Tasdighi",
					};

				//Models.Address address = new Models.Address();

				//address.CityName = "Tehran";
				//address.StateName = "Tehran";
				//address.CountryName = "Iran";

				//person.Address = address;

				person.Address = new Models.Address
				{
					CityName = "Tehran",
					StateName = "Tehran",
					CountryName = "Iran",
				};

				databaseContext.People.Add(person);
				// **************************************************

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void LoadPeopleIncludedAddressButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//var people =
				//	databaseContext.People
				//	.Include(current => current.Address)
				//	.Where(current => current.FullName.Contains("Dariush"))
				//	.ToList()
				//	;

				var people =
					databaseContext.People
					.Include(current => current.Address)
					.Where(current => current.Address.CityName.Contains("A"))
					.ToList()
					;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void LoadAddressesIncludedPersonButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//var addresses =
				//	databaseContext.Addresses
				//	.Include(current => current.Person)
				//	.Where(current => current.CountryName.Contains("Iran"))
				//	.ToList()
				//	;

				var addresses =
					databaseContext.Addresses
					.Include(current => current.Person)
					.Where(current => current.Person.FullName.Contains("A"))
					.ToList()
					;

				// در صورتی که من فهرست نشانی‌ها را می‌خواستم
				// هر چند که بر روی اطلاعات اشخاص متناظر آن شرط نوشته ‌ام
				// ولی دستور ذیل نیز صحیح می‌باشد
				//var addresses =
				//	databaseContext.Addresses
				//	.Where(current => current.Person.FullName.Contains("A"))
				//	.ToList()
				//	;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	}
}
