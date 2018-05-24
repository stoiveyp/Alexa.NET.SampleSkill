using System;
using System.Threading.Tasks;
using Alexa.NET.Request.Type;
using Alexa.NET.RequestHandlers;
using Alexa.NET.Response;

namespace Alexa.NET.SampleSkill.RequestHandlers
{
	public class Launch:Alexa.NET.RequestHandlers.Handlers.SynchronousRequestHandler
    {

		public override bool CanHandle(RequestInformation information)
		{
			return information.SkillRequest.Request is LaunchRequest;
		}

		public override SkillResponse HandleSyncRequest(RequestInformation information)
		{
			return ResponseBuilder.Ask(
				"Hi there, thanks for wanting to learn more about Alexa dot net. Would you like to find out about?",
			    new Reprompt("What feature would you like to find out about?"));
		}
	}
}
