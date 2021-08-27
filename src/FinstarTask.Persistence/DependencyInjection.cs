using FinstarTask.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinstarTask.Persistence
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<FinstarDataContext>(options =>
				options.UseSqlite(configuration.GetConnectionString("FinstarTaskDatabase")));

			services.AddScoped<IFinstarDataContext>(provider => provider.GetService<FinstarDataContext>());

			return services;
		}
	}
}
