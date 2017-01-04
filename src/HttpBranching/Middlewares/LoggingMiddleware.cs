using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HttpBranching.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate next;

        public LoggingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //Ação Antes
            await next(context);
            //Ação Depois
        }
    }
}