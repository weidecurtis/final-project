using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCFinalProject.Data;
using LCFinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;
using System.Xml;
using LCFinalProject.Models.gd2Models;
using System.Xml.Serialization;
using System.IO;
using Microsoft.IdentityModel.Protocols;
using LCFinalProject.Models;
using System.Net;
using System.Text;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LCFinalProject.Controllers
{
    [XmlRoot("urlset")]
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
            /*
            // This works

            Player player;

            string path = $"C:/Batter.xml";
            //string path = "~https://gd2.mlb.com/components/game/mlb/year_2017/month_08/day_14/gid_2017_08_14_atlmlb_colmlb_1/batters/471865.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            StreamReader reader = new StreamReader(path);

            player = (Player)serializer.Deserialize(reader);
            reader.Close();

            */
            Player player;

            string path = "https://gd2.mlb.com/components/game/mlb/year_2017/month_04/day_01/gid_2017_04_01_seamlb_colmlb_1/batters/471865.xml";
            WebClient client = new WebClient();

            string data = Encoding.Default.GetString(client.DownloadData(path));

            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));

            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            //StreamReader reader = new StreamReader(path);

            player = (Player)serializer.Deserialize(stream);
            //reader.Close();

            PositionPlayer newPlayer = new PositionPlayer()
            {
                ID = player.id,
                FirstName = player.first_name,
                LastName = player.last_name
            };

            _context.PositionPlayers.Add(newPlayer);
            _context.SaveChanges();

            return View();



        }

        [HttpPost]
        public IActionResult Index(GetDataViewModel getDataViewModel)
        {
            // This doesn't work

            Player player;

            string path = "https://gd2.mlb.com/components/game/mlb/year_2017/month_08/day_14/gid_2017_08_14_atlmlb_colmlb_1/batters/471865.xml";
            WebClient client = new WebClient();

            string data = Encoding.Default.GetString(client.DownloadData(path));

            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));

            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            //StreamReader reader = new StreamReader(path);

            player = (Player)serializer.Deserialize(stream);
            //reader.Close();

            return View();
        }
    }
}
