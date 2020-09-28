using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Net;

namespace Ecommerce.Infrastructure.Filter
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var result = JsonConvert.SerializeObject(new { message = exception.Message }).ToString();
            context.Result = new ContentResult
            {
                Content = result,
                ContentType = "application/json",
                // change to whatever status code you want to send out
                StatusCode = (int?)HttpStatusCode.InternalServerError
            };
        }
    }
}
