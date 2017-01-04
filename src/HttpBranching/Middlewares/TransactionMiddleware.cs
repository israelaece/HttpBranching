using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HttpBranching.Middlewares
{
    public class TransactionMiddleware
    {
        private readonly RequestDelegate next;

        public TransactionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await next(context);
        }
    }
}