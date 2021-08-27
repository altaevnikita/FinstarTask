using FluentValidation;

namespace FinstarTask.Application.DataRecords.Commands.AddDataRecords
{
	public class DataRecordDtoValidatior : AbstractValidator<DataRecordDto>
	{
		public DataRecordDtoValidatior()
		{
			RuleFor(i => i.Value).NotNull().NotEmpty()
				.WithMessage("Поле \"Value\" не должно быть пустым");
		}
	}
}
