using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Xlinktscc.Controllers
{
    public class NewsCenterController : Controller
    {
        //
        // GET: /NewsCenter/
        /// <summary>
        /// 新闻中心首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

    }
}
