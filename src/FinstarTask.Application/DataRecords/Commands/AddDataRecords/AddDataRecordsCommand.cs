using FinstarTask.Application.Common.Interfaces;
using FinstarTask.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinstarTask.Application.DataRecords.Commands.AddDataRecords
{
	public class AddDataRecordsCommand : IRequest
	{
		public IEnumerable<DataRecordDto> DataRecords { get; set; }

		public class Handler : IRequestHandler<AddDataRecordsCommand>
		{
			private readonly IFinstarDataContext _context;

			public Handler(IFinstarDataContext finstarDataContext)
			{
				_context = finstarDataContext;
			}

			public async Task<Unit> Handle(AddDataRecordsCommand request, CancellationToken cancellationToken)
			{
				_context.DataRecords.RemoveRange(_context.DataRecords);
				foreach (var dataRecord in request.DataRecords.OrderBy(i => i.Code))
				{
					var ent = new DataRecord
					{
						Code = dataRecord.Code,
						Value = dataRecord.Value
					};

					_context.DataRecords.Add(ent);
				}

				await _context.SaveChangesAsync(cancellationToken);

				return Unit.Value;
			}
		}
	}
}
