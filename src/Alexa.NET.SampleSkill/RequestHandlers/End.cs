using System;
using Alexa.NET.Request.Type;
using Alexa.NET.RequestHandlers;
using Alexa.NET.Response;

namespace Alexa.NET.SampleSkill.RequestHandlers
{
	public class End : Alexa.NET.RequestHandlers.Handlers.SynchronousRequestHandler
	{
		public override bool CanHandle(RequestInformation information)
		{
			var intent = information.SkillRequest.Request as IntentRequest;
			var intentName = intent?.Intent.Name ?? string.Empty;
			return intentName == BuiltInIntent.Cancel || intentName == BuiltInIntent.Stop;
		}

		public override SkillResponse HandleSyncRequest(RequestInformation information)
		{
			return ResponseBuilder.Tell("Certainly, I hope you found it interesting");
		}
	}
}
