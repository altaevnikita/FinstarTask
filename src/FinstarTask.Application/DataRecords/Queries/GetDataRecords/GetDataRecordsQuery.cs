using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinstarTask.Application.DataRecords.Queries.GetDataRecords
{
	public class GetDataRecordsQuery : IRequest<IEnumerable<DataRecordDto>>
	{
	}
}
