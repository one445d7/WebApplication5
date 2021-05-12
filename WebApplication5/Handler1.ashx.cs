using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApplication5
{
    /// <summary>
    /// Handler1 的摘要描述
    /// </summary>
    public class Handler1 : System.Web.UI.Page,IHttpHandler,IRequiresSessionState
    {        
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World"+Session["userName"]);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}