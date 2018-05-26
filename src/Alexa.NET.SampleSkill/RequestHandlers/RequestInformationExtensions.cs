using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Alexa.NET.Request.Type;
using Alexa.NET.RequestHandlers;

namespace Alexa.NET.SampleSkill.RequestHandlers
{
    public static class RequestInformationExtensions
    {
        public static bool IsFeature(this RequestInformation information, string featureName = null)
        {
            switch (information.SkillRequest.Request)
            {
                case IntentRequest intent:
                    if (intent.Intent.Name != "Feature")
                    {
                        return false;
                    }

                    if (string.IsNullOrWhiteSpace(featureName))
                    {
                        return true;
                    }

                    return intent.Intent.Slots.ContainsKey("featureName") &&
                           intent.Intent.Slots["featureName"].Value == featureName;
                default:
                    return false;
            }
        }
    }
}
