using AutoMapper;
using FinstarTask.Application.Common.Mappings;
using FinstarTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinstarTask.Application.DataRecords.Queries.GetDataRecords
{
	public class DataRecordDto : IMapFrom<DataRecord>
	{
		public int Code { get; set; }
		public string Value { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<DataRecord, DataRecordDto>()
				.ForMember(d => d.Code, opt => opt.MapFrom(s => s.Code))
				.ForMember(d => d.Value, opt => opt.MapFrom(s => s.Value));
		}
	}
}
