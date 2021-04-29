using CodeTenorSchool.Application.DTOs.request;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeTenorSchool.Middleware
{
    public class RequestModelValidator : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var param = context.ActionArguments.SingleOrDefault(p => p.Value is IRequest);

            if (param.Value == null)
            {
                throw new Exception("Object null");
            }

            if (!context.ModelState.IsValid)
            {
                List<RequestModelError> errors = context.ModelState.Values.SelectMany(v => v.Errors).Select(m => new RequestModelError() { Error = m.ErrorMessage }).ToList();

                throw new Exception(string.Join(',', errors.Select(x => x.Error)));
            }
        }

        class RequestModelError
        {
            public string Error { get; set; }

            public override string ToString()
            {
                return Error;
            }
        }
    }
}
