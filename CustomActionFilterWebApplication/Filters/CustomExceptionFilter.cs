using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace CustomActionFilterWebApplication.Filters
{
    public class CustomExceptionFilter : Attribute, IExceptionFilter
    {
        public bool AllowMultiple => true;
        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}