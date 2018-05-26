using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.RequestHandlers;

namespace Alexa.NET.SampleSkill.RequestHandlers
{
    public static class RequestInformationExtensions
    {
        private const string FeatureIntent = "FeatureDetail";
        private const string FeatureSlot = "feature";

        public static bool IsFeature(this RequestInformation information, string featureName = null)
        {
            switch (information.SkillRequest.Request)
            {
                case IntentRequest intent:
                    if (intent.Intent.Name != FeatureIntent)
                    {
                        return false;
                    }

                    if (string.IsNullOrWhiteSpace(featureName))
                    {
                        return true;
                    }

                    if (!intent.Intent.Slots.ContainsKey(FeatureSlot))
                    {
                        return false;
                    }

                    var slot = intent.Intent.Slots[FeatureSlot];
                    var resolution = slot.Resolution.Authorities.First();

                    return resolution.Status.Code == ResolutionStatusCode.SuccessfulMatch && 
                       string.CompareOrdinal(resolution.Values.First().Value.Name,featureName) == 0;
                default:
                    return false;
            }
        }
    }
}
