using Microsoft.AspNetCore.Mvc.Filters;

namespace FirstProject.Filters
{
    public class TestResourceFilterAttribute : IResourceFilter
    {
        private readonly ILogger<TestResourceFilterAttribute> _logger;

        public TestResourceFilterAttribute(ILogger<TestResourceFilterAttribute> logger)
        {
            _logger = logger;
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            var a = context.HttpContext.Request.Body;
            Console.WriteLine(a);
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
