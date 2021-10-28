using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using XMLSandBox.Models;

namespace XMLSandBox.Controllers
{
    public class CdsController : Controller
    {
        public CdsController()
        {
        }
        public IActionResult Index()
        {
            CdList cdList = new CdList();
            return View(cdList);
        }


    }
}
