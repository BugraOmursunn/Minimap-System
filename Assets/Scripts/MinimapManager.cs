using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MinimapManager : MonoBehaviour
{
    [SerializeField] private Camera minimapCam;
    [SerializeField] private float mapZoomValue = 5;

    [SerializeField] private float iconSizeValue = 1f;
    [SerializeField] private List<GameObject> miniMapIcons;

    private void Start()
    {
        SetValues();
    }
    private void OnValidate()
    {
        SetValues();
    }

    private void SetValues()
    {
        miniMapIcons = GameObject.FindGameObjectsWithTag("MinimapIcon").ToList();
        if (miniMapIcons != null)
        {
            foreach (GameObject item in miniMapIcons)
            {
                item.transform.localScale = new Vector3(iconSizeValue, iconSizeValue, iconSizeValue);
            }
        }

        minimapCam.orthographicSize = mapZoomValue;
    }
}
