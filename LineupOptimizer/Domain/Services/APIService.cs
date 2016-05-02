using LineupOptimizer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization;
using System.Xml;

namespace LineupOptimizer.Services
{
    public class APIService
    {
        private readonly WebClient _webClient;

        public APIService()
        {
            _webClient = new WebClient();
        }

        public List<PlayerModel> GetAllPlayers()
        {
            var results = new List<PlayerModel>();
            var reader = new XmlTextReader("http://www.fantasyfootballnerd.com/service/players/xml/ggqnipi2nqqe/");
            while (reader.Read())
            {
                if (reader.Depth == 1)
                {
                    var player = new PlayerModel
                    {
                        Name = reader.GetAttribute("displayName"),
                        IdString = reader.GetAttribute("playerId"),
                        DOB = reader.GetAttribute("dob"),
                        Height = reader.GetAttribute("height"),
                        IsActiveString = reader.GetAttribute("active"),
                        JerseyNumberString = reader.GetAttribute("jersey"),
                        Position = reader.GetAttribute("position"),
                        Team = reader.GetAttribute("team"),
                        Weight = reader.GetAttribute("weight"),
                    };
                    results.Add(player);
                }
            }
            return results;
        }

        public List<PlayerModel> GetQbInfo(int week)
        {
            var reader = new XmlTextReader("http://www.fantasyfootballnerd.com/service/weekly-projections/json/ggqnipi2nqqe/QB/" + week + "/");
            while (reader.Read())
            {
                if(reader.Depth == 2)
                {
                    
                }
            }

            return new List<PlayerModel>();
        }
    }
}
