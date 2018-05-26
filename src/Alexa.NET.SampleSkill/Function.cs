using System.Threading.Tasks;
using Alexa.NET.Request;
using Alexa.NET.SampleSkill.ErrorHandlers;
using Alexa.NET.SampleSkill.RequestHandlers;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Alexa.NET.SampleSkill
{
	public class Function
    {
        
		private Alexa.NET.RequestHandlers.Request Processor { get; }

		public Function()
		{
			Processor = new Alexa.NET.RequestHandlers.Request(
				new Alexa.NET.RequestHandlers.IRequestHandler[]
				{
				    new Launch(),
				    new ThrowAnError(),
                    new ProgressiveResponse(), 
                    new UnknownFeature()
				},
				new[]{new Unhandled()});
		}

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task<Response.SkillResponse> FunctionHandler(SkillRequest input, ILambdaContext context)
        {
			return Processor.Process(input, context);
        }
    }
}
