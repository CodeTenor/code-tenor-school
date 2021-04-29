using CodeTenorSchool.Application.DTOs.request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace CodeTenorSchool.Middleware
{
    public class RequestModelValidatorFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext context)
        {
            var param = context.ActionArguments.SingleOrDefault(p => p.Value is IRequest);

            if (param.Value == null)
            {
                throw new Exception("Object null");
            }

            if (!context.ModelState.IsValid)
            {
                List<RequestModelError> errors = context.ModelState.Values.SelectMany(v => v.Errors).Select(m => new RequestModelError() { Error = m.ErrorMessage }).ToList();

                context.Request.CreateErrorResponse(HttpStatusCode.BadRequest, string.Join(',', errors.Select(x => x.Error)));
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
