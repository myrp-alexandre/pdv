using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TOTVS.PDV.Application.Messages
{
    [DataContract]
    public class ResultResponseMessage<TResponse> : IActionResult
    {
        public HttpStatusCode HttpStatusCode { get; private set; } = HttpStatusCode.OK;

        [DataMember(Name = "message")]
        public string Message { get; private set; }

        [DataMember(Name = "retorno")]
        public TResponse Result { get; set; }

        public ResultResponseMessage<TResponse> CreateResponseInternalServerError(string message = null)
        {
            this.Message = string.IsNullOrWhiteSpace(message) ? string.Empty : message;
            HttpStatusCode = (HttpStatusCode)500;

            return this;
        }

        public ResultResponseMessage<TResponse> CreateResponseOk(string message = null)
        {
            this.Message = string.IsNullOrWhiteSpace(message) ? string.Empty : message;
            HttpStatusCode = (HttpStatusCode)200;

            return this;
        }

        public ResultResponseMessage(TResponse result) => Result = result;

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(this) { StatusCode = (int)HttpStatusCode };

            await objectResult.ExecuteResultAsync(context);
        }
    }
}
