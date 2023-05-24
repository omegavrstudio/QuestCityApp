using QuestCity.Core.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestCity.GameCore.Services
{
    public interface ICityStatisticsService : IService
    {
        public virtual void AddCoin() { }
        public virtual void AddPeople() { }
        public virtual void AddBuildings() { }
        public virtual void AddRegions() { }
        public virtual void AddHappy() { }
    }
}