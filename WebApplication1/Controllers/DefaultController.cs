using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Context;
namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        CHelp<Guanlikaosi> db = new CHelp<Guanlikaosi>();//调用反射
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(Guanlikaosi model)
        {
           int n= db.Insert(model);//调用添加
            return n;
        }
    }
}
