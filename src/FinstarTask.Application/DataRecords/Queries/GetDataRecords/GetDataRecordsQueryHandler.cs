using AutoMapper;
using AutoMapper.QueryableExtensions;
using FinstarTask.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinstarTask.Application.DataRecords.Queries.GetDataRecords
{
	public class GetDataRecordsQueryHandler : IRequestHandler<GetDataRecordsQuery, IEnumerable<DataRecordDto>>
	{
		private readonly IFinstarDataContext _context;
		private readonly IMapper _mapper;

		public GetDataRecordsQueryHandler(IFinstarDataContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<IEnumerable<DataRecordDto>> Handle(GetDataRecordsQuery request, CancellationToken cancellationToken)
		{
			var dataRecords = await _context.DataRecords
				.ProjectTo<DataRecordDto>(_mapper.ConfigurationProvider)
				.ToListAsync(cancellationToken);

			return dataRecords;
		}
	}
}
