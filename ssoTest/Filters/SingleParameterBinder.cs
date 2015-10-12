using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;

namespace ssoTest.Filters
{
    public class SingleParameterBinder:IModelBinder
    {
        //public override void OnActionExecuting(HttpActionContext actionContext)
        //{
        //    using (var requestStream = HttpContext.Current.Request.InputStream)
        //    {
        //        requestStream.Seek(0, SeekOrigin.Begin);
        //        string rawBody = new StreamReader(requestStream).ReadToEnd();
        //    }

        //    base.OnActionExecuting(actionContext);
        //}
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
             using (var requestStream = HttpContext.Current.Request.InputStream)
             {
                 requestStream.Seek(0, SeekOrigin.Begin);
                 string rawBody = new StreamReader(requestStream).ReadToEnd();
                 if (!string.IsNullOrEmpty(rawBody))
                 {
                     
                     return true;
                 }
             }

            return false;
        }
    }
}