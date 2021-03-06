using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinstarTask.Web.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BaseController : ControllerBase
	{
		private IMediator _mediator;

		protected IMediator Mediator
		{
			get
			{
				return _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
			}
		}
	}
}
