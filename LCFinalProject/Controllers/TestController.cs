using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HtmlAgilityPack;
using LCFinalProject.Data;
using LCFinalProject.Models;
using LCFinalProject.Models.gd2Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LCFinalProject.Controllers
{
    public class TestController : Controller
    {

        [XmlRoot("urlset")]
        public class GetDataController : Controller
        {
            private BeatTheShiftDbContext _context;

            public GetDataController(BeatTheShiftDbContext dbContext)
            {
                _context = dbContext;
            }


            public IActionResult Index()
            {

                List<string> gameUrls = new List<string>();

                HtmlWeb gameHw = new HtmlWeb();
                HtmlDocument gameDoc = gameHw.Load("");


                // Test to see if concating URLs will work.
                //for (int i = 0; i > 10; i++)
                //{
                // var date = DateTime.Now.AddDays(i - 254);
                string year = "2017";
                string month = "07";
                string day = "18";

                GameDirectory gameDirectory;

                //string path = "https://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month + "/day_" + day + "/playertracker.xml";
                string path = $"C:/playertracker.xml";
                XmlSerializer serializer = new XmlSerializer(typeof(GameDirectory));
                StreamReader reader = new StreamReader(path);
                gameDirectory = (GameDirectory)serializer.Deserialize(reader);
                reader.Close();

                //WebClient client = new WebClient();
                //string data = Encoding.Default.GetString(client.DownloadData(path));
                //Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
                //XmlSerializer serializer = new XmlSerializer(typeof(GameDirectory));
                //gameDirectory = (GameDirectory)serializer.Deserialize(stream);

                //Game newGame = new Game()
                //{
                //    Directory = gameDirectory.Path

                //};

                return View();
            }
        }
    }
}
