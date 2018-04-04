using LCFinalProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace LCFinalProject.Models
{
    public class GameLogic
    {
        private BeatTheShiftDbContext _context;

        public GameLogic(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<Game> GetGames(DateTime dateTime)
        {
            List<Game> gameUrls = new List<Game>();

            var date = dateTime.Date;
            var year = date.ToString("yyyy");
            var month = date.ToString("MM");
            var day = date.ToString("dd");

            //This block loads the individual game URLs.
            WebClient webClient = new WebClient();
            var returnedData = webClient.DownloadString(new Uri("https://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month + "/day_" + day + "/playertracker.xml"));
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(returnedData);
            var gameNodes = xml.GetElementsByTagName("game");
            if (gameNodes != null)
            {
                for (int i = 0; i < gameNodes.Count; i++)
                {
                    var gameNode = gameNodes.Item(i);

                    var directory = gameNode.Attributes["game_data_directory"].InnerText;
                    var venue = gameNode.Attributes["venue"].InnerText;
                    var venueID = gameNode.Attributes["venue_id"].InnerText;
                    var gameID = gameNode.Attributes["game_pk"].InnerText;

                    var gameDuplicate = _context.Games.Any(g => g.GameID == int.Parse(gameID));

                    Game newGame = new Game()
                    {
                        Directory = directory,
                        Venue = venue,
                        VenueID = int.Parse(venueID),
                        GameDate = dateTime,
                        GameID = int.Parse(gameID)
                    };
                    gameUrls.Add(newGame);


                    if (!gameDuplicate)
                    {
                        _context.Games.Add(newGame);
                    }
                }

            }
            _context.SaveChanges();
            return gameUrls;
        }

    }



}
