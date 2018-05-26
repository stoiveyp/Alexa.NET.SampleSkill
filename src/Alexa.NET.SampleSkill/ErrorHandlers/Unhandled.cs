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
            Console.WriteLine(exception.Message);
            return ResponseBuilder.Tell(
                "Either something went really wrong, or you asked something I couldn't handle yet. If it's the latter, please ask for new features at the alexa dot net sample skill repo.");
        }
    }
}
