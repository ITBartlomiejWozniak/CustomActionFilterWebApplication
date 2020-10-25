using System.Diagnostics;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace CustomActionFilterWebApplication.Filters
{
	public class RequestTimingFilter : ActionFilterAttribute
	{
		public override void OnActionExecuting(HttpActionContext actionContext)
		{
			
			GetTimer(actionContext, "action").Start();
			base.OnActionExecuting(actionContext);
		}

		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{
			var actionTimer = GetTimer(actionExecutedContext.ActionContext, "action");
			Debug.WriteLine($"ElapsedMilliseconds: {actionTimer.ElapsedMilliseconds}");
			actionTimer.Stop();
			base.OnActionExecuted(actionExecutedContext);
		}

		private static Stopwatch GetTimer(HttpActionContext context, string name)
		{
			var key = string.Format("__timer__{0}", name);
			if (context.Request.Properties.ContainsKey(key))
			{
				return (Stopwatch)context.Request.Properties[key];
			}

			var result = new Stopwatch();
			context.Request.Properties[key] = result;
			return result;
		}
	}
}