﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace FirstProject.Filters
{
    //public class TestActionFitlerAttribute:IActionFilter           // inforce me to use two function OnActionExecuting and OnActionExecuted
    public class TestActionFitlerAttribute : ActionFilterAttribute  //cannot inforce me to use two function 
    {

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("before action filter executing");

            var e = context.ActionArguments;
            // var a = context.HttpContext.Request.Body;
            //Console.WriteLine(e);


        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var e = context.Result;
            // var a = context.HttpContext.Request.Body;
            // Console.WriteLine(e);
            Console.WriteLine("after action filter executing");
        }
    }
}
