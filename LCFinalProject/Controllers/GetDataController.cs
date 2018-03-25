using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCFinalProject.Data;
using LCFinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;
using System.Xml;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LCFinalProject.Controllers
{
    public class GetDataController : Controller
    {
        private BeatTheShiftDbContext _context;

        public GetDataController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(GetDataViewModel getDataViewModel)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://gd2.mlb.com/components/game/mlb/year_2017/month_08/day_14/gid_2017_08_14_atlmlb_colmlb_1/batters/408252.xml");
            HtmlNode node = document.DocumentNode.SelectSingleNode("//div[@id='collapsible1']");




            return View();
        }
    }
}
