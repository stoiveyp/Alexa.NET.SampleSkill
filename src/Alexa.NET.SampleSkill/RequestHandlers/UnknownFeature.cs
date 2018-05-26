using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Alexa.NET.RequestHandlers;
using Alexa.NET.RequestHandlers.Handlers;
using Alexa.NET.Response;

namespace Alexa.NET.SampleSkill.RequestHandlers
{
    public class UnknownFeature:SynchronousRequestHandler
    {
        public override bool CanHandle(RequestInformation information)
        {
            return information.IsFeature();
        }

        public override SkillResponse HandleSyncRequest(RequestInformation information)
        {
            return ResponseBuilder.Tell("Ths isn't a feature currently shown by this skill, but we plan to add more based on your requests.");
        }
    }
}
