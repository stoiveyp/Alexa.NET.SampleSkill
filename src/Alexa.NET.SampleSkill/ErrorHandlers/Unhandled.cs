using System;
using Alexa.NET.RequestHandlers;
using Alexa.NET.Response;

namespace Alexa.NET.SampleSkill.ErrorHandlers
{
	public class Unhandled : Alexa.NET.RequestHandlers.Handlers.SynchronousErrorHandler
	{
		public override bool CanHandle(RequestInformation information, Exception exception)
		{
			return true;
		}

		public override SkillResponse HandleSyncRequest(RequestInformation information, Exception exception)
		{
			return ResponseBuilder.Tell("Something went really wrong. I don't know how to recover, but isn't this better than some awful error message?");
		}
	}
}
