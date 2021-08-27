using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FinstarTask.Persistence
{
	public class FinstarDataContextFactory : IDesignTimeDbContextFactory<FinstarDataContext>
	{
		public FinstarDataContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<FinstarDataContext>();
			optionsBuilder.UseSqlite("Data Source=finstar.db;");
			return new FinstarDataContext(optionsBuilder.Options);
		}
	}
}
