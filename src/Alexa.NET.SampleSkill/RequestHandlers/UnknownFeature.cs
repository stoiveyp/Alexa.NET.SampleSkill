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
            return ResponseBuilder.Tell(@"This isn't a feature currently shown by this skill,
popular features will be added over time, or you can visit the alexa dot net sample skill repo and ask for it to be added.");

        }
    }
}
