using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Xlinktscc.Controllers
{
    public class PerformanceController : Controller
    {
        //
        // GET: /Performance/
        /// <summary>
        /// 公司业绩
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 华东区
        /// </summary>
        /// <returns></returns>
        public ActionResult EasternRegion()
        {
            return View();
        }

        /// <summary>
        /// 华北区
        /// </summary>
        /// <returns></returns>
        public ActionResult NorthernRegion()
        {
            return View();
        }
    }
}
