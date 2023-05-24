using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestCity.GameCore.Structures;
using QuestCity.GameCore.Base;

namespace QuestCity.GameCore.Services
{
    public class CityStatisticService : ServiceBase, ICityStatisticsService
    {
        private CityStatisticStruct statisticStruct;

        private void Awake()
        {
            if(GetCacheStatistic(out CityStatisticStruct cityStatisticStruct))
            {
                statisticStruct = cityStatisticStruct;
            }
            else
            {
                statisticStruct = new CityStatisticStruct();
            }
        }

        private bool GetCacheStatistic(out CityStatisticStruct cityStatisticStruct)
        {
            cityStatisticStruct = new CityStatisticStruct();
            return true;
        }
    }
}