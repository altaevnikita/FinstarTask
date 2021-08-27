using FinstarTask.Application.Common.Interfaces;
using FinstarTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinstarTask.Persistence
{
	public class FinstarDataContext : DbContext, IFinstarDataContext
	{
		public FinstarDataContext(DbContextOptions<FinstarDataContext> options)
			: base(options)
		{
		}

		public DbSet<DataRecord> DataRecords { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(FinstarDataContext).Assembly);
		}
	}
}
