using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternBackground : MonoBehaviour
{
    [SerializeField] private float step;

    private void Update()
    {
        Vector2 cameraPosition = CameraProperties.instance.transform.position;
        float x = (int) cameraPosition.x;
        float y = (int) cameraPosition.y;
        transform.position = new Vector3(x, y, 10);
    }
}
