using QuestCity.Core.Patterns;
using QuestCity.GameCore.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLoader : MonoBehaviour
{
    [SerializeField] private NotificationService _notificationService;
    [SerializeField] private CityStatisticService _cityStatisticService;


    private void Awake()
    {
        ServiceLocator.Initialize();

        InitializationServices();
    }

    private void InitializationServices()
    {
        ServiceLocator.Current.Register<NotificationService>(_notificationService);
        ServiceLocator.Current.Register<CityStatisticService>(_cityStatisticService);
    }
}
