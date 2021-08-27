using FinstarTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinstarTask.Application.Common.Interfaces
{
	public interface IFinstarDataContext
	{
		DbSet<DataRecord> DataRecords { get; set; }

		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
