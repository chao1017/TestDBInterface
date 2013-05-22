using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using TestDBInterface.Models;

namespace TestDBInterface.Controllers
{
    public class DBFrameworkController : Controller
    {
        //
        // GET: /DBFramework/
        DBRepository dbrObj = new DBRepository();

        public ActionResult Index()
        {
            dbrObj.ConnectDB("oracle");
            
             
            return View();
        }

        public string InsertData(string para1)
        {

            //dbrObj.InsertData(para1);
            return HttpUtility.HtmlEncode("Hello " + para1); ;
        }

    }
}
