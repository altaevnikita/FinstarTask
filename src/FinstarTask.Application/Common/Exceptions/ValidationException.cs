using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinstarTask.Application.Common.Exceptions
{
	public class ValidationException : Exception
	{
		public IDictionary<string, string[]> Failures { get; private set; }

		public ValidationException()
			: base("Обнаружены ошибки формата данных.")
		{
			Failures = new Dictionary<string, string[]>();
		}

		public ValidationException(IEnumerable<ValidationFailure> failures)
			: base("Обнаружены ошибки формата данных.")
		{
			Failures = failures
				.GroupBy(i => i.PropertyName)
				.Select(i => new
				{
					PropertyName = i.Key,
					ErrorMessages = i.Select(j => j.ErrorMessage).ToArray()
				})
				.ToDictionary(
					i => i.PropertyName,
					i => i.ErrorMessages.ToArray());
		}
	}
}
