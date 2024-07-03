using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HangFireApplication.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class JobController : ControllerBase
	{
		[HttpGet]
		public void ListInts()
		{
			for (int i = 0; i < 10000; i++)
			{
				Console.WriteLine(i);
			}
		}

		[HttpPost]
		[Route("CreateBackgroundJob")]
		public ActionResult CreateBackgroundJob()
		{
			BackgroundJob.Enqueue(() => ListInts());
			return Ok();
		}

		[HttpPost]
		[Route("CreateScheduleJob")]
		public ActionResult CreateScheduleJob()
		{
			var scheduleDateTime = DateTime.UtcNow.AddSeconds(5);
			var dateTimeOffset = new DateTimeOffset(scheduleDateTime);

			BackgroundJob.Schedule(() => Console.WriteLine("Tarefa Agendada"), dateTimeOffset);

			return Ok();
		}

		[HttpPost]
		[Route("CreateContinuationJob")]
		public ActionResult CreateContinuationJob()
		{
			var scheduleDateTime = DateTime.UtcNow.AddSeconds(5);
			var dateTimeOffset = new DateTimeOffset(scheduleDateTime);

			var job1 = BackgroundJob.Schedule(() => Console.WriteLine("Tarefa 1 Agendada"), dateTimeOffset);

			var job2 = BackgroundJob.ContinueJobWith(job1, () => Console.WriteLine("Tarefa 2 Agendada"));

			var job3 = BackgroundJob.ContinueJobWith(job2, () => Console.WriteLine("Tarefa 3 Agendada"));

			return Ok();
		}

		[HttpPost]
		[Route("CreateRecurringJob")]
		public ActionResult CreateRecurringJob()
		{
			RecurringJob.AddOrUpdate("RecurringJob", () => Console.WriteLine("Tarefa Recorrente"), Cron.Minutely);

			return Ok();
		}
	}
}
