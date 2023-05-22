using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation.Samples;
using UnityEngine.InputSystem;

[RequireComponent(typeof(ARRaycastManager))]
public class PlaceOnPlane : MonoBehaviour
{
    [SerializeField]
    private GameObject _placedObject;
    private UnityEvent PlacementUpdate;
    [SerializeField]
    private GameObject _visualIndicator;
    private ARRaycastManager _raycastManager;
    bool m_Pressed;

    public GameObject PlacedObject
    {
        get { return _placedObject; }
        set { _placedObject = value; }
    }

    public GameObject spawnedObject { get; private set; }

    private List<ARRaycastHit> _hitList = new List<ARRaycastHit>();


    private void Awake()
    {
        _raycastManager = GetComponent<ARRaycastManager>();

        if (PlacementUpdate == null)
        {
            PlacementUpdate = new UnityEvent();

            PlacementUpdate.AddListener(DisableView);
        }
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }

    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;

        if (_raycastManager.Raycast(touchPosition, _hitList, TrackableType.PlaneWithinPolygon))
        {
            var hitPose = _hitList[0].pose;

            if (spawnedObject != null)
            {
                spawnedObject = Instantiate(PlacedObject, hitPose.position, hitPose.rotation);
            }
            else
            {
                spawnedObject.transform.position = hitPose.position;
            }
            PlacementUpdate.Invoke();
        }
    }

    public void DisableView()
    {
        _visualIndicator.SetActive(false);
    }
}
