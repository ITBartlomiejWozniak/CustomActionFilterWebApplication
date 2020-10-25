using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace CustomActionFilterWebApplication.Filters
{
    public class CustomFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Debug.WriteLine("OnActionExecuted called.");
            base.OnActionExecuted(actionExecutedContext);
        }

        public override Task OnActionExecutedAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            Debug.WriteLine("OnActionExecutedAsync called.");
            return base.OnActionExecutedAsync(actionExecutedContext, cancellationToken);
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Debug.WriteLine("OnActionExecuting called.");
            base.OnActionExecuting(actionContext);
        }

        public override Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            
            Debug.WriteLine("OnActionExecutingAsync called.");
            return base.OnActionExecutingAsync(actionContext, cancellationToken);
        }
    }
}