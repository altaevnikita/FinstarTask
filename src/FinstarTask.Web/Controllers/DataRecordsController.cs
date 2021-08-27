using FinstarTask.Application.DataRecords.Commands.AddDataRecords;
using FinstarTask.Application.DataRecords.Queries.GetDataRecords;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataRecordDto = FinstarTask.Application.DataRecords.Queries.GetDataRecords.DataRecordDto;

namespace FinstarTask.Web.Controllers
{
	public class DataRecordsController : BaseController
	{
		[HttpGet]
		public async Task<ActionResult<IEnumerable<DataRecordDto>>> GetAll()
		{
			return Ok(await Mediator.Send(new GetDataRecordsQuery()));
		}

		[HttpPost]
		public async Task<IActionResult> AddRange(AddDataRecordsCommand command)
		{
			await Mediator.Send(command);
			return Ok();
		}
	}
}
