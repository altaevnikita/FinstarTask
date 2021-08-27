using FinstarTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinstarTask.Persistence.Configurations
{
	public class DataRecordConfiguration : IEntityTypeConfiguration<DataRecord>
	{
		public void Configure(EntityTypeBuilder<DataRecord> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(i => i.Id).HasColumnName("Id")
				.IsRequired()
				.ValueGeneratedOnAdd();
			builder.Property(i => i.Code).HasColumnName("Code")
				.IsRequired();
			builder.Property(i => i.Value).HasColumnName("Value")
				.IsRequired();
		}
	}
}
