using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Xlinktscc.Controllers
{
    public class AboutUsController : Controller
    {
        //
        // GET: /AboutUs/
        /// <summary>
        /// 关于我们首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 团队介绍
        /// </summary>
        /// <returns></returns>
        public ActionResult IntroductionTeam()
        {
            return View();
        }

        /// <summary>
        /// 简介
        /// </summary>
        /// <returns></returns>
        public ActionResult IntroductionUs()
        {
            return View();
        }

    }
}
