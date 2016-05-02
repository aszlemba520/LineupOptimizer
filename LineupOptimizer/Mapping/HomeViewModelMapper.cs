using LineupOptimizer.Domain.Services;
using LineupOptimizer.Models;
using LineupOptimizer.Models.Home;
using LineupOptimizer.Services;
using System.Collections.Generic;

namespace LineupOptimizer.Mapping
{
    static class HomeViewModelMapper
    {
        public static HomeViewModel Build()
        {
            return new HomeViewModel {
                MyTeamMyPlayerModels = BuildMyPlayerModels()
            };
        }

        public static List<PlayerModel> BuildMyPlayerModels()
        {
            var dataGetter = new APIService();
            var data = dataGetter.GetAllPlayers();

            CacheService.AddObjectToCache(data, "players");

            return data;
        }

    }
}
