using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Xlinktscc.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 产品中心
        /// </summary>
        /// <returns></returns>
        public ActionResult ProductCenter()
        {
            return RedirectToAction("Index");
        }
        /// <summary>
        /// 硬件
        /// </summary>
        /// <returns></returns>
        public ActionResult Hardware()
        {
            return View();
        }
        /// <summary>
        /// 软件
        /// </summary>
        /// <returns></returns>
        public ActionResult Software()
        {
            return View();
        }
        /// <summary>
        /// PVss
        /// </summary>
        /// <returns></returns>
        public ActionResult Pvss()
        {
            return View();
        }
        /// <summary>
        /// 云平台
        /// </summary>
        /// <returns></returns>
        public ActionResult CloudPlatform()
        {
            return View();
        }
    }
}
