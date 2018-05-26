using System;
using System.Threading.Tasks;
using Alexa.NET.Request.Type;
using Alexa.NET.RequestHandlers;
using Alexa.NET.Response;

namespace Alexa.NET.SampleSkill.RequestHandlers
{
	public class ProgressiveResponse : IRequestHandler
	{
		public bool CanHandle(RequestInformation information)
		{
		    return information.IsFeature(SupportedFunctions.ProgressiveResponse);
		}

		public async Task<SkillResponse> Handle(RequestInformation information)
		{
		    var progressive = new Response.ProgressiveResponse(information.SkillRequest);
		    await progressive.SendSpeech("Sure, I'll get right on that");
		    await Task.Delay(TimeSpan.FromSeconds(3));
		    return ResponseBuilder.Tell("There we go, that was a progressive reponse. To see how it worked check out the Alexa dot net sample skill repo");
		}
	}
}
