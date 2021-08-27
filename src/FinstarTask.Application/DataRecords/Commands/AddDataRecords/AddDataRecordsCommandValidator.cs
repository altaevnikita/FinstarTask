using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinstarTask.Application.DataRecords.Commands.AddDataRecords
{
	public class AddDataRecordsCommandValidator : AbstractValidator<AddDataRecordsCommand>
	{
		public AddDataRecordsCommandValidator()
		{
			RuleForEach(x => x.DataRecords).SetValidator(new DataRecordDtoValidatior());
		}
	}
}
