using System;
using System.Threading.Tasks;
using Alexa.NET.RequestHandlers;
using Alexa.NET.Response;

namespace Alexa.NET.SampleSkill.RequestHandlers
{
	public class ThrowAnError : Alexa.NET.RequestHandlers.Handlers.IntentNameRequestHandler
	{
		public ThrowAnError():base("throwanerror"){}

		public override Task<SkillResponse> Handle(RequestInformation information)
		{
			throw new InvalidOperationException("You shouldn't have done that");
		}
	}
}
